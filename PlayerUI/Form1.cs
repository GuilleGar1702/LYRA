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
   
    
    public partial class Form1 : Form
    {
        
        public string[] RecentURLs = new string[0]; 
        public bool ExternalInput = false;
        public bool play = false;
        int Second, Minute, Hour = 0;
        int position = 0;
        int TempVol = 0;
        public string ExternalURL { get; set; }
        string Ruta;
        public Form1()
        {
            InitializeComponent();
            hideSubMenu();
        }


        public void Disposer()
        {
            this.Hide();
        }


        public void StopTimer()
        {
            timer1.Stop();
        }

        public void StartTimer()
        {
            timer1.Start();
        }

        public void SetVisible()
        {
            Player.Visible = true;
            Player.BringToFront();
        }


        public void SetExternalURL(string URL)
        {
            ExternalURL = URL;
            MessageBox.Show(ExternalURL);
            ExternalPlay();
        }


        public void Reset()
        {
            Pausar();
            PBMedia.Value = 0;
            LblDuration.Text = "00:00:00";
            LblPosition.Text = "00:00:00";
        }



        public void ExternalPlay()
        {
            //MessageBox.Show(ExternalURL);
            Reset();
            Player.URL = ExternalURL;
            //Player.Ctlcontrols.play();
            //play = true;
            //timer1.Start();
        }
        

        public void Pausar()
        {
            Player.Ctlcontrols.pause();
            play = false;
            timer1.Stop();
        }
        public void Play()
        {
            Player.Ctlcontrols.play();
            play = true;
            timer1.Start();
        }


        private void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }



        public void CleanRecentMedia()
        {
            string[] ClearURLs = new string[0];
            RecentURLs = ClearURLs;
            openChildForm(new Form3(this));
        }


        public void SetRecentMedia(string RecentURL)
        {
            string[] tempURLs = new string[RecentURLs.Length+1];
            Array.Copy(RecentURLs, tempURLs, RecentURLs.Length);
            tempURLs[tempURLs.Length - 1] = RecentURL;
            RecentURLs = tempURLs;



            /*
            RecentMediaForm = new Form3(this);
            this.RecentMediaForm = RecentMediaForm;
            RecentMediaForm.AddMedia(Path.GetFileName(Player.URL), Player.URL);
            //MessageBox.Show(Player.URL);
            */
        }




        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
            if (play == true)
            {
                Pausar();
                position = 0;
                PBMedia.Value = 0;
                LblDuration.Text = "00:00:00";
                LblPosition.Text = "00:00:00";
            }

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos multimedia|*.asf;*.wma;*.wmv;*.wm;*.asx;*.wax;*.wvx;*.wmx;*.wpl;*.dvr-ms;*.wmd;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mid;*.midi;*.rmi;*.aif;*.aifc;*.aiff;*.au;*.snd;*.wav;*.cda;*.ivf;*.wmz;*.wms;*.mov;*.m4a;*.mp4;*.m4v;*.mp4v;*.3g2;*.3gp2;*.3gp;*.3gpp;*.aac;*.adt;*.adts;*.m2ts;*.mkv";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    // Reproducir el archivo seleccionado con Windows Media Player
                    Ruta = openFileDialog.FileName;
                    Player.URL = Ruta;
                    Player.Visible = true;
                    Play();
                    SetRecentMedia(Ruta);
                }
            }
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (play == true)
            {
                Pausar();
                position = 0;
                PBMedia.Value = 0;
                LblDuration.Text = "00:00:00";
                LblPosition.Text = "00:00:00";
            }


            openChildForm(new Form2(this));
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (play == true)
            {
                Pausar();
                position = 0;
                PBMedia.Value = 0;
                LblDuration.Text = "00:00:00";
                LblPosition.Text = "00:00:00";
            }

            openChildForm(new Form3(this));
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }

        #region PlayListManagemetSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }
        #region ToolsSubMenu
        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        

        private void Form1_Load(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }


        //Boton de play
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            PBMedia.Enabled = true;
            
            if (ExternalInput == true)
            {
                ExternalPlay();
                ExternalInput = false;
            }
            if (Player.URL == "")
            {
                MessageBox.Show("No hay archivo a reproducir");
            }
            else
            {
                Player.Visible = true;
                PBMedia.Maximum = (int)Player.currentMedia.duration;
                //LblDuration.Text = Convert.ToString(Player.currentMedia.duration);
                if (play == false)
                {
                    Play();
                }
                else if (play == true)
                {
                    Pausar();
                }
            }

            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            LblVolumen.Text = (trackBar1.Value).ToString() + "%";
            Player.settings.volume = trackBar1.Value;
        }

        private void BtnFullScreen_Click(object sender, EventArgs e)
        {
            if (Player.fullScreen == false)
            {
                Player.fullScreen = true;
            }
            else
            {
                Player.fullScreen = false;
            }
        }

        private void PBMedia_Scroll(object sender, EventArgs e)
        {
            //Player.Ctlcontrols.currentPosition = PBMedia.Value;
            //position = (int)Player.Ctlcontrols.currentPosition;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value != 0)
            {
                TempVol = trackBar1.Value;
                trackBar1.Value = 0;
                Player.settings.mute = true;
                LblVolumen.Text = trackBar1.Value.ToString() + "%";
            }
            else
            {
                trackBar1.Value = TempVol;
                LblVolumen.Text = trackBar1.Value.ToString() + "%";
                Player.settings.mute = false;
            }
        }

        private void PBMedia_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void PBMedia_MouseUp(object sender, MouseEventArgs e)
        {
            Player.Ctlcontrols.currentPosition = PBMedia.Value;
            position = (int)Player.Ctlcontrols.currentPosition;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //setting PBMedia parameters
            PBMedia.Maximum = (int)Player.currentMedia.duration;
            PBMedia.Value = (int)Player.Ctlcontrols.currentPosition;

            //setting time stuff
            int HourDuration = PBMedia.Maximum / 3600;
            int MinuteDuration = PBMedia.Maximum / 60;
            int SecondDuration = PBMedia.Maximum % 60;

            //setting the surrent position of the video in PBMedia and LblPosition
            if (MinuteDuration > 60)
            {
                LblDuration.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", HourDuration, (MinuteDuration-(HourDuration*60)), SecondDuration);
            }
            else
            {
                LblDuration.Text = string.Format("{0:D2}:{1:D2}", MinuteDuration, SecondDuration);
            }
            position++;
            Second = position;
            if (Second > 59)
            {
                Hour = Second / 3600;
                Minute = Second / 60;
                Second = Second % 60;
            }
            if (MinuteDuration > 60)
            {
                LblPosition.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", Hour, (Minute-(Hour*60)), Second);
            }
            else
            {
                LblPosition.Text = string.Format("{0:D2}:{1:D2}", Minute, Second);
            }

            /*if (PBMedia.Value == PBMedia.Maximum)
            {
                Pausar();

            }*/

            if (position > (int)Player.currentMedia.duration || PBMedia.Value == PBMedia.Maximum)
            {
                timer1.Stop();
                LblPosition.Text = "00:00:00";
                position = 0;
                PBMedia.Value = 0;
                play = false;
                PBMedia.Enabled = false;
            }
        }
    }
}



