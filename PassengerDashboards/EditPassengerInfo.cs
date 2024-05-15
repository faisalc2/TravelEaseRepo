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
    public partial class EditPassengerInfo : Form
    {

        public EditPassengerInfo()
        {
            InitializeComponent();
            this.DGVPassengerInfo.DataSource = PassengerInfoSingleton.Instance.CurrentPassenger.GetAllInfo();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //PassengerDashboard passengerDashboard = new PassengerDashboard();
            //passengerDashboard.Show();
            this.Close();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // database er kaj ase then dasboard e jabe
            //PassengerDashboard passengerDashboard = new PassengerDashboard();
            //passengerDashboard.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
