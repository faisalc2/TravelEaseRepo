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

namespace TravelEase.System_Admin
{
    public partial class RemoveUser : Form
    {
        public RemoveUser()
        {
            InitializeComponent();
            load_Table();
            //this.DGVUserInfo.DataSource = AdminInfoSingleton.Instance.CurrentAdmin.GetSomeUserInfo();
        }
        public void load_Table()
        {
            DataTable dt = new TravelEase.Admin().GetSomeUserInfo();
            DGVUserInfo.DataSource = dt;
        }
    }
}
