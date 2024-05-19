using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEase.WelcomeModel
{
    public partial class FormRegistration : Form
    {
        public string connection = @"Data Source=.\SQLEXPRESS;Initial Catalog = TravelEaseDB; Integrated Security = True";

        public FormRegistration()
        {
            InitializeComponent();
        }

        private void insertModularAdmin()
        {
            string QInsertUser = "INSERT INTO UserTB " +
                "(userID, fName, lName, nid, gender, dob, phone, email, residence, userStatus)" +
                "VALUES (@userID, @fName, @lName, @nid, @gender, @dob, @phone, @email, @residence, @userStatus)";

            string QInsertLoginCred = "INSERT INTO LoginCredentialsTB (userID, userName, userPassword) " +
                "VALUES (@userID, @userName, @userPassword)";

            string QInsertCompany = "INSERT INTO CompanyTB (companyID, compName, bdRegID) " +
                "VALUES (@companyID, @compName, @bdRegID)";

            string QInsertModularAdminTB = "INSERT INTO ModularAdminTB (userID) VALUES (@userID)";

            string QInsertMAdminCompanyTB = "INSERT INTO MAdminCompanyTB (companyID, MAdminNumber) " +
                "VALUES (@companyID, @MAdminNumber)";

            string QGetMAdminNum = "SELECT MAdminNumber FROM ModularAdminTB WHERE userID = @userID";

            SqlConnection conn = new SqlConnection(connection);
            if (conn.State != ConnectionState.Open) { conn.Open(); }
            string uid = User.GenerateUniqueId();
            int MAdminN;
            using (conn)
            {
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Inserting into UserTB
                    SqlCommand cmd = new SqlCommand(QInsertUser, conn, transaction);
                    cmd.Parameters.AddWithValue("@userID", uid);
                    cmd.Parameters.AddWithValue("@fName", textBox_FnameM.Text);
                    cmd.Parameters.AddWithValue("@lName", textBox_LnameM.Text);
                    cmd.Parameters.AddWithValue("@nid", textBox_NIDM.Text);
                    cmd.Parameters.AddWithValue("@gender", comboBox_GenderM.Text);
                    cmd.Parameters.AddWithValue("@dob", dateTimePicker_DOBM.Value.ToString("yyyy-MM-dd")); // Ensure date format
                    cmd.Parameters.AddWithValue("@phone", textBox_PhoneM.Text);
                    cmd.Parameters.AddWithValue("@email", textBox_EmailM.Text);
                    cmd.Parameters.AddWithValue("@residence", textBox_AddressM.Text);
                    cmd.Parameters.AddWithValue("@userStatus", 1);
                    cmd.ExecuteNonQuery();

                    // Inserting into LoginCredentialsTB
                    cmd = new SqlCommand(QInsertLoginCred, conn, transaction);
                    cmd.Parameters.AddWithValue("@userID", uid);
                    cmd.Parameters.AddWithValue("@userName", textBox_usernamemm.Text);
                    cmd.Parameters.AddWithValue("@userPassword", textBox_passwordmm.Text);
                    cmd.ExecuteNonQuery();

                    int newCompanyID;
                    cmd = new SqlCommand("SELECT ISNULL(MAX(companyID), 0) + 1 FROM CompanyTB", conn, transaction);
                    newCompanyID = (int)cmd.ExecuteScalar();

                    // Inserting into CompanyTB with the new companyID
                    cmd = new SqlCommand(QInsertCompany, conn, transaction);
                    cmd.Parameters.AddWithValue("@companyID", newCompanyID);
                    cmd.Parameters.AddWithValue("@compName", textBox_cname.Text);
                    cmd.Parameters.AddWithValue("@bdRegID", textBox_grid.Text);
                    cmd.Parameters.AddWithValue("@companyStatus", 0);
                    cmd.ExecuteNonQuery();

                    // Inserting into ModularAdminTB
                    cmd = new SqlCommand(QInsertModularAdminTB, conn, transaction);
                    cmd.Parameters.AddWithValue("@userID", uid);
                    cmd.ExecuteNonQuery();

                    //getting MAdminNumber
                    cmd = new SqlCommand(QGetMAdminNum, conn, transaction);
                    cmd.Parameters.AddWithValue("@userID", uid);
                    MAdminN = (int)cmd.ExecuteScalar();

                    // Inserting into MAdminCompanyTB
                    cmd = new SqlCommand(QInsertMAdminCompanyTB, conn, transaction);
                    cmd.Parameters.AddWithValue("@companyID", newCompanyID);
                    cmd.Parameters.AddWithValue("@MAdminNumber", MAdminN);
                    cmd.ExecuteNonQuery();

                    // Commit transaction
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"{ex.Message}");
                }
            }
            textBox_UIDM.Text = uid;
            textBoxUserName.Text = textBox_usernamemm.Text;
            conn.Close();
        }


        private void insertPassenger()
        {
            string QInsertPassenger = "INSERT INTO UserTB " +
                "(userID, fName, lName, nid, gender, dob, phone, email, residence, userStatus)" +
                "VALUES (@userID, @fName, @lName, @nid, @gender, @dob, @phone, @email, @residence, @userStatus)";

            string QInsertLoginCred = "INSERT INTO LoginCredentialsTB (userID, userName, userPassword) " +
                "VALUES (@userID, @userName, @userPassword)";
            string QInsertPassengerTB = "INSERT INTO PassengerTB (userID) VALUES (@userID)";

            SqlConnection conn = new SqlConnection(connection);
            if (!(conn.State == ConnectionState.Open)) { conn.Open(); }
            string uid = User.GenerateUniqueId();
            using (conn)
            {
                // inserting personal and contact details
                SqlCommand cmd = new SqlCommand(QInsertPassenger, conn);
                cmd.Parameters.AddWithValue("@userID", uid);
                cmd.Parameters.AddWithValue("@fName", textBox_Fname.Text);
                cmd.Parameters.AddWithValue("@lName", textBox_Lname.Text);
                cmd.Parameters.AddWithValue("@nid", textBox_NID.Text);
                cmd.Parameters.AddWithValue("@gender", comboBox_Gender.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimePicker_DOB.Value);
                cmd.Parameters.AddWithValue("@phone", textBox_Phone.Text);
                cmd.Parameters.AddWithValue("@email", textBox_Email.Text);
                cmd.Parameters.AddWithValue("@residence", textBox_Address.Text);
                cmd.Parameters.AddWithValue("@userStatus", 1);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                cmd = new SqlCommand(QInsertLoginCred, conn);
                cmd.Parameters.AddWithValue("@userID", uid);
                cmd.Parameters.AddWithValue("@userName", textBox_Username.Text);
                cmd.Parameters.AddWithValue("@userPassword", textBox_Password1.Text);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
                cmd = new SqlCommand(QInsertPassengerTB, conn);
                cmd.Parameters.AddWithValue("@userID", uid);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
            textBox_UID.Text = uid;
            textBoxUser.Text = tb_username.Text;
            conn.Close();
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {
            MainPanel1.Hide();
            MainPanel2.Hide();
            MainPanel3.Hide();
            MainPanel4.Hide();
            MainPanel5.Hide();

            ModularPanel1.Hide();
            ModularPanel2.Hide();
            ModularPanel3.Hide();
            ModularPanel4.Hide();
            ModularPanel5.Hide();

            MainPanel0.Show();
            MainPanel0.BringToFront();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var address = new MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void buttonExit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack1_Click(object sender, EventArgs e)
        {
            FormHomePage formHomePage = new FormHomePage();
            formHomePage.Show();
            this.Hide();
        }

        private void buttonNext1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox_NID.Text) ||
            string.IsNullOrEmpty(textBox_Fname.Text) ||
            string.IsNullOrEmpty(textBox_Lname.Text) ||
            string.IsNullOrEmpty(dateTimePicker_DOB.Text) ||
            string.IsNullOrEmpty(comboBox_Gender.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_NID.Focus();
                return;
            }

            tb_nid.Text = textBox_NID.Text;
            tb_fname.Text = textBox_Fname.Text;
            tb_lname.Text = textBox_Lname.Text;
            tb_dob.Text = dateTimePicker_DOB.Text;
            tb_gender.Text = comboBox_Gender.Text;

            MainPanel1.Hide();
            MainPanel2.Show();
            MainPanel2.BringToFront();
        }

        private void buttonBack2_Click(object sender, EventArgs e)
        {
            FormHomePage formHomePage = new FormHomePage();
            formHomePage.Show();
            this.Hide();
        }

        private void buttonExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPrevious2_Click(object sender, EventArgs e)
        {
            MainPanel1.Show();
            MainPanel1.BringToFront();
            MainPanel2.Hide();
        }

        private void buttonNext2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Phone.Text) ||
               string.IsNullOrEmpty(textBox_Email.Text) ||
               string.IsNullOrEmpty(textBox_Address.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_NID.Focus();
                return;
            }

            if (!IsValidEmail(textBox_Email.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox_Phone.Text.Length != 11)
            {
                MessageBox.Show("Phone number must be 11 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Phone.Focus();
                return;
            }
            tb_phone.Text = "+88" + textBox_Phone.Text;
            tb_email.Text = textBox_Email.Text;
            tb_address.Text = textBox_Address.Text;

            MainPanel2.Hide();
            MainPanel3.Show();
            MainPanel3.BringToFront();
        }

        private void buttonBack3_Click(object sender, EventArgs e)
        {
            FormHomePage formHomePage = new FormHomePage();
            formHomePage.Show();
            this.Hide();
        }

        private void buttonExit3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPassword.Checked)
            {
                textBox_Password1.UseSystemPasswordChar = false;
                textBox_Password2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_Password1.UseSystemPasswordChar = true;
                textBox_Password2.UseSystemPasswordChar = true;
            }
        }

        private void buttonPrevious3_Click(object sender, EventArgs e)
        {
            MainPanel2.Show();
            MainPanel2.BringToFront();
            MainPanel3.Hide();
        }

        private void buttonNext3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_Username.Text) && !string.IsNullOrEmpty(textBox_Password1.Text) && !string.IsNullOrEmpty(textBox_Password2.Text))
            {
                if (textBox_Password1.Text.Equals(textBox_Password2.Text))
                {
                    if (textBox_Password1.Text.Length >= 8)
                    {
                        tb_username.Text = textBox_Username.Text;
                        tb_password.Text = textBox_Password1.Text;

                        MainPanel4.Show();
                        MainPanel4.BringToFront();
                        MainPanel3.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password must be minimum 8 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox_Password1.Clear();
                        textBox_Password2.Clear();
                        textBox_Password1.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Passwords don't match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Password1.Clear();
                    textBox_Password2.Clear();
                    textBox_Password1.Focus();
                }
            }
            else
            {
                MessageBox.Show("Must provide a username and a password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Username.Clear();
                textBox_Password1.Clear();
                textBox_Password2.Clear();
                textBox_Username.Focus();
            }
        }

        private void buttonBack4_Click(object sender, EventArgs e)
        {
            FormHomePage formHomePage = new FormHomePage();
            formHomePage.Show();
            this.Hide();
        }

        private void button_EditPI_Click(object sender, EventArgs e)
        {
            MainPanel1.Show();
            MainPanel1.BringToFront();
            MainPanel4.Hide();
        }

        private void button_EditCI_Click(object sender, EventArgs e)
        {
            MainPanel2.Show();
            MainPanel2.BringToFront();
            MainPanel4.Hide();
        }

        private void button_EditAC_Click(object sender, EventArgs e)
        {
            MainPanel3.Show();
            MainPanel3.BringToFront();
            MainPanel4.Hide();
        }

        private void buttonPrevious4_Click(object sender, EventArgs e)
        {
            MainPanel3.Show();
            MainPanel3.BringToFront();
            MainPanel4.Hide();
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            insertPassenger();
            MainPanel5.Show();
            MainPanel5.BringToFront();
            MainPanel4.Hide();
        }

        private void buttonExit5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxUser.Text))
            {
                Clipboard.SetText(textBoxUser.Text);
                MessageBox.Show("Username copied to clipboard!");
            }
            else
            {
                MessageBox.Show("There is no text to copy!", "Empty TextBox", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            FormHomePage formHomePage = new FormHomePage();
            formHomePage.Show();
            this.Hide();
        }

        private void buttonExit0_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack0_Click(object sender, EventArgs e)
        {
            FormHomePage formHomePage = new FormHomePage();
            formHomePage.Show();
            this.Hide();
        }

        private void buttonNext0_Click(object sender, EventArgs e)
        {
            if (radioButton_Consumer.Checked)
            {
                MainPanel0.Hide();
                MainPanel1.Show();
                MainPanel1.BringToFront();
            }
            else if (radioButton_ModularAdmin.Checked)
            {
                MainPanel0.Hide();
                ModularPanel1.Show();
                ModularPanel1.BringToFront();
            }
        }

        private void buttonExitM5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBackM1_Click(object sender, EventArgs e)
        {
            FormHomePage formHomePage = new FormHomePage();
            formHomePage.Show();
            this.Hide();
        }

        private void buttonExitM1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNextM1_Click(object sender, EventArgs e)
        {
            textBox_cname.Text = textBox_CompanyName.Text;
            textBox_grid.Text = textBox_GovtReg.Text;
            textBox_vtype.Text = "";
            foreach (var item in checkedListBox_VehicleType.CheckedItems)
            {
                textBox_vtype.Text += item.ToString() + Environment.NewLine;
            }

            ModularPanel2.Show();
            ModularPanel2.BringToFront();
            ModularPanel1.Hide();
        }

        private void buttonNextM2_Click(object sender, EventArgs e)
        {
            if (!IsValidEmail(textBox_EmailM.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBox_nidmm.Text = textBox_NIDM.Text;
            textBox_fnamemm.Text = textBox_FnameM.Text;
            textBox_lnamemm.Text = textBox_LnameM.Text;
            textBox_dobmm.Text = dateTimePicker_DOBM.Text;
            textBox_gendermm.Text = comboBox_GenderM.Text;
            textBox_phonemm.Text = "+88" + textBox_PhoneM.Text;
            textBox_emailmm.Text = textBox_EmailM.Text;
            textBox_addressmm.Text = textBox_AddressM.Text;


            ModularPanel3.Show();
            ModularPanel3.BringToFront();
            ModularPanel2.Hide();
        }

        private void buttonPreviousM2_Click(object sender, EventArgs e)
        {
            ModularPanel1.Show();
            ModularPanel1.BringToFront();
            ModularPanel2.Hide();
        }

        private void buttonBackM2_Click(object sender, EventArgs e)
        {
            FormHomePage formHomePage = new FormHomePage();
            formHomePage.Show();
            this.Hide();
        }

        private void buttonExitM2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonExit3_M_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack3_M_Click(object sender, EventArgs e)
        {
            FormHomePage formHomePage = new FormHomePage();
            formHomePage.Show();
            this.Hide();
        }

        private void buttonNext3_M_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_UsernameM.Text) && !string.IsNullOrEmpty(textBox_Password1M.Text) && !string.IsNullOrEmpty(textBox_Password2M.Text))
            {
                if (textBox_Password1M.Text.Equals(textBox_Password2M.Text))
                {
                    if (textBox_Password1M.Text.Length >= 8)
                    {
                        textBox_usernamemm.Text = textBox_UsernameM.Text;
                        textBox_passwordmm.Text = textBox_Password1M.Text;

                        ModularPanel4.Show();
                        ModularPanel4.BringToFront();
                        ModularPanel3.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password must be minimum 8 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox_Password1M.Clear();
                        textBox_Password2M.Clear();
                        textBox_Password1M.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Passwords don't match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Password1M.Clear();
                    textBox_Password2M.Clear();
                    textBox_Password1M.Focus();
                }
            }
            else
            {
                MessageBox.Show("Must provide a username and a password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_UsernameM.Clear();
                textBox_Password1M.Clear();
                textBox_Password2M.Clear();
                textBox_UsernameM.Focus();
            }
        }

        private void buttonPrevious3_M_Click(object sender, EventArgs e)
        {
            ModularPanel2.Show();
            ModularPanel2.BringToFront();
            ModularPanel3.Hide();
        }

        private void checkBox_ShowPasswordM_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPasswordM.Checked)
            {
                textBox_Password1M.UseSystemPasswordChar = false;
                textBox_Password2M.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_Password1M.UseSystemPasswordChar = true;
                textBox_Password2M.UseSystemPasswordChar = true;
            }
        }

        private void buttonExitM4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBackM4_Click(object sender, EventArgs e)
        {
            FormHomePage formHomePage = new FormHomePage();
            formHomePage.Show();
            this.Hide();
        }

        private void buttonPreviousM4_Click(object sender, EventArgs e)
        {
            ModularPanel3.Show();
            ModularPanel3.BringToFront();
            ModularPanel4.Hide();
        }

        private void buttonRegisterM_Click(object sender, EventArgs e)
        {
            insertModularAdmin();

            ModularPanel5.Show();
            ModularPanel5.BringToFront();
            ModularPanel4.Hide();
        }

        private void button_EditCD_Click(object sender, EventArgs e)
        {
            ModularPanel1.Show();
            ModularPanel1.BringToFront();
            ModularPanel4.Hide();
        }

        private void buttonEditMAI_Click(object sender, EventArgs e)
        {
            ModularPanel2.Show();
            ModularPanel2.BringToFront();
            ModularPanel4.Hide();
        }

        private void button_ACMM_Click(object sender, EventArgs e)
        {
            ModularPanel3.Show();
            ModularPanel3.BringToFront();
            ModularPanel4.Hide();
        }

        private void buttonCopyM_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxUserName.Text))
            {
                Clipboard.SetText(textBoxUserName.Text);
                MessageBox.Show("User Name copied to clipboard!");
            }
            else
            {
                MessageBox.Show("There is no text to copy!", "Empty TextBox", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            FormHomePage formHomePage = new FormHomePage();
            formHomePage.Show();
            this.Hide();
        }

        private void buttonExit4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
