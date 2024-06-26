﻿using System.Text.Json.Serialization;

namespace AuroraLoader.Mods
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ModType { EXECUTABLE, DATABASE, UTILITY, ROOTUTILITY, THEME,
        Database
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ModStatus { POWERUSER, PUBLIC, APPROVED }
}
