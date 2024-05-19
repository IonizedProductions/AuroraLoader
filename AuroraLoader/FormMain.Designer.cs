using System.Windows.Forms;

namespace AuroraLoader
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            ButtonSinglePlayer = new Button();
            LabelAuroraVersion = new Label();
            TrackMusicVolume = new TrackBar();
            CheckEnableMusic = new CheckBox();
            ButtonReadme = new Button();
            ButtonChangelog = new Button();
            LabelAuroraLoaderVersion = new Label();
            CheckEnableMods = new CheckBox();
            CheckEnablePoweruserMods = new CheckBox();
            ComboSelectExecutableMod = new ComboBox();
            ListDatabaseMods = new CheckedListBox();
            ListUtilities = new CheckedListBox();
            LinkForums = new LinkLabel();
            LinkReportBug = new LinkLabel();
            LinkSubreddit = new LinkLabel();
            LinkDiscord = new LinkLabel();
            LabelUtilities = new Label();
            LabelDatabaseMods = new Label();
            LinkModSubreddit = new LinkLabel();
            ButtonMultiplayer = new Button();
            ButtonManageMods = new Button();
            SelectedSavelabel = new Label();
            ButtonMangeSaves = new Button();
            PictureBoxUpdateAurora = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)TrackMusicVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxUpdateAurora).BeginInit();
            SuspendLayout();
            // 
            // ButtonSinglePlayer
            // 
            ButtonSinglePlayer.Enabled = false;
            ButtonSinglePlayer.Location = new System.Drawing.Point(12, 46);
            ButtonSinglePlayer.Margin = new Padding(4);
            ButtonSinglePlayer.Name = "ButtonSinglePlayer";
            ButtonSinglePlayer.Size = new System.Drawing.Size(84, 24);
            ButtonSinglePlayer.TabIndex = 2;
            ButtonSinglePlayer.Text = "Play";
            ButtonSinglePlayer.UseVisualStyleBackColor = true;
            ButtonSinglePlayer.Click += ButtonSinglePlayer_Click;
            // 
            // LabelAuroraVersion
            // 
            LabelAuroraVersion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LabelAuroraVersion.Location = new System.Drawing.Point(410, 252);
            LabelAuroraVersion.Margin = new Padding(4, 0, 4, 0);
            LabelAuroraVersion.Name = "LabelAuroraVersion";
            LabelAuroraVersion.Size = new System.Drawing.Size(133, 15);
            LabelAuroraVersion.TabIndex = 7;
            LabelAuroraVersion.Text = "Aurora v#.##.#";
            LabelAuroraVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TrackMusicVolume
            // 
            TrackMusicVolume.Enabled = false;
            TrackMusicVolume.LargeChange = 1;
            TrackMusicVolume.Location = new System.Drawing.Point(219, 46);
            TrackMusicVolume.Margin = new Padding(4);
            TrackMusicVolume.Name = "TrackMusicVolume";
            TrackMusicVolume.Size = new System.Drawing.Size(162, 45);
            TrackMusicVolume.TabIndex = 20;
            TrackMusicVolume.Value = 4;
            // 
            // CheckEnableMusic
            // 
            CheckEnableMusic.AutoSize = true;
            CheckEnableMusic.Location = new System.Drawing.Point(104, 51);
            CheckEnableMusic.Margin = new Padding(4);
            CheckEnableMusic.Name = "CheckEnableMusic";
            CheckEnableMusic.Size = new System.Drawing.Size(107, 19);
            CheckEnableMusic.TabIndex = 2;
            CheckEnableMusic.Text = "In-Game Music";
            CheckEnableMusic.UseVisualStyleBackColor = true;
            CheckEnableMusic.CheckedChanged += CheckMusic_CheckedChanged;
            // 
            // ButtonReadme
            // 
            ButtonReadme.Location = new System.Drawing.Point(395, 12);
            ButtonReadme.Margin = new Padding(4);
            ButtonReadme.Name = "ButtonReadme";
            ButtonReadme.Size = new System.Drawing.Size(84, 24);
            ButtonReadme.TabIndex = 13;
            ButtonReadme.Text = "Readme";
            ButtonReadme.UseVisualStyleBackColor = true;
            ButtonReadme.Click += ButtonReadme_Click;
            // 
            // ButtonChangelog
            // 
            ButtonChangelog.Location = new System.Drawing.Point(495, 12);
            ButtonChangelog.Margin = new Padding(4);
            ButtonChangelog.Name = "ButtonChangelog";
            ButtonChangelog.Size = new System.Drawing.Size(84, 24);
            ButtonChangelog.TabIndex = 14;
            ButtonChangelog.Text = "Changelog";
            ButtonChangelog.UseVisualStyleBackColor = true;
            ButtonChangelog.Click += ButtonChangelog_Click;
            // 
            // LabelAuroraLoaderVersion
            // 
            LabelAuroraLoaderVersion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LabelAuroraLoaderVersion.Location = new System.Drawing.Point(290, 252);
            LabelAuroraLoaderVersion.Margin = new Padding(4, 0, 4, 0);
            LabelAuroraLoaderVersion.Name = "LabelAuroraLoaderVersion";
            LabelAuroraLoaderVersion.Size = new System.Drawing.Size(133, 15);
            LabelAuroraLoaderVersion.TabIndex = 7;
            LabelAuroraLoaderVersion.Text = "Loader v#.##.#";
            LabelAuroraLoaderVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CheckEnableMods
            // 
            CheckEnableMods.AutoSize = true;
            CheckEnableMods.Location = new System.Drawing.Point(12, 81);
            CheckEnableMods.Name = "CheckEnableMods";
            CheckEnableMods.Size = new System.Drawing.Size(94, 19);
            CheckEnableMods.TabIndex = 21;
            CheckEnableMods.Text = "Enable Mods";
            CheckEnableMods.UseVisualStyleBackColor = true;
            CheckEnableMods.CheckedChanged += CheckEnableMods_CheckChanged;
            // 
            // CheckEnablePoweruserMods
            // 
            CheckEnablePoweruserMods.AutoSize = true;
            CheckEnablePoweruserMods.Location = new System.Drawing.Point(104, 80);
            CheckEnablePoweruserMods.Name = "CheckEnablePoweruserMods";
            CheckEnablePoweruserMods.Size = new System.Drawing.Size(152, 19);
            CheckEnablePoweruserMods.TabIndex = 23;
            CheckEnablePoweruserMods.Text = "Enable Poweruser Mods";
            CheckEnablePoweruserMods.UseVisualStyleBackColor = true;
            CheckEnablePoweruserMods.CheckedChanged += CheckEnablePoweruserMod_CheckChanged;
            // 
            // ComboSelectExecutableMod
            // 
            ComboSelectExecutableMod.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboSelectExecutableMod.FormattingEnabled = true;
            ComboSelectExecutableMod.Location = new System.Drawing.Point(262, 77);
            ComboSelectExecutableMod.Name = "ComboSelectExecutableMod";
            ComboSelectExecutableMod.Size = new System.Drawing.Size(216, 23);
            ComboSelectExecutableMod.TabIndex = 27;
            // 
            // ListDatabaseMods
            // 
            ListDatabaseMods.FormattingEnabled = true;
            ListDatabaseMods.Location = new System.Drawing.Point(317, 138);
            ListDatabaseMods.Name = "ListDatabaseMods";
            ListDatabaseMods.Size = new System.Drawing.Size(264, 94);
            ListDatabaseMods.TabIndex = 26;
            // 
            // ListUtilities
            // 
            ListUtilities.FormattingEnabled = true;
            ListUtilities.Location = new System.Drawing.Point(12, 138);
            ListUtilities.Name = "ListUtilities";
            ListUtilities.Size = new System.Drawing.Size(264, 94);
            ListUtilities.TabIndex = 27;
            ListUtilities.SelectedIndexChanged += ListUtilityMods_SelectedIndexChanged;
            // 
            // LinkForums
            // 
            LinkForums.AutoSize = true;
            LinkForums.Location = new System.Drawing.Point(496, 51);
            LinkForums.Name = "LinkForums";
            LinkForums.Size = new System.Drawing.Size(88, 15);
            LinkForums.TabIndex = 33;
            LinkForums.TabStop = true;
            LinkForums.Text = "Official Forums";
            LinkForums.LinkClicked += LinkForums_LinkClicked;
            // 
            // LinkReportBug
            // 
            LinkReportBug.AutoSize = true;
            LinkReportBug.Location = new System.Drawing.Point(508, 111);
            LinkReportBug.Name = "LinkReportBug";
            LinkReportBug.Size = new System.Drawing.Size(75, 15);
            LinkReportBug.TabIndex = 34;
            LinkReportBug.TabStop = true;
            LinkReportBug.Text = "Report a Bug";
            LinkReportBug.LinkClicked += LinkVanillaBug_LinkClicked;
            // 
            // LinkSubreddit
            // 
            LinkSubreddit.AutoSize = true;
            LinkSubreddit.Location = new System.Drawing.Point(484, 66);
            LinkSubreddit.Name = "LinkSubreddit";
            LinkSubreddit.Size = new System.Drawing.Size(97, 15);
            LinkSubreddit.TabIndex = 35;
            LinkSubreddit.TabStop = true;
            LinkSubreddit.Text = "Aurora Subreddit";
            LinkSubreddit.LinkClicked += LinkVanillaSubreddit_LinkClicked;
            // 
            // LinkDiscord
            // 
            LinkDiscord.AutoSize = true;
            LinkDiscord.Location = new System.Drawing.Point(537, 96);
            LinkDiscord.Name = "LinkDiscord";
            LinkDiscord.Size = new System.Drawing.Size(47, 15);
            LinkDiscord.TabIndex = 36;
            LinkDiscord.TabStop = true;
            LinkDiscord.Text = "Discord";
            LinkDiscord.LinkClicked += LinkDiscord_LinkClicked;
            // 
            // LabelUtilities
            // 
            LabelUtilities.AutoSize = true;
            LabelUtilities.Location = new System.Drawing.Point(12, 111);
            LabelUtilities.Name = "LabelUtilities";
            LabelUtilities.Size = new System.Drawing.Size(183, 15);
            LabelUtilities.TabIndex = 38;
            LabelUtilities.Text = "Launch utilities alongside Aurora:";
            // 
            // LabelDatabaseMods
            // 
            LabelDatabaseMods.AutoSize = true;
            LabelDatabaseMods.Location = new System.Drawing.Point(317, 111);
            LabelDatabaseMods.Name = "LabelDatabaseMods";
            LabelDatabaseMods.Size = new System.Drawing.Size(124, 15);
            LabelDatabaseMods.TabIndex = 39;
            LabelDatabaseMods.Text = "Apply database mods:";
            // 
            // LinkModSubreddit
            // 
            LinkModSubreddit.AutoSize = true;
            LinkModSubreddit.Location = new System.Drawing.Point(495, 81);
            LinkModSubreddit.Name = "LinkModSubreddit";
            LinkModSubreddit.Size = new System.Drawing.Size(86, 15);
            LinkModSubreddit.TabIndex = 35;
            LinkModSubreddit.TabStop = true;
            LinkModSubreddit.Text = "Mod Subreddit";
            LinkModSubreddit.LinkClicked += LinkVanillaSubreddit_LinkClicked;
            // 
            // ButtonMultiplayer
            // 
            ButtonMultiplayer.Location = new System.Drawing.Point(122, 243);
            ButtonMultiplayer.Margin = new Padding(4);
            ButtonMultiplayer.Name = "ButtonMultiplayer";
            ButtonMultiplayer.Size = new System.Drawing.Size(103, 27);
            ButtonMultiplayer.TabIndex = 2;
            ButtonMultiplayer.Text = "Play Multiplayer";
            ButtonMultiplayer.UseVisualStyleBackColor = true;
            ButtonMultiplayer.Click += ButtonSinglePlayer_Click;
            // 
            // ButtonManageMods
            // 
            ButtonManageMods.Location = new System.Drawing.Point(12, 243);
            ButtonManageMods.Name = "ButtonManageMods";
            ButtonManageMods.Size = new System.Drawing.Size(103, 27);
            ButtonManageMods.TabIndex = 41;
            ButtonManageMods.Text = "Manage Mods";
            ButtonManageMods.UseVisualStyleBackColor = true;
            ButtonManageMods.Click += ButtonManageMods_Click;
            // 
            // SelectedSavelabel
            // 
            SelectedSavelabel.AutoSize = true;
            SelectedSavelabel.Location = new System.Drawing.Point(102, 18);
            SelectedSavelabel.Name = "SelectedSavelabel";
            SelectedSavelabel.Size = new System.Drawing.Size(102, 15);
            SelectedSavelabel.TabIndex = 42;
            SelectedSavelabel.Text = "No game selected";
            // 
            // ButtonMangeSaves
            // 
            ButtonMangeSaves.Location = new System.Drawing.Point(12, 12);
            ButtonMangeSaves.Name = "ButtonMangeSaves";
            ButtonMangeSaves.Size = new System.Drawing.Size(84, 27);
            ButtonMangeSaves.TabIndex = 41;
            ButtonMangeSaves.Text = "Select Game";
            ButtonMangeSaves.UseVisualStyleBackColor = true;
            ButtonMangeSaves.Click += ButtonManageSaves_Click;
            // 
            // PictureBoxUpdateAurora
            // 
            PictureBoxUpdateAurora.Image = (System.Drawing.Image)resources.GetObject("PictureBoxUpdateAurora.Image");
            PictureBoxUpdateAurora.Location = new System.Drawing.Point(547, 238);
            PictureBoxUpdateAurora.Name = "PictureBoxUpdateAurora";
            PictureBoxUpdateAurora.Size = new System.Drawing.Size(32, 32);
            PictureBoxUpdateAurora.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxUpdateAurora.TabIndex = 43;
            PictureBoxUpdateAurora.TabStop = false;
            PictureBoxUpdateAurora.Click += ButtonUpdateAurora_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(605, 287);
            Controls.Add(PictureBoxUpdateAurora);
            Controls.Add(ButtonMangeSaves);
            Controls.Add(SelectedSavelabel);
            Controls.Add(ButtonManageMods);
            Controls.Add(ButtonMultiplayer);
            Controls.Add(LinkModSubreddit);
            Controls.Add(LabelDatabaseMods);
            Controls.Add(LabelUtilities);
            Controls.Add(LinkDiscord);
            Controls.Add(LinkSubreddit);
            Controls.Add(LinkReportBug);
            Controls.Add(LinkForums);
            Controls.Add(ListUtilities);
            Controls.Add(ListDatabaseMods);
            Controls.Add(ComboSelectExecutableMod);
            Controls.Add(CheckEnablePoweruserMods);
            Controls.Add(CheckEnableMods);
            Controls.Add(LabelAuroraLoaderVersion);
            Controls.Add(ButtonReadme);
            Controls.Add(ButtonChangelog);
            Controls.Add(CheckEnableMusic);
            Controls.Add(TrackMusicVolume);
            Controls.Add(LabelAuroraVersion);
            Controls.Add(ButtonSinglePlayer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormMain";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aurora Loader";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)TrackMusicVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxUpdateAurora).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ButtonSinglePlayer;
        private Label LabelAuroraVersion;
        private TrackBar TrackMusicVolume;
        private CheckBox CheckEnableMusic;
        private Button ButtonReadme;
        private Button ButtonChangelog;
        private Label LabelAuroraLoaderVersion;
        private CheckBox CheckEnableMods;
        private CheckBox CheckEnablePoweruserMods;
        private ComboBox ComboSelectExecutableMod;
        private CheckedListBox ListDatabaseMods;
        private CheckedListBox ListUtilities;
        private LinkLabel LinkForums;
        private LinkLabel LinkReportBug;
        private LinkLabel LinkSubreddit;
        private LinkLabel LinkDiscord;
        private Label LabelUtilities;
        private Label LabelDatabaseMods;
        private LinkLabel LinkModSubreddit;
        private Button ButtonMultiplayer;
        private Button ButtonManageMods;
        private Label SelectedSavelabel;
        private Button ButtonMangeSaves;
        private PictureBox PictureBoxUpdateAurora;
        private PictureBox PictureBoxUpdateLoader;
    }
}

