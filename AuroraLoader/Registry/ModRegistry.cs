﻿using AuroraLoader.Mods;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json;

namespace AuroraLoader.Registry
{
    /// <summary>
    /// Must be initialized by calling Update()
    /// </summary>
    public class ModRegistry
    {
        // TODO ensure that the list is unique
        public IEnumerable<Mod> Mods { get; private set; }

        public Mod AuroraLoaderMod => Mods.SingleOrDefault(mod => mod.Name == "AuroraLoader");

        private readonly IConfiguration _configuration;

        public IList<string> Mirrors { get; private set; }

        public ModRegistry(IConfiguration configuration)
        {
            _configuration = configuration;
            Mirrors = ModConfigurationReader.GetMirrorsFromIni();
        }

        public void Update(AuroraVersion version, bool updateRemote = false, bool updateCache = false)
        {
            Log.Debug($"Updating mod registry, updateRemote={updateRemote} updateCache={updateCache}");

            var mods = GetLocalMods();
            IList<Mod> remote = new List<Mod>();
            if (updateRemote)
            {
                remote = GetModsFromMirrors();
            }

            foreach (var remoteMod in remote)
            {
                var existingMod = mods.SingleOrDefault(mod => mod.Name == remoteMod.Name);
                if (existingMod != null)
                {
                    var updatedDownloadList = existingMod.Downloads.ToList();
                    updatedDownloadList.AddRange(remoteMod.Downloads.Where(nd => !existingMod.Downloads.Any(ed => ed.Version == nd.Version)));
                    remoteMod.Downloads = updatedDownloadList;
                    mods.Remove(existingMod);
                    mods.Add(remoteMod);
                }
                else
                {
                    mods.Add(remoteMod);
                }
            }

            foreach (var mod in mods.ToList())
            {
                mod.Downloads.RemoveAll(d => !version.CompatibleWith(d.TargetAuroraVersion));
                if (mod.Downloads.Count == 0)
                {
                    mods.Remove(mod);
                }
            }

            Mods = mods;

            if (updateRemote && updateCache)
            {
                foreach (var mod in Mods.Where(mod => mod.Installed))
                {
                    mod.UpdateCache();
                }
            }
            else if (updateCache && !updateRemote)
            {
                throw new ArgumentException("Updating cache without updating remote does nothing");
            }
        }

        // Mods installed locally are identified by mod.json file in <root>/Mods/<ModName>
        private IList<Mod> GetLocalMods()
        {
            var mods = new List<Mod>();
            foreach (var modDirectory in Directory.EnumerateDirectories(Program.ModDirectory))
            {
                if (File.Exists(Path.Combine(modDirectory, "mod.json")))
                {
                    var modJsonFile = Path.Combine(modDirectory, "mod.json");
                    Log.Debug($"Loading local mod from {modJsonFile}");

                    try
                    {
                        mods.Add(Mod.DeserializeMod(File.ReadAllText(modJsonFile)));
                    }
                    catch (Exception e)
                    {
                        Log.Error($"Failed to parse mod data from {modJsonFile}", e);
                    }
                }
            }
            return mods;
        }

        private IList<Mod> GetModsFromMirrors()
        {
            var remoteMods = new List<Mod>();
            foreach (var mirror in Mirrors)
            {
                var modLocationsUrl = Path.Combine(mirror, "mod_locations.json");
                try
                {
                    remoteMods.AddRange(GetModsAtMirror(modLocationsUrl));
                }
                catch (Exception e)
                {
                    // TODO evaluate throwing or something
                    Log.Error($"Failed to download mod locations from {modLocationsUrl}", e);
                }

            }
            return remoteMods;
        }

        private IList<Mod> GetModsAtMirror(string mirrorUrl)
        {
            var modsAtMirror = new List<Mod>();
            using (var client = new WebClient())
            {
                var modJsonUrls = JsonSerializer.Deserialize<IList<string>>(client.DownloadString(mirrorUrl));
                foreach (var modJsonUrl in modJsonUrls)
                {
                    try
                    {
                        var response = client.DownloadString(modJsonUrl);
                        modsAtMirror.Add(Mod.DeserializeMod(response));
                    }
                    catch (Exception e)
                    {
                        // TODO evaluate throwing or something
                        Log.Error($"Failed to download {modJsonUrl}", e);
                    }
                }
            }
            return modsAtMirror;
        }

        public void UpdateAuroraLoader()
        {
            if (AuroraLoaderMod == null)
            {
                throw new Exception("AuroraLoader mod not loaded");
            }
            AuroraLoaderMod.LatestVersion.Download();

            File.Copy(Path.Combine(AuroraLoaderMod.LatestVersion.DownloadPath, "AuroraLoader.exe"), Path.Combine(Program.AuroraLoaderExecutableDirectory, "AuroraLoader_new.exe"), true);
            foreach (var file in new string[]
            {
                "mod.json",
                "mirrors.ini",
                "aurora_versions.ini"
            })
            {
                try
                {
                    File.Copy(Path.Combine(AuroraLoaderMod.LatestVersion.DownloadPath, file), Path.Combine(Program.AuroraLoaderExecutableDirectory, file), true);
                }
                catch (Exception e)
                {
                    Log.Error($"Failed to copy {file} while updating Aurora", e);
                }
            }
            AuroraLoaderMod.UpdateCache();
        }

        internal IEnumerable<object> GetMods(object database, AuroraVersion currentAuroraVersion)
        {
            throw new NotImplementedException();
        }
    }
}
