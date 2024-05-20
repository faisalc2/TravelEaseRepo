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
    public partial class NewModuler : Form
    {
        public NewModuler()
        {
            InitializeComponent();
            LoadForm(new VehicleModule());
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

        private void buttonTrip_Click(object sender, EventArgs e)
        {
            LoadForm(new TripModule());
            buttonTrip.FlatStyle = FlatStyle.Standard;
            buttonVehicle.FlatStyle = FlatStyle.Flat;
            buttonRefundModAdmin.FlatStyle = FlatStyle.Flat;
            buttonCancelation.FlatStyle = FlatStyle.Flat;
        }

        private void buttonVehicle_Click(object sender, EventArgs e)
        {
            LoadForm(new VehicleModule());
            buttonTrip.FlatStyle = FlatStyle.Flat;
            buttonVehicle.FlatStyle = FlatStyle.Standard;
            buttonRefundModAdmin.FlatStyle = FlatStyle.Flat;
            buttonCancelation.FlatStyle = FlatStyle.Flat;
        }

        private void buttonRefundAdmin_Click(object sender, EventArgs e)
        {
            LoadForm(new RefundModule());
            buttonTrip.FlatStyle = FlatStyle.Flat;
            buttonVehicle.FlatStyle = FlatStyle.Flat;
            buttonRefundModAdmin.FlatStyle = FlatStyle.Standard;
            buttonCancelation.FlatStyle = FlatStyle.Flat;
        }

        private void buttonCancelation_Click(object sender, EventArgs e)
        {
            LoadForm(new CancelationModule());
            buttonTrip.FlatStyle = FlatStyle.Flat;
            buttonVehicle.FlatStyle = FlatStyle.Flat;
            buttonRefundModAdmin.FlatStyle = FlatStyle.Flat;
            buttonCancelation.FlatStyle = FlatStyle.Standard;
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            Profile_edit();
        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {
            Profile_edit();
        }
        private void Profile_edit()
        {
            LoadForm(new EditProfileModule());
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogOut_Click_1(object sender, EventArgs e)
        {
            FormHomePage formHomePage = new FormHomePage();
            formHomePage.Show();
            this.Hide();
        }
    }
}
