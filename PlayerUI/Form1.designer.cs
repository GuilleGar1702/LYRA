namespace PlayerUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panelToolsSubMenu = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.BtnConverter = new System.Windows.Forms.Button();
            this.BtnDownloader = new System.Windows.Forms.Button();
            this.btnTools = new System.Windows.Forms.Button();
            this.btnEqualizer = new System.Windows.Forms.Button();
            this.panelPlaylistSubMenu = new System.Windows.Forms.Panel();
            this.BtnManagePL = new System.Windows.Forms.Button();
            this.BtnNewPL = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.panelMediaSubMenu = new System.Windows.Forms.Panel();
            this.BtnRecentMedia = new System.Windows.Forms.Button();
            this.BtnOpenFolder = new System.Windows.Forms.Button();
            this.BtnOpenFile = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.BtnCapture = new System.Windows.Forms.PictureBox();
            this.LblChange = new System.Windows.Forms.Label();
            this.MTBPosition = new XComponent.SliderBar.MACTrackBar();
            this.MTBVolume = new XComponent.SliderBar.MACTrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.PBShuffle = new System.Windows.Forms.PictureBox();
            this.LblVolumen = new System.Windows.Forms.Label();
            this.LblPosition = new System.Windows.Forms.Label();
            this.LblDuration = new System.Windows.Forms.Label();
            this.BtnVolumen = new System.Windows.Forms.PictureBox();
            this.PBStop = new System.Windows.Forms.PictureBox();
            this.PBRepeat = new System.Windows.Forms.PictureBox();
            this.PBAtras = new System.Windows.Forms.PictureBox();
            this.PBAdelante = new System.Windows.Forms.PictureBox();
            this.PBPlay = new System.Windows.Forms.PictureBox();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelSideMenu.SuspendLayout();
            this.panelToolsSubMenu.SuspendLayout();
            this.panelPlaylistSubMenu.SuspendLayout();
            this.panelMediaSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBShuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAdelante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPlay)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.btnExit);
            this.panelSideMenu.Controls.Add(this.btnHelp);
            this.panelSideMenu.Controls.Add(this.panelToolsSubMenu);
            this.panelSideMenu.Controls.Add(this.btnTools);
            this.panelSideMenu.Controls.Add(this.btnEqualizer);
            this.panelSideMenu.Controls.Add(this.panelPlaylistSubMenu);
            this.panelSideMenu.Controls.Add(this.btnPlaylist);
            this.panelSideMenu.Controls.Add(this.panelMediaSubMenu);
            this.panelSideMenu.Controls.Add(this.btnMedia);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 561);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Silver;
            this.btnExit.Image = global::PlayerUI.Properties.Resources.Exit2;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 647);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(233, 45);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "  Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Silver;
            this.btnHelp.Image = global::PlayerUI.Properties.Resources.Help2;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 602);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(233, 45);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "  Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // panelToolsSubMenu
            // 
            this.panelToolsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.panelToolsSubMenu.Controls.Add(this.button10);
            this.panelToolsSubMenu.Controls.Add(this.BtnConverter);
            this.panelToolsSubMenu.Controls.Add(this.BtnDownloader);
            this.panelToolsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolsSubMenu.Location = new System.Drawing.Point(0, 472);
            this.panelToolsSubMenu.Name = "panelToolsSubMenu";
            this.panelToolsSubMenu.Size = new System.Drawing.Size(233, 130);
            this.panelToolsSubMenu.TabIndex = 7;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Silver;
            this.button10.Location = new System.Drawing.Point(0, 80);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(233, 40);
            this.button10.TabIndex = 2;
            this.button10.Text = "Preferences";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // BtnConverter
            // 
            this.BtnConverter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.BtnConverter.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConverter.FlatAppearance.BorderSize = 0;
            this.BtnConverter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.BtnConverter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.BtnConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConverter.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConverter.ForeColor = System.Drawing.Color.Silver;
            this.BtnConverter.Location = new System.Drawing.Point(0, 40);
            this.BtnConverter.Name = "BtnConverter";
            this.BtnConverter.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnConverter.Size = new System.Drawing.Size(233, 40);
            this.BtnConverter.TabIndex = 1;
            this.BtnConverter.Text = "Media converter";
            this.BtnConverter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConverter.UseVisualStyleBackColor = false;
            this.BtnConverter.Click += new System.EventHandler(this.button12_Click);
            // 
            // BtnDownloader
            // 
            this.BtnDownloader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.BtnDownloader.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDownloader.FlatAppearance.BorderSize = 0;
            this.BtnDownloader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.BtnDownloader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.BtnDownloader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDownloader.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDownloader.ForeColor = System.Drawing.Color.Silver;
            this.BtnDownloader.Location = new System.Drawing.Point(0, 0);
            this.BtnDownloader.Name = "BtnDownloader";
            this.BtnDownloader.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnDownloader.Size = new System.Drawing.Size(233, 40);
            this.BtnDownloader.TabIndex = 0;
            this.BtnDownloader.Text = "Download a video/song";
            this.BtnDownloader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDownloader.UseVisualStyleBackColor = false;
            this.BtnDownloader.Click += new System.EventHandler(this.button13_Click);
            // 
            // btnTools
            // 
            this.btnTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTools.FlatAppearance.BorderSize = 0;
            this.btnTools.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnTools.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTools.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTools.ForeColor = System.Drawing.Color.Silver;
            this.btnTools.Image = global::PlayerUI.Properties.Resources.Tools2;
            this.btnTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTools.Location = new System.Drawing.Point(0, 427);
            this.btnTools.Name = "btnTools";
            this.btnTools.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTools.Size = new System.Drawing.Size(233, 45);
            this.btnTools.TabIndex = 6;
            this.btnTools.Text = "  Tools";
            this.btnTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTools.UseVisualStyleBackColor = true;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // btnEqualizer
            // 
            this.btnEqualizer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEqualizer.FlatAppearance.BorderSize = 0;
            this.btnEqualizer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnEqualizer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnEqualizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqualizer.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqualizer.ForeColor = System.Drawing.Color.Silver;
            this.btnEqualizer.Image = global::PlayerUI.Properties.Resources.Equalizer2;
            this.btnEqualizer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEqualizer.Location = new System.Drawing.Point(0, 382);
            this.btnEqualizer.Name = "btnEqualizer";
            this.btnEqualizer.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEqualizer.Size = new System.Drawing.Size(233, 45);
            this.btnEqualizer.TabIndex = 5;
            this.btnEqualizer.Text = "  Equalizer";
            this.btnEqualizer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEqualizer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEqualizer.UseVisualStyleBackColor = true;
            this.btnEqualizer.Visible = false;
            this.btnEqualizer.Click += new System.EventHandler(this.btnEqualizer_Click);
            // 
            // panelPlaylistSubMenu
            // 
            this.panelPlaylistSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelPlaylistSubMenu.Controls.Add(this.BtnManagePL);
            this.panelPlaylistSubMenu.Controls.Add(this.BtnNewPL);
            this.panelPlaylistSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlaylistSubMenu.Location = new System.Drawing.Point(0, 302);
            this.panelPlaylistSubMenu.Name = "panelPlaylistSubMenu";
            this.panelPlaylistSubMenu.Size = new System.Drawing.Size(233, 80);
            this.panelPlaylistSubMenu.TabIndex = 4;
            // 
            // BtnManagePL
            // 
            this.BtnManagePL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.BtnManagePL.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnManagePL.FlatAppearance.BorderSize = 0;
            this.BtnManagePL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.BtnManagePL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.BtnManagePL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManagePL.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManagePL.ForeColor = System.Drawing.Color.Silver;
            this.BtnManagePL.Location = new System.Drawing.Point(0, 40);
            this.BtnManagePL.Name = "BtnManagePL";
            this.BtnManagePL.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnManagePL.Size = new System.Drawing.Size(233, 40);
            this.BtnManagePL.TabIndex = 1;
            this.BtnManagePL.Text = "Manage playlist";
            this.BtnManagePL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnManagePL.UseVisualStyleBackColor = false;
            this.BtnManagePL.Click += new System.EventHandler(this.button7_Click);
            // 
            // BtnNewPL
            // 
            this.BtnNewPL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.BtnNewPL.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnNewPL.FlatAppearance.BorderSize = 0;
            this.BtnNewPL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.BtnNewPL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.BtnNewPL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewPL.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewPL.ForeColor = System.Drawing.Color.Silver;
            this.BtnNewPL.Location = new System.Drawing.Point(0, 0);
            this.BtnNewPL.Name = "BtnNewPL";
            this.BtnNewPL.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnNewPL.Size = new System.Drawing.Size(233, 40);
            this.BtnNewPL.TabIndex = 0;
            this.BtnNewPL.Text = "New playlist";
            this.BtnNewPL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNewPL.UseVisualStyleBackColor = false;
            this.BtnNewPL.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylist.ForeColor = System.Drawing.Color.Silver;
            this.btnPlaylist.Image = global::PlayerUI.Properties.Resources.PlayList1;
            this.btnPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.Location = new System.Drawing.Point(0, 257);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPlaylist.Size = new System.Drawing.Size(233, 45);
            this.btnPlaylist.TabIndex = 3;
            this.btnPlaylist.Text = "  Playlist management";
            this.btnPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // panelMediaSubMenu
            // 
            this.panelMediaSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMediaSubMenu.Controls.Add(this.BtnRecentMedia);
            this.panelMediaSubMenu.Controls.Add(this.BtnOpenFolder);
            this.panelMediaSubMenu.Controls.Add(this.BtnOpenFile);
            this.panelMediaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMediaSubMenu.Location = new System.Drawing.Point(0, 137);
            this.panelMediaSubMenu.Name = "panelMediaSubMenu";
            this.panelMediaSubMenu.Size = new System.Drawing.Size(233, 120);
            this.panelMediaSubMenu.TabIndex = 2;
            // 
            // BtnRecentMedia
            // 
            this.BtnRecentMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.BtnRecentMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRecentMedia.FlatAppearance.BorderSize = 0;
            this.BtnRecentMedia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.BtnRecentMedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.BtnRecentMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecentMedia.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecentMedia.ForeColor = System.Drawing.Color.Silver;
            this.BtnRecentMedia.Location = new System.Drawing.Point(0, 80);
            this.BtnRecentMedia.Name = "BtnRecentMedia";
            this.BtnRecentMedia.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnRecentMedia.Size = new System.Drawing.Size(233, 40);
            this.BtnRecentMedia.TabIndex = 3;
            this.BtnRecentMedia.Text = "Open recent media";
            this.BtnRecentMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRecentMedia.UseVisualStyleBackColor = false;
            this.BtnRecentMedia.Click += new System.EventHandler(this.button5_Click);
            // 
            // BtnOpenFolder
            // 
            this.BtnOpenFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.BtnOpenFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOpenFolder.FlatAppearance.BorderSize = 0;
            this.BtnOpenFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.BtnOpenFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.BtnOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpenFolder.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOpenFolder.ForeColor = System.Drawing.Color.Silver;
            this.BtnOpenFolder.Location = new System.Drawing.Point(0, 40);
            this.BtnOpenFolder.Name = "BtnOpenFolder";
            this.BtnOpenFolder.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnOpenFolder.Size = new System.Drawing.Size(233, 40);
            this.BtnOpenFolder.TabIndex = 1;
            this.BtnOpenFolder.Text = "Open folder";
            this.BtnOpenFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOpenFolder.UseVisualStyleBackColor = false;
            this.BtnOpenFolder.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.BtnOpenFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOpenFile.FlatAppearance.BorderSize = 0;
            this.BtnOpenFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.BtnOpenFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.BtnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpenFile.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOpenFile.ForeColor = System.Drawing.Color.Silver;
            this.BtnOpenFile.Location = new System.Drawing.Point(0, 0);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnOpenFile.Size = new System.Drawing.Size(233, 40);
            this.BtnOpenFile.TabIndex = 0;
            this.BtnOpenFile.Text = "Open file";
            this.BtnOpenFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOpenFile.UseVisualStyleBackColor = false;
            this.BtnOpenFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedia.FlatAppearance.BorderSize = 0;
            this.btnMedia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnMedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedia.ForeColor = System.Drawing.Color.Silver;
            this.btnMedia.Image = global::PlayerUI.Properties.Resources.Media2;
            this.btnMedia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedia.Location = new System.Drawing.Point(0, 92);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMedia.Size = new System.Drawing.Size(233, 45);
            this.btnMedia.TabIndex = 1;
            this.btnMedia.Text = "  Media";
            this.btnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 92);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelPlayer.Controls.Add(this.BtnCapture);
            this.panelPlayer.Controls.Add(this.LblChange);
            this.panelPlayer.Controls.Add(this.MTBPosition);
            this.panelPlayer.Controls.Add(this.MTBVolume);
            this.panelPlayer.Controls.Add(this.label1);
            this.panelPlayer.Controls.Add(this.PBShuffle);
            this.panelPlayer.Controls.Add(this.LblVolumen);
            this.panelPlayer.Controls.Add(this.LblPosition);
            this.panelPlayer.Controls.Add(this.LblDuration);
            this.panelPlayer.Controls.Add(this.BtnVolumen);
            this.panelPlayer.Controls.Add(this.PBStop);
            this.panelPlayer.Controls.Add(this.PBRepeat);
            this.panelPlayer.Controls.Add(this.PBAtras);
            this.panelPlayer.Controls.Add(this.PBAdelante);
            this.panelPlayer.Controls.Add(this.PBPlay);
            this.panelPlayer.Controls.Add(this.BtnPlay);
            this.panelPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlayer.Location = new System.Drawing.Point(250, 431);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(684, 130);
            this.panelPlayer.TabIndex = 1;
            this.panelPlayer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelPlayer_MouseMove);
            // 
            // BtnCapture
            // 
            this.BtnCapture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnCapture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCapture.Image = global::PlayerUI.Properties.Resources.Capture;
            this.BtnCapture.Location = new System.Drawing.Point(6, 30);
            this.BtnCapture.Name = "BtnCapture";
            this.BtnCapture.Size = new System.Drawing.Size(32, 32);
            this.BtnCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCapture.TabIndex = 24;
            this.BtnCapture.TabStop = false;
            this.BtnCapture.Click += new System.EventHandler(this.BtnCapture_Click);
            // 
            // LblChange
            // 
            this.LblChange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblChange.AutoSize = true;
            this.LblChange.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChange.ForeColor = System.Drawing.Color.LightGray;
            this.LblChange.Location = new System.Drawing.Point(324, 103);
            this.LblChange.Name = "LblChange";
            this.LblChange.Size = new System.Drawing.Size(64, 18);
            this.LblChange.TabIndex = 23;
            this.LblChange.Text = "00:00:00";
            this.LblChange.Visible = false;
            // 
            // MTBPosition
            // 
            this.MTBPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MTBPosition.BackColor = System.Drawing.Color.Transparent;
            this.MTBPosition.BorderColor = System.Drawing.Color.DarkRed;
            this.MTBPosition.Enabled = false;
            this.MTBPosition.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTBPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.MTBPosition.IndentHeight = 6;
            this.MTBPosition.Location = new System.Drawing.Point(71, 80);
            this.MTBPosition.Maximum = 100;
            this.MTBPosition.Minimum = 0;
            this.MTBPosition.Name = "MTBPosition";
            this.MTBPosition.Size = new System.Drawing.Size(543, 28);
            this.MTBPosition.TabIndex = 22;
            this.MTBPosition.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.MTBPosition.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.MTBPosition.TickHeight = 4;
            this.MTBPosition.TickStyle = System.Windows.Forms.TickStyle.None;
            this.MTBPosition.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(49)))), ((int)(((byte)(156)))));
            this.MTBPosition.TrackerSize = new System.Drawing.Size(16, 16);
            this.MTBPosition.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MTBPosition.TrackLineHeight = 3;
            this.MTBPosition.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MTBPosition.Value = 0;
            this.MTBPosition.Scroll += new System.EventHandler(this.MTBPosition_Scroll_1);
            this.MTBPosition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MTBPosition_MouseDown);
            this.MTBPosition.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MTBPosition_MouseUp);
            // 
            // MTBVolume
            // 
            this.MTBVolume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MTBVolume.BackColor = System.Drawing.Color.Transparent;
            this.MTBVolume.BorderColor = System.Drawing.Color.DarkRed;
            this.MTBVolume.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTBVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.MTBVolume.IndentHeight = 6;
            this.MTBVolume.Location = new System.Drawing.Point(404, 32);
            this.MTBVolume.Maximum = 100;
            this.MTBVolume.Minimum = 0;
            this.MTBVolume.Name = "MTBVolume";
            this.MTBVolume.Size = new System.Drawing.Size(200, 28);
            this.MTBVolume.TabIndex = 21;
            this.MTBVolume.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.MTBVolume.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.MTBVolume.TickHeight = 4;
            this.MTBVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.MTBVolume.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(49)))), ((int)(((byte)(156)))));
            this.MTBVolume.TrackerSize = new System.Drawing.Size(16, 16);
            this.MTBVolume.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MTBVolume.TrackLineHeight = 3;
            this.MTBVolume.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MTBVolume.Value = 50;
            this.MTBVolume.Scroll += new System.EventHandler(this.MTBPosition_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 42);
            this.label1.TabIndex = 20;
            // 
            // PBShuffle
            // 
            this.PBShuffle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PBShuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBShuffle.Image = global::PlayerUI.Properties.Resources.ShuffleOff;
            this.PBShuffle.Location = new System.Drawing.Point(94, 30);
            this.PBShuffle.Name = "PBShuffle";
            this.PBShuffle.Size = new System.Drawing.Size(32, 32);
            this.PBShuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBShuffle.TabIndex = 18;
            this.PBShuffle.TabStop = false;
            this.PBShuffle.Click += new System.EventHandler(this.BtnFullScreen_Click);
            // 
            // LblVolumen
            // 
            this.LblVolumen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblVolumen.AutoSize = true;
            this.LblVolumen.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVolumen.ForeColor = System.Drawing.Color.LightGray;
            this.LblVolumen.Location = new System.Drawing.Point(608, 36);
            this.LblVolumen.Name = "LblVolumen";
            this.LblVolumen.Size = new System.Drawing.Size(35, 18);
            this.LblVolumen.TabIndex = 11;
            this.LblVolumen.Text = "50%";
            // 
            // LblPosition
            // 
            this.LblPosition.AutoSize = true;
            this.LblPosition.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPosition.ForeColor = System.Drawing.Color.LightGray;
            this.LblPosition.Location = new System.Drawing.Point(7, 84);
            this.LblPosition.Name = "LblPosition";
            this.LblPosition.Size = new System.Drawing.Size(64, 18);
            this.LblPosition.TabIndex = 10;
            this.LblPosition.Text = "00:00:00";
            // 
            // LblDuration
            // 
            this.LblDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDuration.AutoSize = true;
            this.LblDuration.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDuration.ForeColor = System.Drawing.Color.LightGray;
            this.LblDuration.Location = new System.Drawing.Point(614, 84);
            this.LblDuration.Name = "LblDuration";
            this.LblDuration.Size = new System.Drawing.Size(64, 18);
            this.LblDuration.TabIndex = 9;
            this.LblDuration.Text = "00:00:00";
            // 
            // BtnVolumen
            // 
            this.BtnVolumen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnVolumen.Image = global::PlayerUI.Properties.Resources.Speaker;
            this.BtnVolumen.Location = new System.Drawing.Point(366, 30);
            this.BtnVolumen.Name = "BtnVolumen";
            this.BtnVolumen.Size = new System.Drawing.Size(32, 32);
            this.BtnVolumen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnVolumen.TabIndex = 7;
            this.BtnVolumen.TabStop = false;
            this.BtnVolumen.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // PBStop
            // 
            this.PBStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PBStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBStop.Image = global::PlayerUI.Properties.Resources.Stop;
            this.PBStop.Location = new System.Drawing.Point(135, 30);
            this.PBStop.Name = "PBStop";
            this.PBStop.Size = new System.Drawing.Size(32, 32);
            this.PBStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBStop.TabIndex = 5;
            this.PBStop.TabStop = false;
            this.PBStop.Click += new System.EventHandler(this.PBStop_Click);
            // 
            // PBRepeat
            // 
            this.PBRepeat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PBRepeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBRepeat.Image = global::PlayerUI.Properties.Resources.RepeatOff;
            this.PBRepeat.Location = new System.Drawing.Point(327, 30);
            this.PBRepeat.Name = "PBRepeat";
            this.PBRepeat.Size = new System.Drawing.Size(32, 32);
            this.PBRepeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBRepeat.TabIndex = 4;
            this.PBRepeat.TabStop = false;
            this.PBRepeat.Click += new System.EventHandler(this.PBRepeat_Click);
            this.PBRepeat.DoubleClick += new System.EventHandler(this.PBRepeat_DoubleClick);
            // 
            // PBAtras
            // 
            this.PBAtras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PBAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBAtras.Image = global::PlayerUI.Properties.Resources.atras;
            this.PBAtras.Location = new System.Drawing.Point(177, 30);
            this.PBAtras.Name = "PBAtras";
            this.PBAtras.Size = new System.Drawing.Size(32, 32);
            this.PBAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBAtras.TabIndex = 3;
            this.PBAtras.TabStop = false;
            this.PBAtras.Click += new System.EventHandler(this.PBAtras_Click);
            this.PBAtras.DoubleClick += new System.EventHandler(this.PBAtras_DoubleClick);
            // 
            // PBAdelante
            // 
            this.PBAdelante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PBAdelante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBAdelante.Image = global::PlayerUI.Properties.Resources.adelante;
            this.PBAdelante.Location = new System.Drawing.Point(286, 30);
            this.PBAdelante.Name = "PBAdelante";
            this.PBAdelante.Size = new System.Drawing.Size(32, 32);
            this.PBAdelante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBAdelante.TabIndex = 2;
            this.PBAdelante.TabStop = false;
            this.PBAdelante.Click += new System.EventHandler(this.PBAdelante_Click);
            this.PBAdelante.DoubleClick += new System.EventHandler(this.PBAdelante_DoubleClick);
            // 
            // PBPlay
            // 
            this.PBPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PBPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBPlay.Image = global::PlayerUI.Properties.Resources.play2;
            this.PBPlay.Location = new System.Drawing.Point(233, 30);
            this.PBPlay.Name = "PBPlay";
            this.PBPlay.Size = new System.Drawing.Size(32, 32);
            this.PBPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBPlay.TabIndex = 1;
            this.PBPlay.TabStop = false;
            this.PBPlay.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnPlay.Location = new System.Drawing.Point(24, 27);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(28, 30);
            this.BtnPlay.TabIndex = 19;
            this.BtnPlay.Text = "button2";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.panelChildForm.Controls.Add(this.Player);
            this.panelChildForm.Controls.Add(this.pictureBox9);
            this.panelChildForm.Controls.Add(this.pictureBox10);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(684, 431);
            this.panelChildForm.TabIndex = 2;
            this.panelChildForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelChildForm_MouseMove);
            // 
            // Player
            // 
            this.Player.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(0, 0);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(684, 431);
            this.Player.TabIndex = 4;
            this.Player.Visible = false;
            this.Player.ClickEvent += new AxWMPLib._WMPOCXEvents_ClickEventHandler(this.Player_ClickEvent);
            this.Player.MouseMoveEvent += new AxWMPLib._WMPOCXEvents_MouseMoveEventHandler(this.Player_MouseMoveEvent);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(233, 67);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(220, 220);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 2;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(233, 268);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(220, 92);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 3;
            this.pictureBox10.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LYRA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panelSideMenu.ResumeLayout(false);
            this.panelToolsSubMenu.ResumeLayout(false);
            this.panelPlaylistSubMenu.ResumeLayout(false);
            this.panelMediaSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPlayer.ResumeLayout(false);
            this.panelPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBShuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAdelante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPlay)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelMediaSubMenu;
        private System.Windows.Forms.Button BtnRecentMedia;
        private System.Windows.Forms.Button BtnOpenFolder;
        private System.Windows.Forms.Button BtnOpenFile;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel panelToolsSubMenu;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button BtnConverter;
        private System.Windows.Forms.Button BtnDownloader;
        private System.Windows.Forms.Button btnTools;
        private System.Windows.Forms.Button btnEqualizer;
        private System.Windows.Forms.Panel panelPlaylistSubMenu;
        private System.Windows.Forms.Button BtnManagePL;
        private System.Windows.Forms.Button BtnNewPL;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Label LblDuration;
        private System.Windows.Forms.PictureBox BtnVolumen;
        private System.Windows.Forms.PictureBox PBStop;
        private System.Windows.Forms.PictureBox PBRepeat;
        private System.Windows.Forms.PictureBox PBAtras;
        private System.Windows.Forms.PictureBox PBAdelante;
        private System.Windows.Forms.PictureBox PBPlay;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label LblPosition;
        private System.Windows.Forms.Label LblVolumen;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.PictureBox PBShuffle;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Label label1;
        private XComponent.SliderBar.MACTrackBar MTBVolume;
        private XComponent.SliderBar.MACTrackBar MTBPosition;
        private System.Windows.Forms.Label LblChange;
        private System.Windows.Forms.PictureBox BtnCapture;
    }
}

