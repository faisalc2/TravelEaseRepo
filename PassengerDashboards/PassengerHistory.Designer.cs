namespace TravelEase.PassengerDashboards
{
    partial class PassengerHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            DGVRecentTicketInfo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGVRecentTicketInfo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(302, 30);
            label1.Name = "label1";
            label1.Size = new Size(173, 31);
            label1.TabIndex = 1;
            label1.Text = "Recent Ticktes:";
            // 
            // DGVRecentTicketInfo
            // 
            DGVRecentTicketInfo.AllowUserToAddRows = false;
            DGVRecentTicketInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(48, 56, 79);
            DGVRecentTicketInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            DGVRecentTicketInfo.BorderStyle = BorderStyle.None;
            DGVRecentTicketInfo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(48, 56, 79);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DGVRecentTicketInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DGVRecentTicketInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVRecentTicketInfo.EnableHeadersVisualStyles = false;
            DGVRecentTicketInfo.Location = new Point(77, 115);
            DGVRecentTicketInfo.Name = "DGVRecentTicketInfo";
            DGVRecentTicketInfo.ReadOnly = true;
            DGVRecentTicketInfo.RowHeadersWidth = 51;
            DGVRecentTicketInfo.Size = new Size(602, 342);
            DGVRecentTicketInfo.TabIndex = 2;
            // 
            // PassengerHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            ClientSize = new Size(725, 538);
            Controls.Add(DGVRecentTicketInfo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PassengerHistory";
            Text = "PassengerHistory";
            ((System.ComponentModel.ISupportInitialize)DGVRecentTicketInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView DGVRecentTicketInfo;
    }
}