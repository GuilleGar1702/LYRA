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
using System.Windows.Input;
namespace PlayerUI
{


    public partial class Interfaz : Form
    {
        Random random = new Random();
        public string[] RecentURLs = new string[0];
        public bool ExternalInput = false;

        public string[] PlayList = new string[0];
        public string[] MixxedPlaylist = new string[0];
        public bool ExternalPlaylist = false;
        int CurrentElement = 0;

        bool RepeatMode = false;
        bool RepeatSMode = false;
        bool ShuffleMode = false;

        public bool play = false;
        int Second, Minute, Hour = 0;
        int position = 0;
        int TempVol = 0;
        public string ExternalURL { get; set; }
        string Ruta;

        public Interfaz()
        {
            InitializeComponent();
            hideSubMenu();
            this.KeyDown += new KeyEventHandler(Form1_KeyDown_1);
            this.MouseMove += Form1_MouseMove;
        }


        public void SidePanelHider()
        {
            var CursorPosition = this.PointToClient(Cursor.Position);
            if (CursorPosition.X > 233)
            {
                panelSideMenu.Visible = false;
            }
            else
            {
                panelSideMenu.Visible = true;
            }
        }


        public void SidePanelHider2()
        {
            var CursorPosition = this.PointToClient(Cursor.Position);
            if (CursorPosition.X > 20)
            {
                panelSideMenu.Visible = false;
            }
            else
            {
                panelSideMenu.Visible = true;
            }
        }



        private void CleanPlaylist()
        {
            ExternalPlaylist = false;
            string[] temp = new string[0];
            PlayList = temp;
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
            Second = 0;
            Minute = 0;
            Hour = 0;
            position = 0;
            MTBPosition.Value = 0;
            LblDuration.Text = "00:00:00";
            LblPosition.Text = "00:00:00";
        }


        public void ExternalPlay()
        {
            Reset();
            Player.URL = ExternalURL;
        }


        private void Mixxer(string[] mix, int n)
        {
            if (n<mix.Length-1)
            {
                n++;
                int x = random.Next(0, mix.Length);
                string temp = mix[x];
                int y = random.Next(0, mix.Length);
                mix[x] = mix[y];
                mix[y] = temp;
                Mixxer(mix, n);
            }
            else
            {
                MixxedPlaylist = mix;
                
            }
        }

        public void PlaylistPlay()
        {
            CurrentElement = 0;
            Reset();
            Player.URL = PlayList[CurrentElement];
            SetVisible();
            Play();
        }

        private void NextElement(string[] PL)
        {
            CurrentElement++;
            Reset();
            SetTimeStuff();
            Player.URL = PL[CurrentElement];
            Play();
            if (CurrentElement > PlayList.Length - 2)
            {
                if (RepeatMode)
                {
                    CurrentElement = 0;
                    Reset();
                    Player.URL = PL[CurrentElement];
                    Play();
                }
                else
                {
                    ExternalPlaylist = false;
                }
            }
        }

        private void PreviusElement(string[] PL)
        {
            CurrentElement--;
            if (CurrentElement > -1)
            {
                Reset();
                Player.URL = PL[CurrentElement];
                Play();
            }
            else
            {
                MessageBox.Show("There is no previus elements");
            }
            
        }
        public void Pausar()
        {
            Player.Ctlcontrols.pause();
            play = false;
            PBPlay.Image = Properties.Resources.play2;
            timer1.Stop();
        }
        public void Play()
        {
            Player.Ctlcontrols.play();
            play = true;
            PBPlay.Image = Properties.Resources.Pause;
            MTBPosition.Enabled = true;
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
            openChildForm(new RecentMedia(this));
        }


        public void SetRecentMedia(string RecentURL)
        {
            string[] tempURLs = new string[RecentURLs.Length+1];
            Array.Copy(RecentURLs, tempURLs, RecentURLs.Length);
            tempURLs[tempURLs.Length - 1] = RecentURL;
            RecentURLs = tempURLs;

        }



