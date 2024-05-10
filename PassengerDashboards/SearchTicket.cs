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
        public SearchTicket()
        {
            InitializeComponent();
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
    }
}
