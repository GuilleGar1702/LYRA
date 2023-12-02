namespace PlayerUI
{
    partial class AudioExtractor
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
            this.BtnExtract = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.LblFolder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(55)))), ((int)(((byte)(179)))));
            this.label2.Location = new System.Drawing.Point(12, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(660, 25);
            this.label2.TabIndex = 50;
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
            this.TBOutput.Location = new System.Drawing.Point(12, 192);
            this.TBOutput.Name = "TBOutput";
            this.TBOutput.Size = new System.Drawing.Size(660, 40);
            this.TBOutput.TabIndex = 49;
            this.TBOutput.Click += new System.EventHandler(this.TBOutput_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(55)))), ((int)(((byte)(179)))));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 25);
            this.label1.TabIndex = 48;
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
            this.TBInput.Location = new System.Drawing.Point(12, 110);
            this.TBInput.Name = "TBInput";
            this.TBInput.Size = new System.Drawing.Size(660, 40);
            this.TBInput.TabIndex = 47;
            this.TBInput.Click += new System.EventHandler(this.TBInput_Click);
            // 
            // BtnExtract
            // 
            this.BtnExtract.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnExtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.BtnExtract.Enabled = false;
            this.BtnExtract.FlatAppearance.BorderSize = 0;
            this.BtnExtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExtract.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExtract.ForeColor = System.Drawing.Color.LightGray;
            this.BtnExtract.Location = new System.Drawing.Point(274, 308);
            this.BtnExtract.Name = "BtnExtract";
            this.BtnExtract.Size = new System.Drawing.Size(150, 40);
            this.BtnExtract.TabIndex = 46;
            this.BtnExtract.Text = "EXTRACT";
            this.BtnExtract.UseVisualStyleBackColor = false;
            this.BtnExtract.Click += new System.EventHandler(this.BtnExtract_Click);
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
            this.button5.TabIndex = 45;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // LblFolder
            // 
            this.LblFolder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblFolder.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(55)))), ((int)(((byte)(179)))));
            this.LblFolder.Location = new System.Drawing.Point(12, 14);
            this.LblFolder.Name = "LblFolder";
            this.LblFolder.Size = new System.Drawing.Size(660, 25);
            this.LblFolder.TabIndex = 44;
            this.LblFolder.Text = "AUDIO EXTRACTOR";
            this.LblFolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AudioExtractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBInput);
            this.Controls.Add(this.BtnExtract);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.LblFolder);
            this.Name = "AudioExtractor";
            this.Text = "AudioExtractor";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AudioExtractor_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBInput;
        private System.Windows.Forms.Button BtnExtract;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label LblFolder;
    }
}