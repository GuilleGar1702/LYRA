﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class Folder : Form
    {
        private Interfaz Principal;
        string ElementSelected;
        public static string[] SupportedFormats = { ".asf", "mkv", ".wma", ".wmv", ".wm", ".wmx", ".wpl", ".avi", ".mpg", ".mpeg", ".m1v", ".mp2", ".mp3", ".mpa", ".mpe", ".m3u", ".mid", ".midi", ".rmi", ".aif", ".aifc", ".aiff", ".au", ".snd", ".wav", ".cda", ".ivf", ".wmz", ".wms", ".mov", ".m4a", ".mp4", ".m4v", ".mp4v", ".3g2", ".3gp2", ".3gp", ".3gpp", ".aac", ".adt", ".adts", ".m2ts", ".flac" };
        public Folder(Interfaz Principal)
        {
            InitializeComponent();
            this.Principal = Principal;
            DGVFolder.SelectionChanged += new EventHandler(DGVFolder_SelectionChanged);
        }


        private void SendMedia()
        {
            Principal.SetRecentMedia(TBRuta.Text + "\\" + ElementSelected);
            Principal.ExternalURL = TBRuta.Text + "\\" + ElementSelected;
            Principal.ExternalInput = true;
            this.Close();
        }



        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void Files()
        {
            string[] FilesArray = Directory.GetFiles(TBRuta.Text);
            foreach (var File in FilesArray)
            {
                if (SupportedFormats.Any(x => File.EndsWith(x, StringComparison.OrdinalIgnoreCase)))
                {
                    int n = DGVFolder.Rows.Add();
                    DGVFolder.Rows[n].Cells[0].Value = System.IO.Path.GetFileName(File);
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DGVFolder.Rows.Clear();
            fileSystemWatcher1.Path = TBRuta.Text;
            Files();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnPlay.Enabled = true;
            int n = e.RowIndex;
            if (n != -1)
            {
                ElementSelected = (string)DGVFolder.Rows[n].Cells[0].Value;
            }
            
        }
        

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            SendMedia();
        }

        private void TBRuta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DGVFolder.Rows.Clear();
                fileSystemWatcher1.Path = TBRuta.Text;
                Files();
            }
        }

        private void DGVFolder_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVFolder.SelectedCells.Count > 0)
            {
                BtnPlay.Enabled = true;
                int n = DGVFolder.SelectedCells[0].RowIndex;
                if (n != -1)
                {
                    ElementSelected = (string)DGVFolder.Rows[n].Cells[0].Value;
                }
            }
        }

        private void DGVFolder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMedia();
            }
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            Principal.SidePanelHider2();
        }
    }
}
