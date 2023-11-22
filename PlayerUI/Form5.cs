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
    public partial class Form5 : Form
    {
        private Form1 Principal;
        int ElementSelected;
        string[] Playlists = new string[0];
        string[] PlaylistSelected = new string[0];
        public Form5(Form1 Principal)
        {
            InitializeComponent();
            this.Principal = Principal;
            DGVPlaylist.SelectionChanged += new EventHandler(DGVPlaylist_SelectionChanged);
        }


        private void OpenList()
        {
            DGVPlaylist.Rows.Clear();
            string[] Temp = File.ReadAllLines(Playlists[ElementSelected]);
            PlaylistSelected = Temp;
            foreach (var File in PlaylistSelected)
            {
                int n = DGVPlaylist.Rows.Add();
                DGVPlaylist.Rows[n].Cells[0].Value = System.IO.Path.GetFileName(File);

            }
            BtnBack.Enabled = true;
            BtnOpen.Enabled = false;
            BtnDelete.Enabled = false;
            BtnPlay.Enabled = true;
        }

        private void RefreshDGV()
        {
            DGVPlaylist.Rows.Clear();
            if (!Directory.Exists(Form4.PlaylistsFolder))
            {
                Directory.CreateDirectory(Form4.PlaylistsFolder);
            }

            string[] Temp = Directory.GetFiles(Form4.PlaylistsFolder);
            Playlists = Temp;
            foreach (var File in Playlists)
            {
                if (File.EndsWith(".txt"))
                {
                    int n = DGVPlaylist.Rows.Add();
                    DGVPlaylist.Rows[n].Cells[0].Value = System.IO.Path.GetFileNameWithoutExtension(File);
                }
            }
        }



        private void SendMedia()
        {

            Principal.PlayList = PlaylistSelected;
            Principal.ExternalPlaylist = true;
            Principal.PlaylistPlay();
            this.Close();
        }



        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void DGVPlaylist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (Playlists.Length>0)
            {
                OpenList();
            }
            else
            {
                MessageBox.Show("There is no PlayLists to show");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {

            RefreshDGV();
            //BtnOpen.Enabled = false;
            BtnOpen.Enabled = true;
            //BtnDelete.Enabled = false;
            BtnDelete.Enabled = true;
            BtnBack.Enabled = false;
        }

        private void DGVPlaylist_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVPlaylist.SelectedCells.Count > 0)
            {
                if (BtnBack.Enabled == false)
                {
                    BtnOpen.Enabled = true;
                    BtnDelete.Enabled = true;
                }
                else
                {
                    BtnOpen.Enabled = false;
                    BtnDelete.Enabled = false;
                }
                
                int ElementeSelected = DGVPlaylist.SelectedCells[0].RowIndex;
            }
            
        }

        private void DGVPlaylist_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (BtnOpen.Enabled == true)
                {
                    OpenList();
                }
            }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            SendMedia();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DGVPlaylist.SelectedCells.Count > 0)
            {

                int x = DGVPlaylist.SelectedCells[0].RowIndex;
                if (x != -1)
                {
                    File.Delete(Playlists[x]);
                    DGVPlaylist.Rows.Clear();
                    RefreshDGV();
                    BtnOpen.Enabled = false;
                    BtnDelete.Enabled = false;
                    BtnBack.Enabled = false;
                }
            }
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<Playlists.Length; i++)
            {
                File.Delete(Playlists[i]);
            }
            RefreshDGV();
        }
    }
}