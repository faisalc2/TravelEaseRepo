using System;
using System.Windows.Forms;
using TravelEase.PassengerDashboards;

namespace TravelEase.Moduler_Admin
{
    public partial class EditProfileModule : Form
    {
        public EditProfileModule()
        {
            InitializeComponent();
            this.DGVMAdminInfo.DataSource = ModularAdminSingletone.Instance.currentMAdmin.GetAllModularInfo();
            populateModularInfo();
        }

        public void populateModularInfo()
        {
            var modularAdmin = ModularAdminSingletone.Instance.currentMAdmin;
            textBoxMAdminFirstName.Text = modularAdmin.FirstName;
            textBoxMAdminLastName.Text = modularAdmin.LastName;
            textBoxMAdminPhone.Text = modularAdmin.Phone;
            textBoxMAdminEmail.Text = modularAdmin.Email;
            textBoxMAdminUsername.Text = modularAdmin.userNameModular;
            textBoxMAdminPassword.Text = modularAdmin.userPasswordModular;
            textBoxCompanyName.Text = modularAdmin.company.CompanyName;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var modularAdmin = ModularAdminSingletone.Instance.currentMAdmin;
            modularAdmin.FirstName = textBoxMAdminFirstName.Text;
            modularAdmin.LastName = textBoxMAdminLastName.Text;
            modularAdmin.Phone = textBoxMAdminPhone.Text;
            modularAdmin.Email = textBoxMAdminEmail.Text;
            modularAdmin.userNameModular = textBoxMAdminUsername.Text;
            modularAdmin.userPasswordModular = textBoxMAdminPassword.Text;
            modularAdmin.company.CompanyName = textBoxCompanyName.Text;

            bool isUpdated = modularAdmin.UpdateMAdminDetails(modularAdmin);

            if (isUpdated)
            {
                MessageBox.Show("Details updated successfully!");
                this.DGVMAdminInfo.DataSource = modularAdmin.GetAllModularInfo();
            }
            else
            {
                MessageBox.Show("Failed to update details.");
            }
        }
    }
}
