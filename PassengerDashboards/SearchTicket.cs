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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            AvailableVehicle availableVehicle = new AvailableVehicle();
            availableVehicle.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            PassengerDashboard pd = new PassengerDashboard();
            this.Hide();
            pd.Show();
        }

        private void buttonBus_Click(object sender, EventArgs e)
        {
            AvailableVehicle.SetSelectedVehicle("Bus");
        }

        private void buttonTrain_Click(object sender, EventArgs e)
        {
            AvailableVehicle.SetSelectedVehicle("Train");
        }

        private void buttonAir_Click(object sender, EventArgs e)
        {
            AvailableVehicle.SetSelectedVehicle("Air");
        }

        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            AvailableVehicle.SetSelectedVehicle("Launch");
        }
    }
}
