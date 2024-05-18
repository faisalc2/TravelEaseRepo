using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
    }
}
