namespace PlayerUI
{
    partial class Form4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVNewPlaylist = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnClean = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TBName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNewPlaylist)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVNewPlaylist
            // 
            this.DGVNewPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVNewPlaylist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVNewPlaylist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.DGVNewPlaylist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVNewPlaylist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.DGVNewPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNewPlaylist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.DGVNewPlaylist.EnableHeadersVisualStyles = false;
            this.DGVNewPlaylist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DGVNewPlaylist.Location = new System.Drawing.Point(168, 55);
            this.DGVNewPlaylist.Name = "DGVNewPlaylist";
            this.DGVNewPlaylist.ReadOnly = true;
            this.DGVNewPlaylist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVNewPlaylist.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White;
            this.DGVNewPlaylist.RowsDefaultCellStyle = dataGridViewCellStyle27;
            this.DGVNewPlaylist.Size = new System.Drawing.Size(504, 320);
            this.DGVNewPlaylist.TabIndex = 24;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Name";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.LightGray;
            this.BtnAdd.Location = new System.Drawing.Point(12, 55);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(150, 40);
            this.BtnAdd.TabIndex = 23;
            this.BtnAdd.Text = "ADD";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
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
            this.BtnClean.TabIndex = 22;
            this.BtnClean.Text = "CLEAN";
            this.BtnClean.UseVisualStyleBackColor = false;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
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
            this.button5.TabIndex = 21;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(55)))), ((int)(((byte)(179)))));
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "NEW PLAYLIST";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(55)))), ((int)(((byte)(179)))));
            this.BtnSave.Enabled = false;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.LightGray;
            this.BtnSave.Location = new System.Drawing.Point(522, 381);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(150, 40);
            this.BtnSave.TabIndex = 25;
            this.BtnSave.Text = "SAVE";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TBName
            // 
            this.TBName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TBName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.TBName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBName.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBName.ForeColor = System.Drawing.Color.White;
            this.TBName.Location = new System.Drawing.Point(214, 387);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(302, 32);
            this.TBName.TabIndex = 26;
            this.TBName.Text = "PlaylistName";
            this.TBName.Click += new System.EventHandler(this.TBName_Click);
            this.TBName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBName_KeyPress);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.DGVNewPlaylist);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.DGVNewPlaylist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVNewPlaylist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TBName;
    }
}