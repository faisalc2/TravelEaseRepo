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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            textBoxVehicleID = new TextBox();
            labelName = new Label();
            buttonRemove = new Button();
            DGVVehicleInfo = new DataGridView();
            textBoxSearch = new TextBox();
            label1 = new Label();
            textBoxVName = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVVehicleInfo).BeginInit();
            SuspendLayout();
            // 
            // textBoxVehicleID
            // 
            textBoxVehicleID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxVehicleID.Location = new Point(36, 129);
            textBoxVehicleID.Name = "textBoxVehicleID";
            textBoxVehicleID.ReadOnly = true;
            textBoxVehicleID.Size = new Size(212, 38);
            textBoxVehicleID.TabIndex = 4;
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
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.FromArgb(187, 233, 237);
            buttonRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRemove.ForeColor = SystemColors.ActiveCaptionText;
            buttonRemove.Location = new Point(89, 327);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(117, 54);
            buttonRemove.TabIndex = 6;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // DGVVehicleInfo
            // 
            DGVVehicleInfo.AllowUserToAddRows = false;
            DGVVehicleInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(187, 233, 237);
            DGVVehicleInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGVVehicleInfo.BorderStyle = BorderStyle.None;
            DGVVehicleInfo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(48, 56, 79);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVVehicleInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGVVehicleInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVVehicleInfo.EnableHeadersVisualStyles = false;
            DGVVehicleInfo.Location = new Point(281, 129);
            DGVVehicleInfo.Name = "DGVVehicleInfo";
            DGVVehicleInfo.ReadOnly = true;
            DGVVehicleInfo.RowHeadersWidth = 51;
            DGVVehicleInfo.Size = new Size(441, 357);
            DGVVehicleInfo.TabIndex = 7;
            DGVVehicleInfo.CellContentClick += DGVVehicleInfo_CellContentClick;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(396, 57);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(212, 38);
            textBoxSearch.TabIndex = 8;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(347, 9);
            label1.Name = "label1";
            label1.Size = new Size(319, 31);
            label1.TabIndex = 9;
            label1.Text = "User Vehicle Name for Search:";
            // 
            // textBoxVName
            // 
            textBoxVName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxVName.Location = new Point(36, 240);
            textBoxVName.Name = "textBoxVName";
            textBoxVName.ReadOnly = true;
            textBoxVName.Size = new Size(212, 38);
            textBoxVName.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(26, 197);
            label2.Name = "label2";
            label2.Size = new Size(159, 31);
            label2.TabIndex = 11;
            label2.Text = "Vehicle Name:";
            // 
            // RestrictVehicle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            ClientSize = new Size(734, 539);
            Controls.Add(label2);
            Controls.Add(textBoxVName);
            Controls.Add(label1);
            Controls.Add(textBoxSearch);
            Controls.Add(DGVVehicleInfo);
            Controls.Add(buttonRemove);
            Controls.Add(textBoxVehicleID);
            Controls.Add(labelName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RestrictVehicle";
            Text = "RestrictVehicle";
            ((System.ComponentModel.ISupportInitialize)DGVVehicleInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxVehicleID;
        private Label labelName;
        private Button buttonRemove;
        private DataGridView DGVVehicleInfo;
        private TextBox textBoxSearch;
        private Label label1;
        private TextBox textBoxVName;
        private Label label2;
    }
}