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
    public partial class BuyTicketLaunch : Form
    {
        private List<Button> choosenButton = new List<Button>();
        int number_of_seat = 0;
        public BuyTicketLaunch()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            AvailableVehicle availableVehicle = new AvailableVehicle();
            availableVehicle.Show();
            this.Hide();
        }

        private void choosencabin(object sender, EventArgs e)
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

        private void buttonSelectComplete_Click(object sender, EventArgs e)
        {
            int result = number_of_seat * 100;
            textBox2.Text = $"{number_of_seat} * 100 = {result}";
        }

        private void buttonBuyTicket_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
            this.Hide();
        }
    }
}
