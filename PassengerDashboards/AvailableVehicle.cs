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
    public partial class AvailableVehicle : Form
    {
        private static string? selectedVehicle;
        public AvailableVehicle()
        {
            InitializeComponent();
        }

        public static void SetSelectedVehicle(string vehicle)
        {
            selectedVehicle = vehicle;
        }
        private void buttonBookNow_Click(object sender, EventArgs e)
        {
            switch (selectedVehicle)
            {
                case "Bus":
                    BuyTicketBus buyTicketBus = new BuyTicketBus();
                    buyTicketBus.Show();
                    break;
                case "Train":
                    BuyTicketTrain buyTicketTrain = new BuyTicketTrain();
                    buyTicketTrain.Show();
                    break;
                case "Air":
                    BuyTicketAir buyTicketAir = new BuyTicketAir();
                    buyTicketAir.Show();
                    break;
                case "Launch":
                    BuyTicketLaunch buyTicketLaunch = new BuyTicketLaunch();
                    buyTicketLaunch.Show();
                    break;
            }
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
