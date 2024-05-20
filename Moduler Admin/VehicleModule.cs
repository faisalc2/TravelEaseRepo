using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TravelEase.Moduler_Admin
{
    public partial class VehicleModule : Form
    {
        public VehicleModule()
        {
            InitializeComponent();
        }

        private int GetVehicleTypeID()
        {
            if (radioButtonBus.Checked) {Vehicle.vehicleTypeID = 1; return 1; }
            if (radioButtonAirPlane.Checked) { Vehicle.vehicleTypeID = 4; return 4; }
            if (radioButtonTrain.Checked) { Vehicle.vehicleTypeID = 2; return 2; }
            if (radioButtonLaunch.Checked) { Vehicle.vehicleTypeID = 3; return 3; }
            throw new Exception("No vehicle type selected");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string vehicleName = textBox9.Text;
                string BDRegistrationNumber = textBox10.Text;
                string desFrom = textBox7.Text;
                string desTo = textBox8.Text;

                if (string.IsNullOrWhiteSpace(vehicleName) ||
                    string.IsNullOrWhiteSpace(BDRegistrationNumber) ||
                    string.IsNullOrWhiteSpace(desFrom) ||
                    string.IsNullOrWhiteSpace(desTo))
                {
                    MessageBox.Show("Please fill out all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                switch (GetVehicleTypeID())
                {
                    case 1:
                        Bus.AddBus(vehicleName, BDRegistrationNumber, desFrom, desTo);
                        MessageBox.Show("Bus added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        Train.AddTrain(vehicleName, BDRegistrationNumber, desFrom, desTo);
                        MessageBox.Show("Train added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 3:
                        Launch.AddLaunch(vehicleName, BDRegistrationNumber, desFrom, desTo);
                        MessageBox.Show("Launch added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 4:
                        Airplane.AddAirplane(vehicleName, BDRegistrationNumber, desFrom, desTo);
                        MessageBox.Show("Airplane added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        throw new Exception("Invalid vehicle type selected");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding vehicle: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox7.Focus();
        }
    }
}
