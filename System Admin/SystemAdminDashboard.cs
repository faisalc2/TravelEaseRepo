using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelEase.System_Admin
{
    public partial class SystemAdminDashboard : Form
    {

        public SystemAdminDashboard()
        {
            InitializeComponent();
            LoadForm(new RequestedCom());
        }

        public void LoadForm(object Form)
        {
            if (this.panelMainSystem.Controls.Count > 0)
            {
                this.panelMainSystem.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            if (f != null)
            {
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.panelMainSystem.Controls.Add(f);
                this.panelMainSystem.Tag = f;
                f.Show();
            }
        }
        private void buttonVehicleCom_Click(object sender, EventArgs e)
        {
            LoadForm(new RequestedCom());
            buttonVehicleCom.FlatStyle = FlatStyle.Standard;
            buttonRemoveUser.FlatStyle = FlatStyle.Flat;
            buttonRestrict.FlatStyle = FlatStyle.Flat;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRemoveUser_Click(object sender, EventArgs e)
        {
            LoadForm(new RemoveUser());
            buttonVehicleCom.FlatStyle = FlatStyle.Flat;
            buttonRemoveUser.FlatStyle = FlatStyle.Standard;
            buttonRestrict.FlatStyle = FlatStyle.Flat;
        }

        private void buttonRestrict_Click(object sender, EventArgs e)
        {
            LoadForm(new RestrictVehicle());
            buttonVehicleCom.FlatStyle = FlatStyle.Flat;
            buttonRemoveUser.FlatStyle = FlatStyle.Flat;
            buttonRestrict.FlatStyle = FlatStyle.Standard;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.Show();
            this.Hide();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            LoadForm(new AdminProfile());
        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {
            LoadForm(new AdminProfile());
        }
    }
}
