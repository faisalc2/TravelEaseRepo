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
    public partial class MainUserControl4 : UserControl
    {
        public MainUserControl4()
        {
            InitializeComponent();
        }

        private void button_EditPI_Click(object sender, EventArgs e)
        {

        }

        private void button_EditCI_Click(object sender, EventArgs e)
        {

        }

        private void button_EditAC_Click(object sender, EventArgs e)
        {

        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainUserControl5 mainUserControl5 = new MainUserControl5();
            this.Parent.Controls.Add(mainUserControl5);
            mainUserControl5.Visible = true;
            mainUserControl5.BringToFront();
        }
    }
}
