using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelEase.WelcomeModel;

namespace TravelEase.Resources
{
    public partial class MainUserControl1 : UserControl
    {
        public event EventHandler NextButtonClicked;
        public MainUserControl1()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            NextButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
