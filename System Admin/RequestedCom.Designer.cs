namespace TravelEase.System_Admin
{
    partial class RequestedCom
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
            labelName = new Label();
            textBoxComName = new TextBox();
            textBoxComID = new TextBox();
            labelID = new Label();
            buttonApprove = new Button();
            DGVCompanyInfo = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVCompanyInfo).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.ForeColor = SystemColors.ButtonHighlight;
            labelName.Location = new Point(27, 150);
            labelName.Name = "labelName";
            labelName.Size = new Size(209, 31);
            labelName.TabIndex = 1;
            labelName.Text = "Name of Company:";
            // 
            // textBoxComName
            // 
            textBoxComName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxComName.Location = new Point(37, 195);
            textBoxComName.Name = "textBoxComName";
            textBoxComName.ReadOnly = true;
            textBoxComName.Size = new Size(212, 38);
            textBoxComName.TabIndex = 2;
            // 
            // textBoxComID
            // 
            textBoxComID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxComID.Location = new Point(37, 304);
            textBoxComID.Name = "textBoxComID";
            textBoxComID.ReadOnly = true;
            textBoxComID.Size = new Size(212, 38);
            textBoxComID.TabIndex = 4;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelID.ForeColor = SystemColors.ButtonHighlight;
            labelID.Location = new Point(37, 259);
            labelID.Name = "labelID";
            labelID.Size = new Size(47, 31);
            labelID.TabIndex = 3;
            labelID.Text = " ID:";
            // 
            // buttonApprove
            // 
            buttonApprove.BackColor = Color.FromArgb(187, 233, 237);
            buttonApprove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonApprove.ForeColor = SystemColors.ActiveCaptionText;
            buttonApprove.Location = new Point(98, 384);
            buttonApprove.Name = "buttonApprove";
            buttonApprove.Size = new Size(117, 54);
            buttonApprove.TabIndex = 5;
            buttonApprove.Text = "Approve";
            buttonApprove.UseVisualStyleBackColor = false;
            buttonApprove.Click += buttonApprove_Click;
            // 
            // DGVCompanyInfo
            // 
            DGVCompanyInfo.AllowUserToAddRows = false;
            DGVCompanyInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(187, 233, 237);
            DGVCompanyInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGVCompanyInfo.BorderStyle = BorderStyle.None;
            DGVCompanyInfo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(48, 56, 79);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVCompanyInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGVCompanyInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVCompanyInfo.EnableHeadersVisualStyles = false;
            DGVCompanyInfo.Location = new Point(313, 150);
            DGVCompanyInfo.Name = "DGVCompanyInfo";
            DGVCompanyInfo.ReadOnly = true;
            DGVCompanyInfo.RowHeadersWidth = 51;
            DGVCompanyInfo.Size = new Size(399, 340);
            DGVCompanyInfo.TabIndex = 14;
            DGVCompanyInfo.CellContentClick += DGVCompanyInfo_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(413, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 38);
            textBox1.TabIndex = 15;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(347, 58);
            label1.Name = "label1";
            label1.Size = new Size(335, 31);
            label1.TabIndex = 16;
            label1.Text = "Use Company Name for Search:";
            // 
            // RequestedCom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            ClientSize = new Size(734, 539);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(DGVCompanyInfo);
            Controls.Add(buttonApprove);
            Controls.Add(textBoxComID);
            Controls.Add(labelID);
            Controls.Add(textBoxComName);
            Controls.Add(labelName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RequestedCom";
            Text = "RequestedBusCom";
            ((System.ComponentModel.ISupportInitialize)DGVCompanyInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelName;
        private TextBox textBoxComName;
        private TextBox textBoxComID;
        private Label labelID;
        private Button buttonApprove;
        private DataGridView DGVCompanyInfo;
        private TextBox textBox1;
        private Label label1;
    }
}