        private void SetTimeStuff()
        {
            MTBPosition.Maximum = (int)Player.currentMedia.duration-1;
            MTBPosition.Value = (int)Player.Ctlcontrols.currentPosition;

            //setting time stuff
            int HourDuration = (MTBPosition.Maximum / 3600);
            int MinuteDuration =( MTBPosition.Maximum / 60);
            int SecondDuration = (MTBPosition.Maximum % 60)+1;

            //setting the current position of the video in MTBPosition and LblPosition
            if (MinuteDuration > 60)
            {
                LblDuration.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", HourDuration, (MinuteDuration - (HourDuration * 60)), SecondDuration);
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
                LblPosition.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", Hour, (Minute - (Hour * 60)), Second-1);
            }
            else
            {
                LblPosition.Text = string.Format("{0:D2}:{1:D2}", Minute, Second-1);
            }
        }


        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
            
            CleanPlaylist();
            if (play == true)
            {
                Pausar();
                Reset();
            }

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos multimedia|*.asf;*.wma;*.wmv;*.wm;*.asx;*.wax;*.wvx;*.wmx;*.wpl;*.dvr-ms;*.wmd;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mid;*.midi;*.rmi;*.aif;*.aifc;*.aiff;*.au;*.snd;*.wav;*.cda;*.ivf;*.wmz;*.wms;*.mov;*.m4a;*.mp4;*.m4v;*.mp4v;*.3g2;*.3gp2;*.3gp;*.3gpp;*.aac;*.adt;*.adts;*.m2ts;*.mkv";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Reset();
                    Ruta = openFileDialog.FileName;
                    Player.URL = Ruta;
                    Player.Visible = true;
                    Play();
                    SetRecentMedia(Ruta);
                    BtnPlay.Select();
                }
            }
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CleanPlaylist();
            if (play == true)
            {
                Pausar();
                Reset();
            }

            openChildForm(new Folder(this));
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CleanPlaylist();
            if (play == true)
            {
                Pausar();
                position = 0;
                MTBPosition.Value = 0;
                LblDuration.Text = "00:00:00";
                LblPosition.Text = "00:00:00";
            }

            openChildForm(new RecentMedia(this));
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
            openChildForm(new NewPL(this));
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new ManagePL(this));
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
            openChildForm(new VideoDL(this));
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openChildForm(new VideoConverter(this));
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openChildForm(new AudioConverter(this));
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            openChildForm(new Help());
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
            panelSideMenu.Visible = false;
        }


        //Boton de play
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MTBPosition.Enabled = true;
            if (ExternalInput == true)
            {
                Reset();
                ExternalPlay();
                ExternalInput = false;
            }
            if (Player.URL == "")
            {
                MessageBox.Show("There is no file to play");
            }
            else
            {
                Player.Visible = true;
                MTBPosition.Maximum = (int)Player.currentMedia.duration;
                if (play == false)
                {
                    Play();
                }
                else if (play == true)
                {
                    Pausar();
                }
            }
            BtnPlay.Select();
        }


        private void BtnFullScreen_Click(object sender, EventArgs e) //Shuffle button
        {
            if (ExternalPlaylist)
            {
                if (!ShuffleMode)
                {
                    Mixxer(PlayList, 0);
                    PBShuffle.Image = Properties.Resources.Shuffle;
                    ShuffleMode = true;

                }
                else
                {
                    PBShuffle.Image = Properties.Resources.ShuffleOff;
                    ShuffleMode = false;
                }

            }
        }


        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (MTBVolume.Value != 0)
            {
                TempVol = MTBVolume.Value;
                MTBVolume.Value = 0;
                Player.settings.mute = true;
                LblVolumen.Text = MTBVolume.Value.ToString() + "%";
                BtnVolumen.Image = Properties.Resources.SpeakerOff;
            }
            else
            {
                MTBVolume.Value = TempVol;
                LblVolumen.Text = MTBVolume.Value.ToString() + "%";
                Player.settings.mute = false;
                BtnVolumen.Image = Properties.Resources.Speaker;
            }
        }


        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            MTBPosition.Enabled = true;

            if (ExternalInput == true)
            {
                Reset();
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
                MTBPosition.Maximum = (int)Player.currentMedia.duration;
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

        private void Player_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            BtnPlay.Select();
        }

        private void PBAdelante_Click(object sender, EventArgs e)
        {
            position += 10;
            Player.Ctlcontrols.currentPosition += 10;
            SetTimeStuff();
        }

        private void PBAtras_Click(object sender, EventArgs e)
        {
            position -= 10;
            Player.Ctlcontrols.currentPosition -= 10;
            SetTimeStuff();
        }

        private void PBStop_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
            Reset();
        }

        private void PBAdelante_DoubleClick(object sender, EventArgs e)
        {
            if (!ExternalPlaylist)
            {
                Player.Ctlcontrols.stop();
                Reset();
            }
            else
            {
                if (ShuffleMode)
                {
                    NextElement(MixxedPlaylist);
                }
                else
                {
                    NextElement(PlayList);
                }
            }
        }

        private void PBAtras_DoubleClick(object sender, EventArgs e)
        {
            if (!ExternalPlaylist)
            {
                string x = Player.URL;
                Player.Ctlcontrols.stop();
                Reset();
                Player.URL = x;
            }
            else
            {
                if (ShuffleMode)
                {
                    PreviusElement(MixxedPlaylist);
                }
                else
                {
                    PreviusElement(PlayList);
                }
            }
        }

        private void MTBPosition_Scroll(object sender, EventArgs e)
        {
            LblVolumen.Text = (MTBVolume.Value).ToString() + "%";
            Player.settings.volume = MTBVolume.Value;
            if (MTBVolume.Value != 0)
            {
                BtnVolumen.Image = Properties.Resources.Speaker;
            }
            else
            {
                BtnVolumen.Image = Properties.Resources.SpeakerOff;
            }

        }

        private void MTBPosition_MouseDown(object sender, MouseEventArgs e)
        {
            Pausar();
        }

        private void PBRepeat_Click(object sender, EventArgs e)
        {
            if (ExternalPlaylist)
            {
                if (RepeatMode)
                {
                    RepeatMode = false;
                    RepeatSMode = false;
                    PBRepeat.Image = Properties.Resources.RepeatOff;
                }
                else
                {
                    RepeatMode = true;
                    RepeatSMode = false;
                    PBRepeat.Image = Properties.Resources.Repeat;
                }
            }
            else
            {
                if (RepeatSMode)
                {
                    RepeatSMode = false;
                    RepeatMode = false;
                    PBRepeat.Image = Properties.Resources.RepeatOff;
                }
                else
                {
                    RepeatSMode = true;
                    RepeatMode = false;
                    PBRepeat.Image = Properties.Resources.RepeatS;
                }
            }
        }

        private void PBRepeat_DoubleClick(object sender, EventArgs e)
        {
            if (ExternalPlaylist)
            {
                if (RepeatSMode)
                {
                    RepeatSMode = false;
                    RepeatMode = false;
                    PBRepeat.Image = Properties.Resources.RepeatOff;
                }
                else
                {
                    RepeatSMode = true;
                    RepeatMode = false;
                    PBRepeat.Image = Properties.Resources.RepeatS;
                }
            }
        }

        private void MTBPosition_Scroll_1(object sender, EventArgs e)
        {
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            SidePanelHider();
        }

        private void panelChildForm_MouseMove(object sender, MouseEventArgs e)
        {
            SidePanelHider();
        }

        private void Player_MouseMoveEvent(object sender, AxWMPLib._WMPOCXEvents_MouseMoveEvent e)
        {
            SidePanelHider();
        }

        private void panelPlayer_MouseMove(object sender, MouseEventArgs e)
        {
            var CursorPosition = this.PointToClient(Cursor.Position);
            if (CursorPosition.X > 7)
            {
                panelSideMenu.Visible = false;
            }
            else
            {
                panelSideMenu.Visible = true;
            }
        }

        private void BtnCapture_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.IO.Path.GetExtension(Player.URL).Equals(".mp4", StringComparison.OrdinalIgnoreCase))
                {
                    Pausar();
                    int videoWidth, videoHeight, videoX, videoY;
                    double VideoRatioAspect = (double)Player.currentMedia.imageSourceWidth / Player.currentMedia.imageSourceHeight;
                    double PlayerRatioAspect = (double)Player.Width / Player.Height;
                    if (PlayerRatioAspect>VideoRatioAspect)//en caso de que el reproductor sea mas ancho
                    {
                        videoHeight = Player.Height;
                        videoWidth = (int)(videoHeight*VideoRatioAspect);
                        videoX = Player.PointToScreen(new System.Drawing.Point()).X + (Player.Width-videoWidth)/2;
                        videoY = Player.PointToScreen(new System.Drawing.Point()).Y;
                    }
                    else//en caso de que el reproductor sea mas alto
                    {
                        videoWidth = Player.Width;
                        videoHeight = (int)(videoWidth / VideoRatioAspect);
                        videoX = Player.PointToScreen(new System.Drawing.Point()).X;
                        videoY=Player.PointToScreen(new System.Drawing.Point()).Y + (Player.Height - videoHeight) /2;
                    }

                    Bitmap bitmap = new Bitmap(videoWidth, videoHeight);
                    Graphics graphic = Graphics.FromImage(bitmap);
                    graphic.CopyFromScreen(videoX, videoY, 0, 0, bitmap.Size);

                    FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        string FolderSelected = folderBrowserDialog.SelectedPath;
                        string FullURL = Path.Combine(FolderSelected, "Capture.png");
                        string name = "Capture";
                        string ext = ".png";
                        int x = 1;
                        while (File.Exists(FullURL))
                        {
                            string tempFileName = string.Format("{0}({1})", name , x++);
                            FullURL = Path.Combine(FolderSelected, tempFileName + ext);
                        }
                        bitmap.Save(FullURL, System.Drawing.Imaging.ImageFormat.Png);
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show("There has been a problem saving the capture. Error: "+ex);
            }
        }

        private void BtnExtractor_Click(object sender, EventArgs e)
        {
            openChildForm(new AudioExtractor(this));
            hideSubMenu();
        }

        private void MTBPosition_MouseUp(object sender, MouseEventArgs e)
        {
            Play();
            Player.Ctlcontrols.currentPosition = MTBPosition.Value;
            position = (int)Player.Ctlcontrols.currentPosition;
            timer1.Start();
            BtnPlay.Select();
            SetTimeStuff();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            //setting MTBPosition parameters
            SetTimeStuff();

            if ((position > (int)Player.currentMedia.duration) && ExternalPlaylist)
            {
                if (ShuffleMode)
                {
                    if (RepeatSMode)
                    {
                        Player.Ctlcontrols.stop();
                        Reset();
                        Play();
                    }
                    else
                    {
                        NextElement(MixxedPlaylist);
                    }
                }
                else
                {
                    if (RepeatSMode)
                    {
                        Player.Ctlcontrols.stop();
                        Reset();
                        Play();
                    }
                    else
                    {
                        NextElement(PlayList);
                    }
                }
            }
            else if (position > (int)Player.currentMedia.duration)
            {
                if (RepeatSMode)
                {
                    Player.Ctlcontrols.stop();
                    Reset();
                    Play();
                }
                else
                {
                    timer1.Stop();
                    LblPosition.Text = "00:00:00";
                    position = 0;
                    MTBPosition.Value = 0;
                    play = false;
                    MTBPosition.Enabled = false;
                    PBPlay.Image = Properties.Resources.play2;
                }
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

