using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEase.WelcomeModel
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {
            MainPanel1.Hide();
            MainPanel2.Hide();
            MainPanel3.Hide();
            MainPanel4.Hide();
            MainPanel5.Hide();

            MainPanel0.Show();
            MainPanel0.BringToFront();
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
                    tb_username.Text = textBox_Username.Text;
                    tb_password.Text = textBox_Password1.Text;

                    MainPanel4.Show();
                    MainPanel4.BringToFront();
                    MainPanel3.Hide();
                }
                else
                {
                    MessageBox.Show("Passwords don't match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Must provide a username and a password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonExit4_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            MainPanel5.Show();
            MainPanel5.BringToFront();
            MainPanel4.Hide();

            string date = DateTime.Now.ToString("ddMMyyyy");
            Random random = new Random();
            int randomNumber = random.Next(10000, 99999);
            textBox_UID.Text = $"CUS-{date}-{randomNumber}";
        }

        private void buttonExit5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_UID.Text))
            {
                Clipboard.SetText(textBox_UID.Text);
                MessageBox.Show("Text copied to clipboard!");
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
            else
            {
                //
                //
                //
            }
        }
    }
}
