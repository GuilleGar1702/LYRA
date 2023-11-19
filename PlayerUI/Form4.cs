using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string[] NewPlaylist = new string [0];
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
                        int n = DGVNewPlaylist.Rows.Add();
                        DGVNewPlaylist.Rows[n].Cells[0].Value = File;
                    }
                }
            }
        }
    }
}
