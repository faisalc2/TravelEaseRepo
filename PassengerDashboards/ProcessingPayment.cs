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
    public partial class ProcessingPayment : Form
    {
        public ProcessingPayment()
        {
            InitializeComponent();
        }

        private string text1 = "PROCESSING";
        private int dotCount = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dotCount < 6)
            {
                label1.Text = text1 + new string('.', dotCount);
                dotCount++;
            }
            else if (dotCount == 6)
            {
                label1.Text = text1;
                dotCount = 0;
            }
            else
            {
                label1.Text = text1 + new string('.', 6 - dotCount);
                dotCount++;
                if (dotCount > 6)
                    dotCount = 0;
            }
        }

        private void ProcessingPayment_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private int counter = 0;
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            counter += timer2.Interval;
            if (counter >= 3000)
            {
                DownloadTicket downloadTicket = new DownloadTicket();
                downloadTicket.Show();
                this.Hide();
            }
        }
    }
}