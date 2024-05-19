using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEase.Moduler_Admin
{
    public partial class CancelationModule : Form
    {
        public CancelationModule()
        {
            InitializeComponent();
        }

        private void CancelationModule_Load(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxVehicleID.Text, out int vehicleID))
            {
                string message;
                DataTable dataTable = ModularAdminSingletone.Instance.currentMAdmin.GetTicketsByVehicleID(vehicleID, out message);

                if (dataTable != null)
                {
                    dataGridViewTicketSearchedbyVehicleID.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid vehicle ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCancelTicketModular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxTicketID.Text, out int ticketID) && int.TryParse(textBoxVehicleID.Text, out int vehicleID))
            {
                bool success = ModularAdminSingletone.Instance.currentMAdmin.DeleteTicket(vehicleID, ticketID);

                if (success)
                {
                    MessageBox.Show("Ticket canceled successfully.");
                    RefreshTicketsGrid(vehicleID);
                }
                else
                {
                    MessageBox.Show("Failed to cancel ticket. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid Vehicle ID and Ticket ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RefreshTicketsGrid(int vehicleID)
        {
            string message;
            DataTable dataTable = ModularAdminSingletone.Instance.currentMAdmin.GetTicketsByVehicleID(vehicleID, out message);

            if (dataTable != null)
            {
                dataGridViewTicketSearchedbyVehicleID.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
