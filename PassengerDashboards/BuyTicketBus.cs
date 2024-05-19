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
        double fixedRate = 100;
        double fare;
        string seatNumbers;
        public BuyTicketBus()
        {
            InitializeComponent();
            choosenButton.Clear();
            allButtons.Clear();
            addButtonstoList();
            UpdateButtonTagsFromDatabase(PassengerInfoSingleton.Instance.CurrentPassenger.ticket.vehicleID);
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
            if (choosenButton.Count > 4 && button.BackColor == targetColor) { MessageBox.Show("Maximum seat limit reached!"); return; }
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
            setTemporarySeats();
            calculateFare();
            textBox2.Text = $"{fare}";
            //UpdateButtonTagsFromDatabase(PassengerInfoSingleton.Instance.CurrentPassenger.ticket.vehicleID);
        }

        private void buttonBuyTicket_Click(object sender, EventArgs e)
        {
            updateSeatStatus();
            seatNumbers = setSeatNumbers();
            PassengerInfoSingleton.Instance.CurrentPassenger.ticket.fare = this.fare;
            PassengerInfoSingleton.Instance.CurrentPassenger.ticket.seatAmount = choosenButton.Count;
            PassengerInfoSingleton.Instance.CurrentPassenger.ticket.seatNumber = seatNumbers;

            Payment payment = new Payment();
            payment.Show();
            this.Hide();
        }

        private void addButtonstoList()
        {
            allButtons.Clear();

            for (int i = 1; i <= 38; i++)
            {
                string buttonText = i.ToString();

                Button button = FindButtonByText(panel1, buttonText);

                if (button != null)
                {
                    allButtons.Add(button);
                }
            }
        }

        private Button FindButtonByText(Control container, string text)
        {
            foreach (Control control in container.Controls)
            {
                if (control is Button button && button.Text == text)
                {
                    return button;
                }
                else if (control.HasChildren)
                {
                    Button foundButton = FindButtonByText(control, text);
                    if (foundButton != null)
                    {
                        return foundButton;
                    }
                }
            }
            return null;
        }

        private void UpdateButtonTagsFromDatabase(int vehicleID)
        {
            string query = "SELECT seatNumber, seatStatus FROM BusSeatTB WHERE vehicleID = @vehicleID";

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
                        string seatNumber = reader["seatNumber"].ToString();

                        Button button = allButtons.FirstOrDefault(b => b.Text == i.ToString());
                        if (button != null)
                        {
                            bool status = (bool)reader["seatStatus"];
                            button.Tag = seatNumber;
                            button.BackColor = status ? Color.White : Color.Red;
                        }
                        i++;
                    }
                }
            }
        }

        private void calculateFare()
        {
            if (choosenButton.Count <= 4)
            {
                switch (PassengerInfoSingleton.Instance.CurrentPassenger.ticket.vehicleClass.ToLower())
                {
                    case "ac":
                        fare = (fixedRate + 100) * choosenButton.Count;
                        break;
                    case "non-ac":
                        fare = fixedRate * choosenButton.Count;
                        break;
                }
            }
        }

        private string setSeatNumbers()
        {
            string str = "";
            foreach (Button button in choosenButton)
            {
                str += $"{button.Tag}, ";
            }
            str = str.Substring(0, str.Length - 2);
            return str;
        }
        private void setTemporarySeats()
        {
            foreach (Button button in choosenButton)
            {
                button.BackColor = Color.Brown;
            }
        }
    }
}
