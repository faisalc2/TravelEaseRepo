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
        public string QGetFrom = "SELECT DISTINCT desFrom FROM DestinationTB";
        public string QGetTo = "SELECT desTo FROM DestinationTB where desFrom = @desFrom";
        public string selectedVehicle;

        public SearchTicket()
        {
            InitializeComponent();
            STinstance = this;
            dateTimePickerDate.MinDate = DateTime.Today;
            dateTimePickerDate.MaxDate = DateTime.Today.AddDays(7);
        }

        private void SearchTicket_Load(object sender, EventArgs e)
        {
            panel1.Show();
            panel1.BringToFront();
            panel2.Hide();
        }

        private void buttonNext1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection);
            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(QGetFrom, conn);
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
            AvailableVehicle availableVehicle = new AvailableVehicle();
            availableVehicle.SetSelectedVehicle(getSelectedVehicle());
            availableVehicle.Show();
            //database
        }

        private string getSelectedVehicle()
        {
            if (radioButtonBus.Checked)
            {
                return "Bus";
            }
            else if (radioButtonLaunch.Checked)
            {
                return "Launch";
            }
            else if (radioButtonTrain.Checked)
            {
                return "Train";
            }
            else if (radioButtonPlane.Checked)
            {
                return "Plane";
            }
            else
            {
                return null;
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
    }
}
