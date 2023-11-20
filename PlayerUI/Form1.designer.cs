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
            this.panelToolsSubMenu = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.panelPlaylistSubMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.BtnManagePL = new System.Windows.Forms.Button();
            this.BtnNewPL = new System.Windows.Forms.Button();
            this.panelMediaSubMenu = new System.Windows.Forms.Panel();
            this.BtnRecentMedia = new System.Windows.Forms.Button();
            this.BtnOpenFolder = new System.Windows.Forms.Button();
            this.BtnOpenFile = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PBMedia = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.LblVolumen = new System.Windows.Forms.Label();
            this.LblPosition = new System.Windows.Forms.Label();
            this.LblDuration = new System.Windows.Forms.Label();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.BtnFullScreen = new System.Windows.Forms.PictureBox();
            this.BtnVolumen = new System.Windows.Forms.PictureBox();
            this.PBStop = new System.Windows.Forms.PictureBox();
            this.PBRepeat = new System.Windows.Forms.PictureBox();
            this.PBAtras = new System.Windows.Forms.PictureBox();
            this.PBAdelante = new System.Windows.Forms.PictureBox();
            this.PBPlay = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnTools = new System.Windows.Forms.Button();
            this.btnEqualizer = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelToolsSubMenu.SuspendLayout();
            this.panelPlaylistSubMenu.SuspendLayout();
            this.panelMediaSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFullScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAdelante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // panelToolsSubMenu
            // 
            this.panelToolsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.panelToolsSubMenu.Controls.Add(this.button10);
            this.panelToolsSubMenu.Controls.Add(this.button12);
            this.panelToolsSubMenu.Controls.Add(this.button13);
            this.panelToolsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolsSubMenu.Location = new System.Drawing.Point(0, 551);
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
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.button12.Dock = System.Windows.Forms.DockStyle.Top;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.Silver;
            this.button12.Location = new System.Drawing.Point(0, 40);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(233, 40);
            this.button12.TabIndex = 1;
            this.button12.Text = "Effects and filters";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.button13.Dock = System.Windows.Forms.DockStyle.Top;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.Silver;
            this.button13.Location = new System.Drawing.Point(0, 0);
            this.button13.Name = "button13";
            this.button13.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button13.Size = new System.Drawing.Size(233, 40);
            this.button13.TabIndex = 0;
            this.button13.Text = "Media converter";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // panelPlaylistSubMenu
            // 
            this.panelPlaylistSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelPlaylistSubMenu.Controls.Add(this.button1);
            this.panelPlaylistSubMenu.Controls.Add(this.button6);
            this.panelPlaylistSubMenu.Controls.Add(this.BtnManagePL);
            this.panelPlaylistSubMenu.Controls.Add(this.BtnNewPL);
            this.panelPlaylistSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlaylistSubMenu.Location = new System.Drawing.Point(0, 302);
            this.panelPlaylistSubMenu.Name = "panelPlaylistSubMenu";
            this.panelPlaylistSubMenu.Size = new System.Drawing.Size(233, 159);
            this.panelPlaylistSubMenu.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(0, 120);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(233, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Export playlist";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(35)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Silver;
            this.button6.Location = new System.Drawing.Point(0, 80);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(233, 40);
            this.button6.TabIndex = 2;
            this.button6.Text = "Import playlist";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
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
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 92);
            this.panelLogo.TabIndex = 0;
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelPlayer.Controls.Add(this.label1);
            this.panelPlayer.Controls.Add(this.BtnFullScreen);
            this.panelPlayer.Controls.Add(this.label5);
            this.panelPlayer.Controls.Add(this.label6);
            this.panelPlayer.Controls.Add(this.PBMedia);
            this.panelPlayer.Controls.Add(this.label4);
            this.panelPlayer.Controls.Add(this.label3);
            this.panelPlayer.Controls.Add(this.trackBar1);
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
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 42);
            this.label1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(62, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(560, 13);
            this.label5.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(65, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(557, 13);
            this.label6.TabIndex = 16;
            // 
            // PBMedia
            // 
            this.PBMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PBMedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBMedia.Location = new System.Drawing.Point(67, 72);
            this.PBMedia.Maximum = 100;
            this.PBMedia.Name = "PBMedia";
            this.PBMedia.Size = new System.Drawing.Size(548, 45);
            this.PBMedia.TabIndex = 15;
            this.PBMedia.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.PBMedia.Scroll += new System.EventHandler(this.PBMedia_Scroll);
            this.PBMedia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PBMedia_MouseDown);
            this.PBMedia.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PBMedia_MouseUp);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Location = new System.Drawing.Point(413, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 13);
            this.label4.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Location = new System.Drawing.Point(409, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 13);
            this.label3.TabIndex = 13;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(402, 24);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(200, 45);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
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
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // BtnFullScreen
            // 
            this.BtnFullScreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnFullScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFullScreen.Image = ((System.Drawing.Image)(resources.GetObject("BtnFullScreen.Image")));
            this.BtnFullScreen.Location = new System.Drawing.Point(94, 30);
            this.BtnFullScreen.Name = "BtnFullScreen";
            this.BtnFullScreen.Size = new System.Drawing.Size(32, 32);
            this.BtnFullScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnFullScreen.TabIndex = 18;
            this.BtnFullScreen.TabStop = false;
            this.BtnFullScreen.Click += new System.EventHandler(this.BtnFullScreen_Click);
            // 
            // BtnVolumen
            // 
            this.BtnVolumen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnVolumen.Image = ((System.Drawing.Image)(resources.GetObject("BtnVolumen.Image")));
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
            this.PBRepeat.Image = global::PlayerUI.Properties.Resources.Repeat;
            this.PBRepeat.Location = new System.Drawing.Point(327, 30);
            this.PBRepeat.Name = "PBRepeat";
            this.PBRepeat.Size = new System.Drawing.Size(32, 32);
            this.PBRepeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBRepeat.TabIndex = 4;
            this.PBRepeat.TabStop = false;
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
            this.btnExit.Location = new System.Drawing.Point(0, 726);
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
            this.btnHelp.Location = new System.Drawing.Point(0, 681);
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
            this.btnTools.Location = new System.Drawing.Point(0, 506);
            this.btnTools.Name = "btnTools";
            this.btnTools.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTools.Size = new System.Drawing.Size(233, 45);
            this.btnTools.TabIndex = 6;
            this.btnTools.Text = "  Tools";
            this.btnTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTools.UseVisualStyleBackColor = true;
            this.btnTools.Visible = false;
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
            this.btnEqualizer.Location = new System.Drawing.Point(0, 461);
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
            this.panelSideMenu.ResumeLayout(false);
            this.panelToolsSubMenu.ResumeLayout(false);
            this.panelPlaylistSubMenu.ResumeLayout(false);
            this.panelMediaSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelPlayer.ResumeLayout(false);
            this.panelPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFullScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAdelante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button btnTools;
        private System.Windows.Forms.Button btnEqualizer;
        private System.Windows.Forms.Panel panelPlaylistSubMenu;
        private System.Windows.Forms.Button button6;
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
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar PBMedia;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.PictureBox BtnFullScreen;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Label label1;
    }
}

