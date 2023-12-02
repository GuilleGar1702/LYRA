namespace PlayerUI
{
    partial class AudioConverter
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
            this.label2 = new System.Windows.Forms.Label();
            this.TBOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBInput = new System.Windows.Forms.TextBox();
            this.CBFormat = new System.Windows.Forms.ComboBox();
            this.BtnConvert = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.LblFolder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(55)))), ((int)(((byte)(179)))));
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(660, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Output (Folder)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TBOutput
            // 
            this.TBOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.TBOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBOutput.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBOutput.ForeColor = System.Drawing.Color.White;
            this.TBOutput.Location = new System.Drawing.Point(12, 170);
            this.TBOutput.Name = "TBOutput";
            this.TBOutput.Size = new System.Drawing.Size(660, 40);
            this.TBOutput.TabIndex = 42;
            this.TBOutput.Click += new System.EventHandler(this.TBOutput_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(55)))), ((int)(((byte)(179)))));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Input (File)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TBInput
            // 
            this.TBInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.TBInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBInput.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBInput.ForeColor = System.Drawing.Color.White;
            this.TBInput.Location = new System.Drawing.Point(12, 88);
            this.TBInput.Name = "TBInput";
            this.TBInput.Size = new System.Drawing.Size(660, 40);
            this.TBInput.TabIndex = 40;
            this.TBInput.Click += new System.EventHandler(this.TBInput_Click);
            // 
            // CBFormat
            // 
            this.CBFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.CBFormat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBFormat.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBFormat.ForeColor = System.Drawing.SystemColors.Window;
            this.CBFormat.FormattingEnabled = true;
            this.CBFormat.Items.AddRange(new object[] {
            ".mp3",
            ".wav",
            ".flac",
            ".wma",
            ".wmx",
            ".wpl",
            ".mp2",
            ".mpa",
            ".mpe",
            ".m3u",
            ".mid",
            ".midi",
            ".rmi",
            ".aif",
            ".aifc",
            "aiff",
            ".au",
            ".snd",
            ".wav",
            ".cda",
            ".wmz",
            ".aac",
            ".adt",
            ".adts"});
            this.CBFormat.Location = new System.Drawing.Point(12, 228);
            this.CBFormat.Name = "CBFormat";
            this.CBFormat.Size = new System.Drawing.Size(191, 31);
            this.CBFormat.TabIndex = 39;
            this.CBFormat.Text = "Select";
            this.CBFormat.SelectedIndexChanged += new System.EventHandler(this.CBFormat_SelectedIndexChanged);
            // 
            // BtnConvert
            // 
            this.BtnConvert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.BtnConvert.Enabled = false;
            this.BtnConvert.FlatAppearance.BorderSize = 0;
            this.BtnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConvert.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConvert.ForeColor = System.Drawing.Color.LightGray;
            this.BtnConvert.Location = new System.Drawing.Point(274, 336);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(150, 40);
            this.BtnConvert.TabIndex = 38;
            this.BtnConvert.Text = "CONVERT";
            this.BtnConvert.UseVisualStyleBackColor = false;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
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
            this.button5.TabIndex = 37;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // LblFolder
            // 
            this.LblFolder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblFolder.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(55)))), ((int)(((byte)(179)))));
            this.LblFolder.Location = new System.Drawing.Point(12, 14);
            this.LblFolder.Name = "LblFolder";
            this.LblFolder.Size = new System.Drawing.Size(660, 25);
            this.LblFolder.TabIndex = 36;
            this.LblFolder.Text = "AUDIO CONVERTER";
            this.LblFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AudioConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBInput);
            this.Controls.Add(this.CBFormat);
            this.Controls.Add(this.BtnConvert);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.LblFolder);
            this.Name = "AudioConverter";
            this.Text = "AudioConverter";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AudioConverter_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBInput;
        private System.Windows.Forms.ComboBox CBFormat;
        private System.Windows.Forms.Button BtnConvert;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label LblFolder;
    }
}