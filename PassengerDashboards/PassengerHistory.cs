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
    public partial class PassengerHistory : Form
    {
        public PassengerHistory()
        {
            InitializeComponent();
            this.DGVRecentTicketInfo.DataSource = PassengerInfoSingleton.Instance.CurrentPassenger.GetTicketInfo();
        }
    }
}
