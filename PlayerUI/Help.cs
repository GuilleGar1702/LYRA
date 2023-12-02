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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            label2.Text ="Clicking on the button Media you will see the options: open file (you can select a file on your PC), open folder (you can write an URL and see the files inside), open recent media (you can see the latest files played. Clicking on the button Playlist Management you will see the options: New Playlist (you can make a playlist), Manage Playlist (you can see and play your playlists). Clicking on the button Tools you will see the options: Download a video (you can download a video from youtube using the video ID, is the part of the link that follows V=), Convert (you can convert audio/video to other formats)";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
