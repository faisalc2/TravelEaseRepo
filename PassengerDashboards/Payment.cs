using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEase.PassengerDashboards
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void buttonpurchase_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textboxCardNumber.Text) || string.IsNullOrEmpty(textboxPin.Text)))
            {
                MessageBox.Show("Please provide Payment Credentials!");
                return;
            }
            insertTicket();
            ProcessingPayment processingPayment = new ProcessingPayment();
            processingPayment.Show();
            this.Hide();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            panel2.Hide();
            panel3.Hide();
            panel1.Show();
            panel1.BringToFront();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (radioButtonMobileBanking.Checked)
            {
                panel1.Hide();
                panel3.Hide();
                panel2.Show();
                panel2.BringToFront();
            }
            if (radioButtonCardPayment.Checked)
            {
                panel1.Hide();
                panel2.Hide();
                panel3.Show();
                panel3.BringToFront();
            }
        }

        private void buttonCancel1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonPurchase3_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textboxCardNumber.Text) || string.IsNullOrEmpty(textboxPin.Text)))
            {
                MessageBox.Show("Please provide Payment Credentials!");
                return;
            }
            insertTicket();
            ProcessingPayment processingPayment = new ProcessingPayment();
            processingPayment.Show();
            this.Hide();
        }
        private void insertTicket()
        {
            string QinsertTicket = "INSERT INTO TicketTB (ticketID,buyDate, fare, seatAmount, vehicleID, userID, journeyDate)" +
                "VALUES(@ticketID, @buyDate, @fare, @seatAmount, @vehicleID, @userID, @journeyDate)";
            string QGetTID = "select max(ticketID) AS LastTicketID from TicketTB where userID = @userID";
            string QGetLTID = "SELECT MAX(ticketID) AS LastTicketID FROM TicketTB";
            DateTime buyD = PassengerInfoSingleton.Instance.CurrentPassenger.ticket.buyDate;
            SqlConnection conn = new SqlConnection(PassengerInfoSingleton.Instance.CurrentPassenger.connection);
            conn.Open();
            using (conn)
            {
                SqlCommand cmd = new SqlCommand(QGetLTID, conn);
                int tid = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand(QinsertTicket, conn);
                cmd.Parameters.AddWithValue("@ticketID", (tid + 1));
                cmd.Parameters.AddWithValue("@buyDate", buyD);
                cmd.Parameters.AddWithValue("@fare", (float)PassengerInfoSingleton.Instance.CurrentPassenger.ticket.fare);
                cmd.Parameters.AddWithValue("@seatAmount", PassengerInfoSingleton.Instance.CurrentPassenger.ticket.seatAmount);
                cmd.Parameters.AddWithValue("@vehicleID", PassengerInfoSingleton.Instance.CurrentPassenger.ticket.vehicleID);
                cmd.Parameters.AddWithValue("@userID", PassengerInfoSingleton.Instance.CurrentPassenger.UserID);
                cmd.Parameters.AddWithValue("@journeyDate", PassengerInfoSingleton.Instance.CurrentPassenger.ticket.journeyDate);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }

                cmd = new SqlCommand(QGetTID, conn);
                cmd.Parameters.AddWithValue("@userID", PassengerInfoSingleton.Instance.CurrentPassenger.UserID);
                try
                {
                    PassengerInfoSingleton.Instance.CurrentPassenger.ticket.ticketID = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
        }
    }
}
