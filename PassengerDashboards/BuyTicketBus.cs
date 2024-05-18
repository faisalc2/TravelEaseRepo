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
    public partial class BuyTicketBus : Form
    {
        string connection = @"Data Source=.\SQLEXPRESS;Initial Catalog = TravelEaseDB; Integrated Security = True";
        private List<Button> choosenButton = new List<Button>();
        private List<Button> allButtons = new List<Button>();
        int number_of_seat = 0;
        public BuyTicketBus()
        {
            InitializeComponent();
            choosenButton.Clear();
            allButtons.Clear();
            addButtonstoList();
            UpdateButtonTagsFromDatabase(1);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            AvailableVehicle availableVehicle = new AvailableVehicle();
            availableVehicle.Show();
            this.Hide();
        }

        private void ChoosenBusSeat(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Color targetColor = Color.White;
            Color target2 = Color.Lime;
            if (button.BackColor == targetColor)
            {
                button.BackColor = target2;
                choosenButton.Add(button);
                number_of_seat++;
            }
            else if (button.BackColor == target2)
            {
                button.BackColor = Color.White;
                choosenButton.Remove(button);
                number_of_seat--;
            }
        }

        public void updateSeatStatus()
        {
            string QupdateStatus = "UPDATE BusSeatTB SET seatStatus = @seatStatus WHERE seatNumber = @seatNumber";
            SqlConnection conn = new SqlConnection(connection);
            using (conn)
            {
                conn.Open();
                foreach (Button button in choosenButton)
                {
                    SqlCommand cmd = new SqlCommand(QupdateStatus, conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@seatNumber", button.Tag.ToString());
                        cmd.Parameters.AddWithValue("@seatStatus", 0);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSelectComplete_Click(object sender, EventArgs e)
        {
            int result = number_of_seat * 100;
            textBox2.Text = $"{number_of_seat} * 100 = {result}";
            updateSeatStatus();
            UpdateButtonTagsFromDatabase(1);
        }

        private void buttonBuyTicket_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
            this.Hide();
        }

        private void addButtonstoList()
        {
            for (int i = 1; i <= 38; i++)
            {
                // Construct the button name
                string buttonName = "button" + i;

                // Find the button control by name
                Button button = this.Controls.Find(buttonName, true)[0] as Button;

                // Add the button to the list
                allButtons.Add(button);
            }
        }
        private void UpdateButtonTagsFromDatabase(int vehicleID)
        {
            string query = "SELECT seatNumber, seatStatus FROM BusSeatTB where vehicleID = @vehicleID";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@vehicleID", vehicleID);
                conn.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int i = 1;
                    while (reader.Read())
                    {
                        string buttonName = "button" + i;
                        Button button = this.Controls.Find(buttonName, true)[0] as Button;
                        string seatName = reader["SeatNumber"].ToString();
                        bool status = (bool)reader["seatStatus"];
                        button.Tag = seatName;
                        button.BackColor = status ? Color.White : Color.Red;
                        i++;
                    }
                    MessageBox.Show("buttons have been tagged!");
                }

            }
        }


    }
}
