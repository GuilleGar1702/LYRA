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
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using System.Linq;

namespace PlayerUI
{
    public partial class VideoDL : Form
    {
        
        private Interfaz Principal;
        public VideoDL(Interfaz Principal)
        {
            InitializeComponent();
            this.Principal = Principal;
        }



        private void DownloadEnabler()
        {
            if (TBRuta.Text.Equals(" ") || TBRuta.Text.Equals("") || TBName.Text.Equals(" ") || TBName.Text.Equals("") || CBVideoQ.Text.Equals("") || CBVideoQ.Text.Equals("Select a quality"))
            {
                BtnDownload.Enabled = false;
            }
            else
            {
                BtnDownload.Enabled = true;
            }
        }

        private async Task VideoGetterAsync()
        {
            string VideoURL = TBRuta.Text;
            try
            {
                var youtube = new YoutubeClient();
                var videoId = TBRuta.Text;
                var video = await youtube.Videos.GetAsync(videoId);
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoId);
                foreach (var stream in streamManifest.GetVideoStreams())
                {
                    CBVideoQ.Items.Add(stream.VideoQuality.ToString());
                }
                    CBVideoQ.Text = "Select a quality";
                    CBVideoQ.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been a problem with the download, verify if your URL is valid. Error: " + ex);
            }
        }

        private async Task VideoDownloaderAsync()
        {
            var youtube = new YoutubeClient();
            var videoId = TBRuta.Text;
            var video = await youtube.Videos.GetAsync(videoId);
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoId);
            try
            {
                var Quality = CBVideoQ.SelectedItem.ToString();
                var streamSeleccionado = streamManifest.GetVideoStreams().First(s => s.VideoQuality.ToString() == Quality);
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaCompleta = Path.Combine(folderBrowserDialog.SelectedPath, TBName.Text + ".mp4");
                    if (File.Exists(rutaCompleta))
                    {
                        DialogResult result = MessageBox.Show("Do you want to overwrite the file? \n Press Yes to overwrite it \n Press No to rename it", "File already ", MessageBoxButtons.YesNo);

                        if (result == DialogResult.No)
                        {
                            rutaCompleta = Path.Combine(folderBrowserDialog.SelectedPath, TBName.Text + "1.mp4");
                        }

                    }
                    var DownloadStatement = new Progress<double>(p => { PBDownload.Value = (int)(p * 100); LblChange.Text = PBDownload.Value.ToString()+"%"; });
                    await youtube.Videos.Streams.DownloadAsync(streamSeleccionado, rutaCompleta, DownloadStatement);
                    MessageBox.Show("DOWNLOAD COMPLETE!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been a problem with the download, verify if your URL is valid. Error: " + ex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Form6_MouseMove(object sender, MouseEventArgs e)
        {
            Principal.SidePanelHider2();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            VideoGetterAsync();
        }

        private void CBVideoQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            DownloadEnabler();
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            VideoDownloaderAsync();
        }

        private void TBRuta_Click(object sender, EventArgs e)
        {
            if (TBRuta.Text.Equals("VideoID") || TBRuta.Text.Equals(" ") || TBRuta.Text.Equals(""))
            {
                TBRuta.Text = "";
            }
        }

        private void TBName_Click(object sender, EventArgs e)
        {
            if (TBName.Text.Equals("VideoName") || TBName.Text.Equals(" ") || TBName.Text.Equals(""))
            {
                TBName.Text = "";
            }
        }

        private void TBRuta_KeyPress(object sender, KeyPressEventArgs e)
        {
            string InvalidTyping = @"<>:""/\|?*";

            if (InvalidTyping.Contains(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            DownloadEnabler();
        }

        private void TBName_KeyPress(object sender, KeyPressEventArgs e)
        {
            string InvalidTyping = @"<>:""/\|?*";

            if (InvalidTyping.Contains(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
            DownloadEnabler();
        }
    }
}
