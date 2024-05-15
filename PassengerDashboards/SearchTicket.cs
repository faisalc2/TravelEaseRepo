using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelEase.PassengerDashboards;

namespace TravelEase.Dashboards
{
    public partial class SearchTicket : Form
    {
        public static SearchTicket STinstance;
        public SearchTicket()
        {
            InitializeComponent();
            STinstance = this;
        }

        private void SearchTicket_Load(object sender, EventArgs e)
        {
            panel1.Show();
            panel1.BringToFront();
            panel2.Hide();
        }

        private void buttonNext1_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel2.BringToFront();
            panel1.Hide();
        }

        private void buttonPrevious2_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel1.BringToFront();
            panel2.Hide();
        }

        private void buttonNext2_Click(object sender, EventArgs e)
        {
            if (radioButtonBus.Checked)
            {
                AvailableVehicle.SetSelectedVehicle("Bus");
            }
            else if (radioButtonLaunch.Checked)
            {
                AvailableVehicle.SetSelectedVehicle("Launch");
            }
            else if (radioButtonTrain.Checked)
            {
                AvailableVehicle.SetSelectedVehicle("Train");
            }
            else if (radioButtonPlane.Checked)
            {
                AvailableVehicle.SetSelectedVehicle("Air");
            }
            AvailableVehicle availableVehicle = new AvailableVehicle();
            availableVehicle.Show();
            //database
        }
    }
}
