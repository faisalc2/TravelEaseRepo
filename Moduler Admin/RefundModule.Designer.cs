namespace TravelEase.Moduler_Admin
{
    partial class RefundModule
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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DGVPassengerInfo = new DataGridView();
            label2 = new Label();
            panel2 = new Panel();
            textBoxPhone = new TextBox();
            textBoxCompanyName = new TextBox();
            textBoxmodulerAdmin = new TextBox();
            textBoxName = new TextBox();
            label14 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            buttonUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVPassengerInfo).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // DGVPassengerInfo
            // 
            DGVPassengerInfo.AllowUserToAddRows = false;
            DGVPassengerInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(48, 56, 79);
            DGVPassengerInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            DGVPassengerInfo.BorderStyle = BorderStyle.None;
            DGVPassengerInfo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(48, 56, 79);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            DGVPassengerInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            DGVPassengerInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVPassengerInfo.EnableHeadersVisualStyles = false;
            DGVPassengerInfo.Location = new Point(44, 54);
            DGVPassengerInfo.Name = "DGVPassengerInfo";
            DGVPassengerInfo.ReadOnly = true;
            DGVPassengerInfo.RowHeadersWidth = 51;
            DGVPassengerInfo.Size = new Size(770, 169);
            DGVPassengerInfo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(284, 9);
            label2.Name = "label2";
            label2.Size = new Size(226, 31);
            label2.TabIndex = 4;
            label2.Text = "Current Rule details";
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonUpdate);
            panel2.Controls.Add(textBoxPhone);
            panel2.Controls.Add(textBoxCompanyName);
            panel2.Controls.Add(textBoxmodulerAdmin);
            panel2.Controls.Add(textBoxName);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label12);
            panel2.Location = new Point(44, 239);
            panel2.Name = "panel2";
            panel2.Size = new Size(770, 250);
            panel2.TabIndex = 5;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(567, 81);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(121, 27);
            textBoxPhone.TabIndex = 27;
            // 
            // textBoxCompanyName
            // 
            textBoxCompanyName.Location = new Point(165, 188);
            textBoxCompanyName.Name = "textBoxCompanyName";
            textBoxCompanyName.Size = new Size(108, 27);
            textBoxCompanyName.TabIndex = 26;
            // 
            // textBoxmodulerAdmin
            // 
            textBoxmodulerAdmin.Location = new Point(165, 134);
            textBoxmodulerAdmin.Name = "textBoxmodulerAdmin";
            textBoxmodulerAdmin.Size = new Size(108, 27);
            textBoxmodulerAdmin.TabIndex = 25;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(165, 77);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(108, 27);
            textBoxName.TabIndex = 24;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(412, 77);
            label14.Name = "label14";
            label14.Size = new Size(135, 31);
            label14.TabIndex = 16;
            label14.Text = "No Refund:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(3, 182);
            label9.Name = "label9";
            label9.Size = new Size(149, 31);
            label9.TabIndex = 12;
            label9.Text = "40% Refund:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(3, 129);
            label10.Name = "label10";
            label10.Size = new Size(149, 31);
            label10.TabIndex = 11;
            label10.Text = "60% Refund:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(3, 77);
            label11.Name = "label11";
            label11.Size = new Size(149, 31);
            label11.TabIndex = 10;
            label11.Text = "80% Refund:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(195, 14);
            label12.Name = "label12";
            label12.Size = new Size(311, 31);
            label12.TabIndex = 1;
            label12.Text = "Update Refund information";
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(187, 233, 237);
            buttonUpdate.Cursor = Cursors.Hand;
            buttonUpdate.FlatStyle = FlatStyle.Popup;
            buttonUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.ForeColor = Color.Black;
            buttonUpdate.Location = new Point(463, 134);
            buttonUpdate.Margin = new Padding(0);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(133, 70);
            buttonUpdate.TabIndex = 28;
            buttonUpdate.Text = "Update Information";
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // RefundModule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            ClientSize = new Size(854, 538);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(DGVPassengerInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RefundModule";
            Text = "CancelationModule";
            ((System.ComponentModel.ISupportInitialize)DGVPassengerInfo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGVPassengerInfo;
        private Label label2;
        private Panel panel2;
        private TextBox textBoxPhone;
        private TextBox textBoxCompanyName;
        private TextBox textBoxmodulerAdmin;
        private TextBox textBoxName;
        private Label label14;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button buttonUpdate;
    }
}