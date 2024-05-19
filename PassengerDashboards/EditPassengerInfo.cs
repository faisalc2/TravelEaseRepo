using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEase.PassengerDashboards
{
    public partial class EditPassengerInfo : Form
    {

        public EditPassengerInfo()
        {
            InitializeComponent();
            this.DGVPassengerInfo.DataSource = PassengerInfoSingleton.Instance.CurrentPassenger.GetAllInfo();
            populateInfo();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //PassengerDashboard passengerDashboard = new PassengerDashboard();
            //passengerDashboard.Show();
            this.Close();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // database er kaj ase then dasboard e jabe
            //PassengerDashboard passengerDashboard = new PassengerDashboard();
            //passengerDashboard.Show();
            this.Close();
        }

        private void buttonupdate_Click_1(object sender, EventArgs e)
        {
            if(textBoxpass.Text == textBoxRepass.Text)
            {
                if (PassengerInfoSingleton.Instance.CurrentPassenger.UpdateUserDetails(getEditedInfo()))
                {
                    MessageBox.Show("Information Updated!");
                    this.DGVPassengerInfo.DataSource = PassengerInfoSingleton.Instance.CurrentPassenger.GetAllInfo();
                }
            }
            else
            {
                MessageBox.Show("Password and re-password is not identical", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        public Passenger getEditedInfo() 
        {
            var passenger = PassengerInfoSingleton.Instance.CurrentPassenger;
            passenger.FirstName = textBoxFirstName.Text;
            passenger.LastName = textBoxLastName.Text;
            passenger.DateOfBirth = dateTimePicker1.Value;
            passenger.Gender = comboBoxGender.Text;
            passenger.Phone = textBoxPhone.Text;
            passenger.Email = textBoxEmail.Text;
            passenger.userName = textBoxUserName.Text;
            passenger.userPassword = textBoxRepass.Text;
            return passenger;
        }

        public void populateInfo()
        {
            var passenger = PassengerInfoSingleton.Instance.CurrentPassenger;
            textBoxFirstName.Text = passenger.FirstName;
            textBoxLastName.Text = passenger.LastName;
            dateTimePicker1.Value = passenger.DateOfBirth;
            comboBoxGender.Text = passenger.Gender;
            textBoxPhone.Text = passenger.Phone;
            textBoxEmail.Text = passenger.Email;
            textBoxUserName.Text = passenger.userName;
            textBoxpass.Text = passenger.userPassword;
            textBoxRepass.Text = passenger.userPassword;
        }
    }
}
