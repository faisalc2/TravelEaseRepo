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

namespace TravelEase.System_Admin
{
    public partial class RestrictVehicle : Form
    {
        public string connection = @"Data Source=.\SQLEXPRESS;Initial Catalog = TravelEaseDB; Integrated Security = True";
        public RestrictVehicle()
        {
            InitializeComponent();
            load_Table();
        }
        public void load_Table()
        {
            DataTable dt = new Admin().GetVehicleInfo();
            DGVVehicleInfo.DataSource = dt;
        }

        private void DGVVehicleInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVVehicleInfo.Rows[e.RowIndex];

                textBoxVehicleID.Text = row.Cells["vehicleID"].Value.ToString();
                textBoxVName.Text = row.Cells["vehicleName"].Value.ToString();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string query = "UPDATE VehicleTB SET vehicleStatus = 0 WHERE vehicleID = @vehicleID";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@vehicleID", textBoxVehicleID.Text);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }

            load_Table();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchFirstName(textBoxSearch.Text);
        }

        private void SearchFirstName(string searchTerm)
        {
            string query = "select vehicleID, vehicleName, BDRegistrationNumber from VehicleTB WHERE vehicleName LIKE @searchTerm";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                    SqlDataAdapter sdt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sdt.Fill(dt);
                    DGVVehicleInfo.DataSource = dt;
                }
                conn.Close();
            }
        }
    }
}
