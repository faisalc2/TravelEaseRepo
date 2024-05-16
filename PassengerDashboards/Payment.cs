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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void buttonpurchase_Click(object sender, EventArgs e)
        {
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
            //
            //
            this.Hide();

        }

        private void buttonPurchase3_Click(object sender, EventArgs e)
        {
            ProcessingPayment processingPayment = new ProcessingPayment();
            processingPayment.Show();
            this.Hide();
        }
    }
}
