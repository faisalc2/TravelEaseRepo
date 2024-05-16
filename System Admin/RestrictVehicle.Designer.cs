namespace TravelEase.System_Admin
{
    partial class RestrictVehicle
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
            textBox1 = new TextBox();
            labelName = new Label();
            buttonRestrict = new Button();
            DGVPassengerInfo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGVPassengerInfo).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(36, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 38);
            textBox1.TabIndex = 4;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.ForeColor = SystemColors.ButtonHighlight;
            labelName.Location = new Point(26, 84);
            labelName.Name = "labelName";
            labelName.Size = new Size(120, 31);
            labelName.TabIndex = 3;
            labelName.Text = "Vehicle ID:";
            // 
            // buttonRestrict
            // 
            buttonRestrict.BackColor = Color.FromArgb(187, 233, 237);
            buttonRestrict.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRestrict.ForeColor = SystemColors.ActiveCaptionText;
            buttonRestrict.Location = new Point(75, 239);
            buttonRestrict.Name = "buttonRestrict";
            buttonRestrict.Size = new Size(117, 54);
            buttonRestrict.TabIndex = 6;
            buttonRestrict.Text = "Restrict";
            buttonRestrict.UseVisualStyleBackColor = false;
            // 
            // DGVPassengerInfo
            // 
            DGVPassengerInfo.AllowUserToAddRows = false;
            DGVPassengerInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(48, 56, 79);
            DGVPassengerInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            DGVPassengerInfo.BorderStyle = BorderStyle.None;
            DGVPassengerInfo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(48, 56, 79);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DGVPassengerInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DGVPassengerInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVPassengerInfo.EnableHeadersVisualStyles = false;
            DGVPassengerInfo.Location = new Point(279, 93);
            DGVPassengerInfo.Name = "DGVPassengerInfo";
            DGVPassengerInfo.ReadOnly = true;
            DGVPassengerInfo.RowHeadersWidth = 51;
            DGVPassengerInfo.Size = new Size(423, 340);
            DGVPassengerInfo.TabIndex = 7;
            // 
            // RestrictVehicle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            ClientSize = new Size(734, 539);
            Controls.Add(DGVPassengerInfo);
            Controls.Add(buttonRestrict);
            Controls.Add(textBox1);
            Controls.Add(labelName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RestrictVehicle";
            Text = "RestrictVehicle";
            ((System.ComponentModel.ISupportInitialize)DGVPassengerInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label labelName;
        private Button buttonRestrict;
        private DataGridView DGVPassengerInfo;
    }
}