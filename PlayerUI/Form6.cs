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
    public partial class Form6 : Form
    {
        private Form1 Principal;
        public Form6(Form1 Principal)
        {
            InitializeComponent();
            this.Principal = Principal;
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
            Principal.SidePanelHider();
        }
    }
}