/*
///////////////////////////////////

0dddddKMMMMMMMMMMNkddddkXMMMMMMMMMMW0ddd0WMMMMMMMMMMXxddddddxkO0NWMMMMMMMMMMNOdddddddddddddxXMMMMMMMMMMMMKdddddddddxOKWMMMMMW0dddkXMMMMMMMMMMXkdddOWMMMMMMMMMMMMMWKkoc;;;:coxKWMMMMMMMMMMWKxo:;;;:cokXMM
c     :XMMMMMMMMWd.    .OMMMMMMMMMMO'   ,0MMMMMMMMMMk.        ..';lkXMMMMMMMK;             .kMMMMMMMMMMMWo          ..;o0WMMWO,  .:KMMMMMMMMXc.  'OWMMMMMMMMMMW0o;..         lNMMMMMMMNOl,.         .dMM
:      lNMMMMMMMO.     .OMMMMMMMMMK,     :XMMMMMMMMMx.   ,:::;,.    'oKMMMMMK,   .:::::::::lKMMMMMMMMMMMWl   .;::::;.   .dNMMMK;   ,0MMMMMM0;   ;0MMMMMMMMMMW0:.   .,clooolc;dNMMMMMNk;    .;cloolc:;kWM
:      .xWMMMMMK;      .OMMMMMMMMNc   .   lNMMMMMMMMx.  .OMMMMWXOl.   'OWMMMK,   oMMMMMMMMMMMMMMMMMMMMMMWl   ;XMMMMWXl   .kMMMMXl.  .kWMMWk'   cXMMMMMMMMMMNx.   ,xKWMMMMMMMWWMMMMMXl.  .:kXWMMMMMMMWWMM
:   ,'  ,0MMMMNl  .;.  .OMMMMMMMWo.  ;x,  .xWMMMMMMMx.  .OMMMMMMMMK:   '0MMMK,   oMMMMMMMMMMMMMMMMMMMMMMWl   ;XMMMMMWd.  .kMMMMMNd.  .dNNd.  .dNMMMMMMMMMMWx.  .oNMMMMMMMMMMMMMMMMNl   .xWMMMMMMMMMMMMMM
:   cx.  cNMMWx.  cx.  .OMMMMMMWx.  .kWx.  .OMMMMMMMx.  .OMMMMMMMMM0'   lWMMK,   ,dddddddd0WMMMMMMMMMMMMWl   .lddddo:.  .dNMMMMMMWO'   ::.  'kWMMMMMMMMMMMK;   cNMMMMMWMWMWWWWMMMMO.   dWMMMMMWWWWMMWMMM
:   cXl  .dWM0,  '0k.  .OMMMMMM0'   oWMNl   ,KMMMMMMx.  .OMMMMMMMMMN:   :NMMK,            :NMMMMMMMMMMMMWl             .cKWMMMMMMMMK;      ;0MMMMMMMMMMMMMO.   dMMMMXl,;,,,;,;kWMMd   .OMMMM0c,;,;;;,:OM
:   cNK;  .ONc  .xMk.  .OMMMMMX;   .okkko.   cXMMMMMx.  .OMMMMMMMMMK,   cWMMK,   ,ooooooooOWMMMMMMMMMMMMWl   .coooolc,   .dNMMMMMMMMXc    cXMMMMMMMMMMMMMMO.   dMMMMK;....    lWMMd   .kMMMMO'...    .dM
:   cNMO.  :o.  lNMk.  .OMMMMNl               oWMMMMx.  .OMMMMMMMMWd.  .kMMMK,   oMMMMMMMMMMMMMMMMMMMMMMWl   ;XMMMMMMNo   .kMMMMMMMMMO.  .kMMMMMMMMMMMMMMMX;   ;XMMMWK000k,   lWMMO.   lNMMMNK000d.  .dM
:   cNMWd.  .  ;KMMk.  .OMMMWd.  .:ccccccc;.  .xWMMMx.  .OMMMMMMW0c.  .oNMMMK,   oMMMMMMMMMMMMMMMMMMMMMMWl   ;XMMMMMMNo   .kMMMMMMMMMO.  .kMMMMMMMMMMMMMMMWk.   ;0WMMMMMMX;   lWMMWo.  .cKWMMMMMM0'  .dM
:   cNMMX:    .OMMMk.  .OMMMk.  .oWMMMMMMMNl   '0MMMx.  .lkxxdoc,.   ,kNMMMMK,   ;xxxxxxxkxx0WMMMMMMMMMMWl   .dkxxxdl,   .oNMMMMMMMMMO.  .kMMMMMMMMMMMMMMMMWk'   .;okO000x'   lWMMMNd.   .:dk0000o.  .dM
:   cNMMM0'  .dWMMMk.  .OMM0,   cXMMMMMMMMMX:   ;KMMx.           .'ckNMMMMMMK,              ;XMMMMMMMMMMWl             .cOWMMMMMMMMMMO.  .kMMMMMMMMMMMMMMMMMMXd;.     ..      lWMMMMWKo,.     ..     .xM
klclOWMMMM0lcxNMMMMKocldXMM0llcoKMMMMMMMMMMMKolloKMMKocllllllodxOKNMMMMMMMMMNxclcllllclllllcxNMMMMMMMMMMMOllcclclllodxOXMMMMMMMMMMMMMXdlloKMMMMMMMMMMMMMMMMMMMMWKkoc:;;,;;:coxKMMMMMMMMN0xoc:;,,;::lokXM


///////////////////////////////////
*/

