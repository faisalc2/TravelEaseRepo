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
using TravelEase.PassengerDashboards;

namespace TravelEase.Dashboards
{
    public partial class SearchTicket : Form
    {
        public string connection = @"Data Source=.\SQLEXPRESS;Initial Catalog = TravelEaseDB; Integrated Security = True";
        public static SearchTicket STinstance;
        public string QGetFrom = "SELECT DISTINCT desFrom FROM DestinationTB where vehicleTypeID = @vehicleTypeID";
        public string QGetTo = "SELECT desTo FROM DestinationTB where desFrom = @desFrom";
        public string QAvailableVehicle = "SELECT vehicleID,vehicleName FROM VehicleTB where destinationID = @destinationID";
        public string QDesID = "SELECT destinationID FROM DestinationTB WHERE desFrom = @desFrom AND desTo = @desTo";
        public int selectedVehicle;
        public int desID;
        AvailableVehicle availableVehicle;

        public SearchTicket()
        {
            InitializeComponent();
            STinstance = this;
            dateTimePickerDate.MinDate = DateTime.Today;
            dateTimePickerDate.MaxDate = DateTime.Today.AddDays(7);
            availableVehicle = new AvailableVehicle();
        }

        private void SearchTicket_Load(object sender, EventArgs e)
        {
            panel1.Show();
            panel1.BringToFront();
            panel2.Hide();
        }

        private void buttonNext1_Click(object sender, EventArgs e)
        {
            PassengerInfoSingleton.Instance.CurrentPassenger.ticket.vehicleType = getSelectedVehicle();
            SqlConnection conn = new SqlConnection(connection);
            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(QGetFrom, conn);
                cmd.Parameters.AddWithValue("@vehicleTypeID", getSelectedVehicle());
                SqlDataAdapter sdt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sdt.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    comboBoxFrom.Items.Add(row["desFrom"].ToString());
                }
            }

            conn.Close();
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
            availableVehicle.setDataSource(getAvailableVehicles());
            PassengerInfoSingleton.Instance.CurrentPassenger.ticket.journeyDate = dateTimePickerDate.Value;
            PassengerInfoSingleton.Instance.CurrentPassenger.ticket.buyDate = DateTime.Now;
            PassengerInfoSingleton.Instance.CurrentPassenger.ticket.desID = desID;
            PassengerInfoSingleton.Instance.CurrentPassenger.ticket.vehicleClass = comboBoxClass.Text;
            availableVehicle.Show();
        }

        private int getSelectedVehicle()
        {
            if (radioButtonBus.Checked)
            {
                return 1;
            }
            else if (radioButtonLaunch.Checked)
            {
                return 3;
            }
            else if (radioButtonTrain.Checked)
            {
                return 2;
            }
            else if (radioButtonPlane.Checked)
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }

        private void comboBoxFrom_TextChanged(object sender, EventArgs e)
        {
            string currFrom = comboBoxFrom.Text;
            SqlConnection conn = new SqlConnection(connection);
            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(QGetTo, conn);
                cmd.Parameters.AddWithValue("@desFrom", currFrom);
                SqlDataAdapter sdt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sdt.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    comboBoxTo.Items.Add(row["desTo"].ToString());
                }
            }
            conn.Close();
        }

        private DataTable getAvailableVehicles()
        {
            string currFrom = comboBoxFrom.Text;
            string currTo = comboBoxTo.Text;
            SqlDataAdapter sdt;
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                try
                {
                    // Get destination ID
                    using (SqlCommand cmd = new SqlCommand(QDesID, conn))
                    {
                        cmd.Parameters.AddWithValue("@desFrom", currFrom);
                        cmd.Parameters.AddWithValue("@desTo", currTo);
                        desID = (int)cmd.ExecuteScalar();

                        // Get available vehicles for the destination
                        using (SqlCommand cmdAvailableVehicle = new SqlCommand(QAvailableVehicle, conn))
                        {
                            cmdAvailableVehicle.Parameters.AddWithValue("@destinationID", desID);
                            using (sdt = new SqlDataAdapter(cmdAvailableVehicle))
                            {
                                sdt.Fill(dt);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

            return dt;
        }
    }
}
