using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelEase.Dashboards;

namespace TravelEase.PassengerDashboards
{
    public partial class PassengerDashboard : Form
    {
        public PassengerDashboard()
        {
            InitializeComponent();
        }

        private void buttonSearchTicket_Click(object sender, EventArgs e)
        {
            SearchTicket Sticket = new SearchTicket();
            Sticket.Show();
            this.Close();
        }

        private void buttonEditProfile_Click(object sender, EventArgs e)
        {
            EditPassengerInfo epi = new EditPassengerInfo();
            this.Hide();
            epi.Show();
        }
    }
}
