using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEase.WelcomeModel
{
    public partial class FormLoadingPage : Form
    {
        public FormLoadingPage()
        {
            InitializeComponent();
        }

        private string text1 = "LOADING";
        private int dotCount = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 587)
            {
                timer1.Stop();
                FormHomePage formHomePage = new FormHomePage();
                formHomePage.Show();
                this.Hide();
            }
        }

        private void FormLoadingPage_Load(object sender, EventArgs e)
        {
            //text1 = label1.Text;
            //text2 = ".....";
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (dotCount < 6) // Display "Loading" with increasing dots
            {
                label1.Text = text1 + new string('.', dotCount);
                dotCount++;
            }
            else if (dotCount == 6) // Display "Loading" without dots
            {
                label1.Text = text1;
                dotCount = 0; // Reset dot count
            }
            else // Display "Loading" with decreasing dots (optional)
            {
                label1.Text = text1 + new string('.', 6 - dotCount);
                dotCount++;
                if (dotCount > 6) // Reset if exceeding max dots
                {
                    dotCount = 0;
                }
            }
        }
    }
}
