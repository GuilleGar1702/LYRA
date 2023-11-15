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
    public partial class Form3 : Form
    {
        private Form1 Principal;
        String[] RecentMediaArray = new String [0];
        String[] URLsArray = new String [0];
        String ElementSelected;
        public Form3(Form1 Principal)
        {
            InitializeComponent();
            this.Principal = Principal;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public void AddMedia(String NewRecentMedia, String NewURL)
        {
            //Set new element in the array
            String[] TempElementsArray = new String[RecentMediaArray.Length+1];
            Array.Copy(RecentMediaArray, TempElementsArray, RecentMediaArray.Length);
            TempElementsArray[RecentMediaArray.Length] = NewRecentMedia;
            RecentMediaArray = TempElementsArray;



            //Set new URL in the array
            String[] TempURLsArray = new String[URLsArray.Length + 1];
            Array.Copy(URLsArray, TempURLsArray, URLsArray.Length);
            TempURLsArray[URLsArray.Length] = NewURL;
            URLsArray = TempURLsArray;



            //Refresh the DataGripView
            DGVRecentMedia.Rows.Clear();
            foreach (var File in RecentMediaArray)
            {
                int n = DGVRecentMedia.Rows.Add();
                DGVRecentMedia.Rows[n].Cells[0].Value = File;
            }
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (var File in Principal.RecentURLs.Reverse()){
                int n = DGVRecentMedia.Rows.Add();
                DGVRecentMedia.Rows[n].Cells[0].Value = System.IO.Path.GetFileName(File);
            }
        }

        private void DGVRecentMedia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnPlay.Enabled = true;
            int n = e.RowIndex;
            if (n != -1)
            {
                ElementSelected = URLsArray[n];
            }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Principal.ExternalURL = ElementSelected;
            Principal.ExternalInput = true;
            this.Close();
        }
    }
}
