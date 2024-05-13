﻿using System;
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

            ModularPanel1.Hide();
            ModularPanel2.Hide();
            ModularPanel3.Hide();
            ModularPanel4.Hide();
            ModularPanel5.Hide();

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

            ModularPanel1.Hide();
            ModularPanel2.Show();
            ModularPanel2.BringToFront();
        }

        private void buttonNextM2_Click(object sender, EventArgs e)
        {
            textBox_nidmm.Text = textBox_NIDM.Text;
            textBox_fnamemm.Text = textBox_FnameM.Text;
            textBox_lnamemm.Text = textBox_LnameM.Text;
            textBox_dobmm.Text = dateTimePicker_DOBM.Text;
            textBox_gendermm.Text = comboBox_GenderM.Text;
            textBox_phonemm.Text = textBox_PhoneM.Text;
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
                    textBox_usernamemm.Text = textBox_UsernameM.Text;
                    textBox_passwordmm.Text = textBox_Password1M.Text;

                    ModularPanel4.Show();
                    ModularPanel4.BringToFront();
                    ModularPanel3.Hide();
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
            string date = DateTime.Now.ToString("ddMMyyyy");
            Random random = new Random();
            int randomNumber = random.Next(10000, 99999);
            textBox_UIDM.Text = $"MAD-{date}-{randomNumber}";

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
            if (!string.IsNullOrWhiteSpace(textBox_UIDM.Text))
            {
                Clipboard.SetText(textBox_UIDM.Text);
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
    }
}
