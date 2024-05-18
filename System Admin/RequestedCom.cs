using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEase.System_Admin
{
    public partial class RequestedCom : Form
    {
        internal string? vehicleselect;
        public string connection = @"Data Source=.\SQLEXPRESS;Initial Catalog = TravelEaseDB; Integrated Security = True";
        public RequestedCom()
        {
            InitializeComponent();
            load_Table();
        }
        public void load_Table()
        {
            DataTable dt = new TravelEase.Admin().GetCompanyDetails();
            DGVCompanyInfo.DataSource = dt;
        }

        private void checkAndPrint(string vehicleTypeName)
        {
            if (vehicleTypeName == "Bus")
            {
                labelName.Text = "Name of Bus Company:";
                labelID.Text = "BRTC ID:";
            }
            else if (vehicleTypeName == "Tain")
            {
                labelName.Text = "Name of train:";
                labelID.Text = "Train ID:";
            }
            else if (vehicleTypeName == "Air")
            {
                labelName.Text = "Name of Airlines company: ";
                labelID.Text = "Plane ID:";
            }
            else if (vehicleTypeName == "Ship")
            {
                labelName.Text = "Name of Ship company: ";
                labelID.Text = "Ship ID:";
            }
        }

        private void DGVCompanyInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVCompanyInfo.Rows[e.RowIndex];

                textBoxComName.Text = row.Cells["compName"].Value.ToString();
                textBoxComID.Text = row.Cells["companyID"].Value.ToString();
            }
            GetVehicleType(textBoxComID.Text);
        }

        private void GetVehicleType(string companyID)
        {
            if (!string.IsNullOrEmpty(companyID))
            {
                string query = @"
                    SELECT vt.vehicleTypeName
                    FROM CompanyVehicleTB cv
                    JOIN VehicleTB v ON cv.vehicleID = v.vehicleID
                    JOIN VehicleTypeTB vt ON v.vehicleTypeID = vt.vehicleTypeID
                    WHERE cv.companyID = @companyID;
                ";

                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@companyID", companyID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string vehicleTypeName = reader["vehicleTypeName"].ToString();
                                checkAndPrint(vehicleTypeName);
                            }
                            else
                            {
                                MessageBox.Show("No vehicles found for the given company ID.");
                            }
                        }
                    }
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid company ID.");
            }
        }

        private void buttonApprove_Click(object sender, EventArgs e)
        {

            string query = "UPDATE CompanyTB SET companyStatus = 1 WHERE bdRegId = @bdRegID";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@bdRegID", textBoxComID.Text);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }

            load_Table();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchCompanyName(textBox1.Text);
        }
        private void SearchCompanyName(string stext)
        {
            string query = "select companyID, compName, bdRegID from CompanyTB WHERE compName LIKE @stext";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@stext", "%" + stext + "%");

                    SqlDataAdapter sdt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sdt.Fill(dt);
                    DGVCompanyInfo.DataSource = dt;
                }
                conn.Close();
            }
        }

        
    }
}
