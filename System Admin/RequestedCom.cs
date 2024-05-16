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
    public partial class RequestedCom : Form
    {
        internal string? vehicleselect;
        public RequestedCom()
        {
            InitializeComponent();
            radioBtnBus.Checked = true;

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioBtnBus.Checked)
            {
                labelName.Text = "Name of Bus Company:";
                labelID.Text = "BRTC ID:";
            }
            else if(radioBtnTrain.Checked)
            {
                labelName.Text = "Name of train:";
                labelID.Text = "Train ID:";
            }
            else if(radioBtnAir.Checked)
            {
                labelName.Text = "Name of Airlines company: ";
                labelID.Text = "Plane ID:";
            }
            else if (radioButtonShip.Checked)
            {
                labelName.Text = "Name of Ship company: ";
                labelID.Text = "Ship ID:";
            }
        }
    }
}
