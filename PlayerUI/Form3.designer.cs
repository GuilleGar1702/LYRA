namespace PlayerUI
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnClearAll = new System.Windows.Forms.Button();
            this.BtnPlayAll = new System.Windows.Forms.Button();
            this.DGVRecentMedia = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRecentMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(55)))), ((int)(((byte)(179)))));
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "RECENT MEDIA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.button5.Size = new System.Drawing.Size(27, 33);
            this.button5.TabIndex = 14;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.BtnPlay.Enabled = false;
            this.BtnPlay.FlatAppearance.BorderSize = 0;
            this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlay.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlay.ForeColor = System.Drawing.Color.LightGray;
            this.BtnPlay.Location = new System.Drawing.Point(12, 55);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(150, 40);
            this.BtnPlay.TabIndex = 18;
            this.BtnPlay.Text = "PLAY";
            this.BtnPlay.UseVisualStyleBackColor = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnClean
            // 
            this.BtnClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.BtnClean.FlatAppearance.BorderSize = 0;
            this.BtnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClean.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClean.ForeColor = System.Drawing.Color.LightGray;
            this.BtnClean.Location = new System.Drawing.Point(12, 101);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(150, 40);
            this.BtnClean.TabIndex = 17;
            this.BtnClean.Text = "CLEAN";
            this.BtnClean.UseVisualStyleBackColor = false;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // BtnClearAll
            // 
            this.BtnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.BtnClearAll.FlatAppearance.BorderSize = 0;
            this.BtnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearAll.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClearAll.ForeColor = System.Drawing.Color.LightGray;
            this.BtnClearAll.Location = new System.Drawing.Point(522, 379);
            this.BtnClearAll.Name = "BtnClearAll";
            this.BtnClearAll.Size = new System.Drawing.Size(150, 40);
            this.BtnClearAll.TabIndex = 16;
            this.BtnClearAll.Text = "CLEAR ALL";
            this.BtnClearAll.UseVisualStyleBackColor = false;
            this.BtnClearAll.Visible = false;
            // 
            // BtnPlayAll
            // 
            this.BtnPlayAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPlayAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(55)))), ((int)(((byte)(179)))));
            this.BtnPlayAll.FlatAppearance.BorderSize = 0;
            this.BtnPlayAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayAll.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlayAll.ForeColor = System.Drawing.Color.LightGray;
            this.BtnPlayAll.Location = new System.Drawing.Point(366, 379);
            this.BtnPlayAll.Name = "BtnPlayAll";
            this.BtnPlayAll.Size = new System.Drawing.Size(150, 40);
            this.BtnPlayAll.TabIndex = 15;
            this.BtnPlayAll.Text = "PLAY ALL";
            this.BtnPlayAll.UseVisualStyleBackColor = false;
            this.BtnPlayAll.Visible = false;
            // 
            // DGVRecentMedia
            // 
            this.DGVRecentMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVRecentMedia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVRecentMedia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.DGVRecentMedia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVRecentMedia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVRecentMedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRecentMedia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.DGVRecentMedia.EnableHeadersVisualStyles = false;
            this.DGVRecentMedia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DGVRecentMedia.Location = new System.Drawing.Point(168, 55);
            this.DGVRecentMedia.Name = "DGVRecentMedia";
            this.DGVRecentMedia.ReadOnly = true;
            this.DGVRecentMedia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVRecentMedia.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DGVRecentMedia.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVRecentMedia.Size = new System.Drawing.Size(504, 320);
            this.DGVRecentMedia.TabIndex = 19;
            this.DGVRecentMedia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRecentMedia_CellClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Name";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.DGVRecentMedia);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.BtnClearAll);
            this.Controls.Add(this.BtnPlayAll);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRecentMedia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnClearAll;
        private System.Windows.Forms.Button BtnPlayAll;
        private System.Windows.Forms.DataGridView DGVRecentMedia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}