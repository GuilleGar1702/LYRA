namespace PlayerUI
{
    partial class VideoDL
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
            this.button5 = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnDownload = new System.Windows.Forms.Button();
            this.TBRuta = new System.Windows.Forms.TextBox();
            this.LblFolder = new System.Windows.Forms.Label();
            this.PBDownload = new System.Windows.Forms.ProgressBar();
            this.LblChange = new System.Windows.Forms.Label();
            this.CBVideoQ = new System.Windows.Forms.ComboBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(55)))), ((int)(((byte)(179)))));
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 33);
            this.button5.TabIndex = 12;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.Color.LightGray;
            this.BtnSearch.Location = new System.Drawing.Point(478, 137);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(150, 40);
            this.BtnSearch.TabIndex = 11;
            this.BtnSearch.Text = "SEARCH";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnDownload
            // 
            this.BtnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.BtnDownload.Enabled = false;
            this.BtnDownload.FlatAppearance.BorderSize = 0;
            this.BtnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDownload.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDownload.ForeColor = System.Drawing.Color.LightGray;
            this.BtnDownload.Location = new System.Drawing.Point(478, 211);
            this.BtnDownload.Name = "BtnDownload";
            this.BtnDownload.Size = new System.Drawing.Size(150, 40);
            this.BtnDownload.TabIndex = 10;
            this.BtnDownload.Text = "DOWNLOAD";
            this.BtnDownload.UseVisualStyleBackColor = false;
            this.BtnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // TBRuta
            // 
            this.TBRuta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.TBRuta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBRuta.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBRuta.ForeColor = System.Drawing.Color.White;
            this.TBRuta.Location = new System.Drawing.Point(12, 60);
            this.TBRuta.Name = "TBRuta";
            this.TBRuta.Size = new System.Drawing.Size(660, 40);
            this.TBRuta.TabIndex = 9;
            this.TBRuta.Text = "VideoID";
            this.TBRuta.Click += new System.EventHandler(this.TBRuta_Click);
            this.TBRuta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBRuta_KeyPress);
            // 
            // LblFolder
            // 
            this.LblFolder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblFolder.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(55)))), ((int)(((byte)(179)))));
            this.LblFolder.Location = new System.Drawing.Point(12, 14);
            this.LblFolder.Name = "LblFolder";
            this.LblFolder.Size = new System.Drawing.Size(660, 25);
            this.LblFolder.TabIndex = 8;
            this.LblFolder.Text = "YOUTUBE DOWNLOADER";
            this.LblFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBDownload
            // 
            this.PBDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PBDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(49)))), ((int)(((byte)(156)))));
            this.PBDownload.Location = new System.Drawing.Point(12, 350);
            this.PBDownload.Name = "PBDownload";
            this.PBDownload.Size = new System.Drawing.Size(660, 40);
            this.PBDownload.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.PBDownload.TabIndex = 13;
            // 
            // LblChange
            // 
            this.LblChange.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblChange.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChange.ForeColor = System.Drawing.Color.LightGray;
            this.LblChange.Location = new System.Drawing.Point(318, 404);
            this.LblChange.Name = "LblChange";
            this.LblChange.Size = new System.Drawing.Size(64, 18);
            this.LblChange.TabIndex = 24;
            this.LblChange.Text = "0%";
            this.LblChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBVideoQ
            // 
            this.CBVideoQ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBVideoQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.CBVideoQ.Enabled = false;
            this.CBVideoQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBVideoQ.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBVideoQ.ForeColor = System.Drawing.SystemColors.Window;
            this.CBVideoQ.FormattingEnabled = true;
            this.CBVideoQ.Location = new System.Drawing.Point(12, 211);
            this.CBVideoQ.Name = "CBVideoQ";
            this.CBVideoQ.Size = new System.Drawing.Size(445, 31);
            this.CBVideoQ.TabIndex = 25;
            this.CBVideoQ.SelectedIndexChanged += new System.EventHandler(this.CBVideoQ_SelectedIndexChanged);
            // 
            // TBName
            // 
            this.TBName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.TBName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBName.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBName.ForeColor = System.Drawing.Color.White;
            this.TBName.Location = new System.Drawing.Point(12, 136);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(445, 40);
            this.TBName.TabIndex = 26;
            this.TBName.Text = "VideoName";
            this.TBName.Click += new System.EventHandler(this.TBName_Click);
            this.TBName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBName_KeyPress);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.CBVideoQ);
            this.Controls.Add(this.LblChange);
            this.Controls.Add(this.PBDownload);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnDownload);
            this.Controls.Add(this.TBRuta);
            this.Controls.Add(this.LblFolder);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form6_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnDownload;
        private System.Windows.Forms.TextBox TBRuta;
        private System.Windows.Forms.Label LblFolder;
        private System.Windows.Forms.ProgressBar PBDownload;
        private System.Windows.Forms.Label LblChange;
        private System.Windows.Forms.ComboBox CBVideoQ;
        private System.Windows.Forms.TextBox TBName;
    }
}