using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        public DataTable dt;
        public int cellVehicleID;
        public string cellVehicleName;
        public AvailableVehicle()
        {
            InitializeComponent();
        }

        public void setDataSource(DataTable dt)
        {
            DGVAvailableVehicle.DataSource = dt;
        }

        private void buttonBookNow_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(cellVehicleName) || string.IsNullOrEmpty(cellVehicleID.ToString())))
            {
                PassengerInfoSingleton.Instance.CurrentPassenger.ticket.vehicleID = cellVehicleID;
                if (!vehicleAvailablity())
                {
                    MessageBox.Show("There is no seats under this vehicle!");
                    return;
                }
                switch (PassengerInfoSingleton.Instance.CurrentPassenger.ticket.vehicleType)
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
            else
            {
                MessageBox.Show("Please select a vehicle first!");
                return;
            }
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

                cellVehicleID = (int)selectedRow.Cells[0].Value;
                cellVehicleName = selectedRow.Cells[1].Value.ToString();

            }
        }

        private bool vehicleAvailablity()
        {
            string query = "SELECT seatNumber, seatStatus FROM BusSeatTB WHERE vehicleID = @vehicleID";
            bool result;
            using (SqlConnection conn = new SqlConnection(PassengerInfoSingleton.Instance.CurrentPassenger.connection))
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@vehicleID", cellVehicleID);
                conn.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    result = reader.HasRows ? true : false;

                }
            }
            return result;
        }
    }
}
