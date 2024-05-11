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
        //public static AvailableVehicle tktinstance;
        private static string selectedVehicle="something ";
        public AvailableVehicle()
        {
            InitializeComponent();
            //tktinstance = this;
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
    }
}
