using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;
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
    public partial class AudioConverter : Form
    {
        private Interfaz Principal;
        public AudioConverter(Interfaz Principal)
        {
            InitializeComponent();
            this.Principal = Principal;
        }
        string rutaDestino;
        string input;

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

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AudioConverter_MouseMove(object sender, MouseEventArgs e)
        {
            Principal.SidePanelHider2();
        }

        private void TBInput_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de Audio| *.wma; *.wmx; *.wpl; *.mp2; *.mp3; *.mpa; *.mpe; *.m3u; *.mid; *.midi; *.rmi; *.aif; *.aifc; *.aiff; *.au; *.snd; *.wav; *.cda; *.wmz; *.wms; *.aac; *.aac; *.adt; *.adts";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TBInput.Text = openFileDialog.FileName;
                    input = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been a problem with the convertion, \n please check your inputs and try again \n Error:" + ex);
            }
        }
    }
}
