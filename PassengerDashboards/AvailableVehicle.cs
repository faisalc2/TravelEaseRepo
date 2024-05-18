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
        private static int? selectedVehicle;
        public DataTable dt;
        public AvailableVehicle()
        {
            InitializeComponent();
        }

        public void setDataSource(DataTable dt)
        {
            DGVAvailableVehicle.DataSource = dt;
        }

        public void SetSelectedVehicle(int vehicle)
        {
            selectedVehicle = vehicle;
        }
        private void buttonBookNow_Click(object sender, EventArgs e)
        {
            switch (selectedVehicle)
            {
                case 1:
                    BuyTicketBus buyTicketBus = new BuyTicketBus();
                    buyTicketBus.Show();
                    break;
                case 2:
                    BuyTicketTrain buyTicketTrain = new BuyTicketTrain();
                    buyTicketTrain.Show();
                    break;
                case 4:
                    BuyTicketAir buyTicketAir = new BuyTicketAir();
                    buyTicketAir.Show();
                    break;
                case 3:
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

        private void DGVAvailableVehicle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = DGVAvailableVehicle.Rows[e.RowIndex];

                string cellValue1 = selectedRow.Cells[0].Value.ToString();
                string cellValue2 = selectedRow.Cells[1].Value.ToString();

            }
        }
    }
}
