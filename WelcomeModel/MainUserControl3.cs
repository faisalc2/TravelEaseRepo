using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEase.WelcomeModel
{
    public partial class MainUserControl3 : UserControl
    {
        public MainUserControl3()
        {
            InitializeComponent();
        }

        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPassword.Checked)
            {
                textBox_Password1.UseSystemPasswordChar = false;
                textBox_Password2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_Password1.UseSystemPasswordChar = true;
                textBox_Password2.UseSystemPasswordChar = true;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainUserControl4 mainUserControl4 = new MainUserControl4();
            this.Parent.Controls.Add(mainUserControl4);
            mainUserControl4.Visible = true;
            mainUserControl4.BringToFront();
        }
    }
}
