using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelEase.Dashboards;
using TravelEase.Moduler_Admin;
using TravelEase.WelcomeModel;

namespace TravelEase.PassengerDashboards
{
    public partial class PassengerDashboard : Form
    {
        public PassengerDashboard()
        {
            InitializeComponent();
            LoadForm(new EditPassengerInfo());
        }

        private void buttonSearchTicket_Click(object sender, EventArgs e)
        {
            SearchTicket Sticket = new SearchTicket();
            Sticket.Show();
            this.Hide();
        }

        private void buttonEditProfile_Click(object sender, EventArgs e)
        {
            EditPassengerInfo epi = new EditPassengerInfo();
            this.Hide();
            epi.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void LoadForm(object Form)
        {
            if (this.panelMain.Controls.Count > 0)
            {
                this.panelMain.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            if (f != null)
            {
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.panelMain.Controls.Add(f);
                this.panelMain.Tag = f;
                f.Show();
            }
        }

        private void buttonSearchTicket_Click_1(object sender, EventArgs e)
        {
            LoadForm(new SearchTicket());
            buttonSearchTicket.FlatStyle = FlatStyle.Standard;
            buttonAccountDetails.FlatStyle = FlatStyle.Flat;
            buttonHistory.FlatStyle = FlatStyle.Flat;
            buttonCancelation.FlatStyle = FlatStyle.Flat;
        }

        private void buttonAccountDetails_Click(object sender, EventArgs e)
        {
            LoadForm(new EditPassengerInfo());
            buttonAccountDetails.FlatStyle = FlatStyle.Standard;
            buttonSearchTicket.FlatStyle = FlatStyle.Flat;
            buttonHistory.FlatStyle = FlatStyle.Flat;
            buttonCancelation.FlatStyle = FlatStyle.Flat;
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            LoadForm(new PassengerHistory());
            buttonHistory.FlatStyle = FlatStyle.Standard;
            buttonAccountDetails.FlatStyle = FlatStyle.Flat;
            buttonSearchTicket.FlatStyle = FlatStyle.Flat;
            buttonCancelation.FlatStyle = FlatStyle.Flat;
        }

        private void buttonCancelation_Click(object sender, EventArgs e)
        {
            LoadForm(new CancelationTicket());
            buttonCancelation.FlatStyle = FlatStyle.Standard;
            buttonAccountDetails.FlatStyle = FlatStyle.Flat;
            buttonHistory.FlatStyle = FlatStyle.Flat;
            buttonSearchTicket.FlatStyle = FlatStyle.Flat;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FormHomePage formHomePage = new FormHomePage();
            formHomePage.Show();
            this.Hide();
            //database clear
        }
    }
}
