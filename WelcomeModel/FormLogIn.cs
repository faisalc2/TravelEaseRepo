using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace TravelEase
{
    public partial class FormLogIn : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string Qinsert = "insert into Leaders values(@ID,@Name,@Email)";
        string Qupdate = "update Leaders set Name=@Name,Email=@Email where ID=@ID";
        string Qdelete = "delete Leaders where ID=@ID";
        string QQsearch = "select * from Leaders";
        string Quid = "SELECT userID FROM LoginCredentialsTB WHERE userName = @userName AND userPassword = @userPassword";

        string connection = @"Data Source=.\SQLEXPRESS;Initial Catalog = TravelEaseDB; Integrated Security = True";
        public FormLogIn()
        {
            InitializeComponent();
            this.conn = new SqlConnection(connection);
            conn.Open();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            textBoxUsername.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
                textBoxPassword.UseSystemPasswordChar = false;
            else
                textBoxPassword.UseSystemPasswordChar = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_back_Click_1(object sender, EventArgs e)
        {
            FormHomePage formHomePage = new FormHomePage();
            formHomePage.Show();
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxUsername.Text) && !string.IsNullOrEmpty(textBoxUsername.Text))
            {
                if (!(conn.State == System.Data.ConnectionState.Open)) { conn.Open(); }
                string uname = textBoxUsername.Text;
                string upass = textBoxPassword.Text;
                string uid = null;
                using (conn)
                {
                    using (cmd = new SqlCommand(Quid, conn))
                    {
                        cmd.Parameters.AddWithValue("@userName", uname);
                        cmd.Parameters.AddWithValue("@userPassword", upass);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                uid = reader["userID"].ToString();
                            }
                        }
                    }
                }
                MessageBox.Show(uid, "info");
            }
            else
            {
                MessageBox.Show("error tbs are null!", "info");
            }
        }
    }
}
