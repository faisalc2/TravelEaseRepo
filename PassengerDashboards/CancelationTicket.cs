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
    public partial class CancelationTicket : Form
    {
        public CancelationTicket()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ticketID;
            if (!int.TryParse(txtTicketID.Text, out ticketID))
            {
                MessageBox.Show("Please enter a valid ticket ID.", "Invalid Ticket ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool cancelled = PassengerInfoSingleton.Instance.CurrentPassenger.CancelTicket(ticketID);
            if (cancelled)
            {
                MessageBox.Show("Ticket canceled successfully.", "Ticket Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTicketID.Clear();
                txtTicketID.Focus();
            }
            else
            {
                MessageBox.Show("Ticket ID not found. Please enter a valid ticket ID.", "Ticket Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
