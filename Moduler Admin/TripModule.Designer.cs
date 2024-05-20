namespace TravelEase.Moduler_Admin
{
    partial class TripModule
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            textBoxFrom = new TextBox();
            label9 = new Label();
            button7 = new Button();
            button8 = new Button();
            textBoxTo = new TextBox();
            label8 = new Label();
            textBoxVehicleID = new TextBox();
            label7 = new Label();
            DGVTriopInfo = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVTriopInfo).BeginInit();
            SuspendLayout();
            // 
            // textBoxFrom
            // 
            textBoxFrom.Anchor = AnchorStyles.None;
            textBoxFrom.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFrom.Location = new Point(58, 182);
            textBoxFrom.Name = "textBoxFrom";
            textBoxFrom.ReadOnly = true;
            textBoxFrom.Size = new Size(212, 38);
            textBoxFrom.TabIndex = 24;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(58, 148);
            label9.Name = "label9";
            label9.Size = new Size(76, 31);
            label9.TabIndex = 23;
            label9.Text = "From:";
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.BackColor = Color.FromArgb(187, 233, 237);
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(190, 367);
            button7.Name = "button7";
            button7.Size = new Size(107, 41);
            button7.TabIndex = 21;
            button7.Text = "REMOVE";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.None;
            button8.BackColor = Color.FromArgb(187, 233, 237);
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(56, 367);
            button8.Name = "button8";
            button8.Size = new Size(107, 41);
            button8.TabIndex = 20;
            button8.Text = "ADD";
            button8.UseVisualStyleBackColor = false;
            // 
            // textBoxTo
            // 
            textBoxTo.Anchor = AnchorStyles.None;
            textBoxTo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTo.Location = new Point(58, 286);
            textBoxTo.Name = "textBoxTo";
            textBoxTo.ReadOnly = true;
            textBoxTo.Size = new Size(212, 38);
            textBoxTo.TabIndex = 19;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(58, 252);
            label8.Name = "label8";
            label8.Size = new Size(45, 31);
            label8.TabIndex = 18;
            label8.Text = "To:";
            // 
            // textBoxVehicleID
            // 
            textBoxVehicleID.Anchor = AnchorStyles.None;
            textBoxVehicleID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxVehicleID.Location = new Point(58, 75);
            textBoxVehicleID.Name = "textBoxVehicleID";
            textBoxVehicleID.ReadOnly = true;
            textBoxVehicleID.Size = new Size(212, 38);
            textBoxVehicleID.TabIndex = 17;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(58, 41);
            label7.Name = "label7";
            label7.Size = new Size(127, 31);
            label7.TabIndex = 16;
            label7.Text = "Vehicle ID:";
            // 
            // DGVTriopInfo
            // 
            DGVTriopInfo.AllowUserToAddRows = false;
            DGVTriopInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(187, 233, 237);
            DGVTriopInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGVTriopInfo.BorderStyle = BorderStyle.None;
            DGVTriopInfo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(48, 56, 79);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVTriopInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGVTriopInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVTriopInfo.EnableHeadersVisualStyles = false;
            DGVTriopInfo.Location = new Point(372, 75);
            DGVTriopInfo.Name = "DGVTriopInfo";
            DGVTriopInfo.ReadOnly = true;
            DGVTriopInfo.RowHeadersWidth = 51;
            DGVTriopInfo.Size = new Size(385, 347);
            DGVTriopInfo.TabIndex = 25;
            DGVTriopInfo.CellContentClick += DGVTriopInfo_CellContentClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(502, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 31);
            label1.TabIndex = 26;
            label1.Text = "Trip Details:";
            // 
            // TripModule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            ClientSize = new Size(769, 491);
            Controls.Add(label1);
            Controls.Add(DGVTriopInfo);
            Controls.Add(textBoxFrom);
            Controls.Add(label9);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(textBoxTo);
            Controls.Add(label8);
            Controls.Add(textBoxVehicleID);
            Controls.Add(label7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TripModule";
            Text = "TripModule";
            ((System.ComponentModel.ISupportInitialize)DGVTriopInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFrom;
        private Label label9;
        private Button button7;
        private Button button8;
        private TextBox textBoxTo;
        private Label label8;
        private TextBox textBoxVehicleID;
        private Label label7;
        private DataGridView DGVTriopInfo;
        private Label label1;
    }
}