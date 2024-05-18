using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
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

namespace TravelEase.System_Admin
{
    public partial class RemoveUser : Form
    {
        public string connection = @"Data Source=.\SQLEXPRESS;Initial Catalog = TravelEaseDB; Integrated Security = True";
        public RemoveUser()
        {
            InitializeComponent();
            load_Table();
            //this.DGVUserInfo.DataSource = AdminInfoSingleton.Instance.CurrentAdmin.GetSomeUserInfo();
        }
        public void load_Table()
        {
            DataTable dt = new TravelEase.Admin().GetSomeUserInfo();
            DGVUserInfo.DataSource = dt;
        }

        private void DGVUserInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGVUserInfo.Rows[e.RowIndex];

                textBoxFname.Text = row.Cells["fName"].Value.ToString();
                textBoxLname.Text = row.Cells["Lname"].Value.ToString();
                textBoxUID.Text = row.Cells["userID"].Value.ToString();

                if (IsUserIDExistsInModulerTable(textBoxUID.Text))
                {
                    textBox1.Text = "Moduler Admin";
                }
                else
                {
                    textBox1.Text = "Passenger";
                }
            }

        }

        private bool IsUserIDExistsInModulerTable(string userid)
        {
            bool exists = false;

            string query = "SELECT COUNT(*) FROM ModularAdminTB WHERE userID = @userID";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", userid);

                    int count = (int)cmd.ExecuteScalar();
                    exists = count > 0;
                }
                conn.Close();
            }

            return exists;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchFirstName(textBoxSearch.Text);
        }

        private void SearchFirstName(string searchTerm)
        {
            string query = "SELECT userID, fname, lName, phone FROM UserTB WHERE fname LIKE @searchTerm";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                    SqlDataAdapter sdt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sdt.Fill(dt);
                    DGVUserInfo.DataSource = dt;
                }
                conn.Close();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string userId = textBoxUID.Text;
            if(userId == string.Empty)
            {
                MessageBox.Show("Choose a Row first");
            }
            else if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DeleteUserById(userId);
                load_Table();  // Refresh the DataGridView to reflect the changes
            }
            
        }
        private void DeleteUserById(string userId)
        {
            string updateUserStatusQuery = "UPDATE UserTB SET userStatus = 0 WHERE userID = @userID";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(updateUserStatusQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", userId);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }
    }
}
