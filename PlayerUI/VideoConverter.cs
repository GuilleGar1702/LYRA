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
using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;

namespace PlayerUI
{
    public partial class VideoConverter : Form
    {


        string rutaDestino;
        string input;


        private Interfaz Principal;
        public VideoConverter(Interfaz Principal)
        {
            InitializeComponent();
            this.Principal = Principal;
        }

        private void ConvertEnabler()
        {
            if (TBInput.Text.Equals("") || TBOutput.Text.Equals("") || CBFormat.Text.Equals("Select"))
            {
                BtnConvert.Enabled = false;
            } 
            else
            {
                BtnConvert.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VideoConverter_MouseMove(object sender, MouseEventArgs e)
        {
            Principal.SidePanelHider2();
        }

        private void TBInput_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de Video|*.asf;*.wmv;*.wm;*.wmx;*.avi;*.mpg;*.mpeg;*.m1v;*.ivf;*.mov;*.m4a;*.mp4;*.m4v;*.mp4v;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m2ts;*.mkv";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TBInput.Text= openFileDialog.FileName;
                    input =Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                }
                ConvertEnabler();
            }
        }

        private void TBOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                TBOutput.Text = folderBrowserDialog.SelectedPath.ToString();
                rutaDestino = Path.Combine(folderBrowserDialog.SelectedPath);
            }
            ConvertEnabler();
        }

        private void CBFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            rutaDestino = Path.Combine(rutaDestino, input + CBFormat.SelectedItem.ToString());
            ConvertEnabler();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                var inputFile = new MediaFile { Filename = TBInput.Text };
                var outputFile = new MediaFile { Filename = rutaDestino };
                using (var engine = new Engine())
                {
                    engine.GetMetadata(inputFile);
                    var options = new ConversionOptions();
                    engine.Convert(inputFile, outputFile, options);
                    MessageBox.Show("CONVERTION COMPLETE!");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("There has been a problem with the convertion, \n please check your inputs and try again \n Error:" + ex);
            }
            

        }
    }
}
