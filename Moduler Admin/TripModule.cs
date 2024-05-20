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
    public partial class TripModule : Form
    {
        public TripModule()
        {
            InitializeComponent();
            DGVTriopInfo.DataSource = ModularAdminSingletone.Instance.currentMAdmin.TripInfoShow();
        }

        private void DGVTriopInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGVTriopInfo.Rows[e.RowIndex];

                textBoxVehicleID.Text = row.Cells["vehicleID"].Value.ToString();
                textBoxFrom.Text = row.Cells["desFrom"].Value.ToString();
                textBoxTo.Text = row.Cells["desTo"].Value.ToString();

            }
        }
    }
}
