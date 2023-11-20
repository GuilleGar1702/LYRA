using System;
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
    public partial class Form4 : Form
    {
        private Form1 Principal;
        public Form4(Form1 Principal)
        {
            InitializeComponent();
            this.Principal = Principal;
        }
        string[] NewPlaylist = new string [0];
        public static string PlaylistsFolder = Path.Combine(Application.StartupPath, "LYRA-PlayLists");




        private void CleanNewPlaylist()
        {
            string[] ClearPlayList = new string[0];
            NewPlaylist = ClearPlayList;
            DGVNewPlaylist.Rows.Clear();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos multimedia|*.asf;*.wma;*.wmv;*.wm;*.asx;*.wax;*.wvx;*.wmx;*.wpl;*.dvr-ms;*.wmd;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mid;*.midi;*.rmi;*.aif;*.aifc;*.aiff;*.au;*.snd;*.wav;*.cda;*.ivf;*.wmz;*.wms;*.mov;*.m4a;*.mp4;*.m4v;*.mp4v;*.3g2;*.3gp2;*.3gp;*.3gpp;*.aac;*.adt;*.adts;*.m2ts;*.mkv";
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] archivosSeleccionados = openFileDialog.FileNames;
                    foreach (var File in archivosSeleccionados)
                    {
                        if (!NewPlaylist.Contains(File))
                        {
                            string[] tempURLs = new string[NewPlaylist.Length + 1];
                            Array.Copy(NewPlaylist, tempURLs, NewPlaylist.Length);
                            tempURLs[tempURLs.Length - 1] = File;
                            NewPlaylist = tempURLs;
                        }
                    }
                    DGVNewPlaylist.Rows.Clear();
                    foreach (var File in NewPlaylist)
                    {
                        int n = DGVNewPlaylist.Rows.Add();
                        DGVNewPlaylist.Rows[n].Cells[0].Value = System.IO.Path.GetFileName(File);
                    }
                }
            }
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            CleanNewPlaylist();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string PlayList = Path.Combine(PlaylistsFolder, TBName.Text+".txt");
            if (TBName.Text.Equals(" ") || TBName.Text.Equals(""))
            {
                PlayList = Path.Combine(PlaylistsFolder, "PlayList.txt");
            }
            

            if (!Directory.Exists(PlaylistsFolder))
            {
                Directory.CreateDirectory(PlaylistsFolder);
            }

            foreach (var Element in NewPlaylist)
            {
                string OldPlayList = File.Exists(PlayList) ? File.ReadAllText(PlayList) : "";
                File.WriteAllText(PlayList, OldPlayList + Element + "\n");
                
            }
            MessageBox.Show(PlayList);
            CleanNewPlaylist();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TBName_KeyPress(object sender, KeyPressEventArgs e)
        {
            string InvalidTyping = @"<>:""/\|?*";

            if (InvalidTyping.Contains(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            if (TBName.Text.Equals(" ") || TBName.Text.Equals(""))
            {
                BtnSave.Enabled = false;
            }
            else
            {
                BtnSave.Enabled = true;
            }
        }

        private void TBName_Click(object sender, EventArgs e)
        {
            if (TBName.Text.Equals("PlaylistName") || TBName.Text.Equals(" ") || TBName.Text.Equals(""))
            {
                TBName.Text = "";
            }

        }
    }
}
