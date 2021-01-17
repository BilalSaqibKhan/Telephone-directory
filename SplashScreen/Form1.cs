using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//By Bilal saqib khan

namespace SplashScreen
{
    public partial class frmSplash : Form
    {
        string UserName, Password;
        public frmSplash(string username = "testing mode", string password = "testing mode")
        {
            InitializeComponent();

            UserName = username;
            Password = password;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pb.Width = pb.Width + 10;

            if (pb.Width == 200)
            {
                lblLoading.Text = "Loading all Components....";
            }

            if (pb.Width == 350)
            {
                lblLoading.Text = "Getting Ready....";
            }

            if (pb.Width == 490)
            {
                timer1.Stop();
                this.Hide();
                frmMain obj = new frmMain(UserName, Password);
                obj.ShowDialog();
                this.Close();
            }
        }
    }
}
