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
    public partial class RefundModule : Form
    {
        public RefundModule()
        {
            InitializeComponent();
            this.DGVRefundInfo.DataSource = ModularAdminSingletone.Instance.currentMAdmin.RefundRuleShow();
        }

        private void buttonUpdateRule_Click(object sender, EventArgs e)
        {
            if(textBox80.Text == "" || textBox60.Text == "" || textBox40.Text == "" || textBoxNoR.Text == "")
            {
                MessageBox.Show("Fill All the textbox", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                if (!ModularAdminSingletone.Instance.currentMAdmin.IsModularAdminNumberExists())
                {
                    ModularAdminSingletone.Instance.currentMAdmin.InsertRefundRule();
                }
                if (ModularAdminSingletone.Instance.currentMAdmin.RefundRuleUpdate(getEditedMAdminInfo()))
                {
                    MessageBox.Show("Information Updated!");
                    this.DGVRefundInfo.DataSource = ModularAdminSingletone.Instance.currentMAdmin.RefundRuleShow();
                }
            }
            
        }

        private ModularAdmin getEditedMAdminInfo()
        {
            var Madmin = ModularAdminSingletone.Instance.currentMAdmin;

            Madmin.Persent_80 = int.Parse(textBox80.Text);
            Madmin.Persent_60 = int.Parse(textBox60.Text);
            Madmin.Persent_40 = int.Parse(textBox40.Text);
            Madmin.No_refund = int.Parse(textBoxNoR.Text);

            return Madmin;
        }
    }
}
