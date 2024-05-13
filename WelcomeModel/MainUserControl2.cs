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
    public partial class MainUserControl2 : UserControl
    {
        public MainUserControl2()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainUserControl3 mainUserControl3 = new MainUserControl3();
            this.Parent.Controls.Add(mainUserControl3);
            mainUserControl3.Visible = true;
            mainUserControl3.BringToFront();
        }
    }
}
