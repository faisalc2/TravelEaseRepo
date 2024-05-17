namespace TravelEase.System_Admin
{
    partial class RemoveUser
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
            buttonRemove = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            labelfname = new Label();
            DGVUserInfo = new DataGridView();
            labelLName = new Label();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGVUserInfo).BeginInit();
            SuspendLayout();
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.FromArgb(187, 233, 237);
            buttonRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRemove.ForeColor = SystemColors.ActiveCaptionText;
            buttonRemove.Location = new Point(98, 413);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(117, 54);
            buttonRemove.TabIndex = 12;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(38, 335);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 38);
            textBox2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(22, 292);
            label3.Name = "label3";
            label3.Size = new Size(93, 31);
            label3.TabIndex = 10;
            label3.Text = "User ID:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(38, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 38);
            textBox1.TabIndex = 9;
            // 
            // labelfname
            // 
            labelfname.AutoSize = true;
            labelfname.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelfname.ForeColor = SystemColors.ButtonHighlight;
            labelfname.Location = new Point(22, 70);
            labelfname.Name = "labelfname";
            labelfname.Size = new Size(181, 31);
            labelfname.TabIndex = 8;
            labelfname.Text = "User First Name:";
            // 
            // DGVUserInfo
            // 
            DGVUserInfo.AllowUserToAddRows = false;
            DGVUserInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(187, 233, 237);
            DGVUserInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGVUserInfo.BorderStyle = BorderStyle.None;
            DGVUserInfo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(48, 56, 79);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVUserInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGVUserInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVUserInfo.EnableHeadersVisualStyles = false;
            DGVUserInfo.Location = new Point(299, 91);
            DGVUserInfo.Name = "DGVUserInfo";
            DGVUserInfo.ReadOnly = true;
            DGVUserInfo.RowHeadersWidth = 51;
            DGVUserInfo.Size = new Size(423, 340);
            DGVUserInfo.TabIndex = 13;
            // 
            // labelLName
            // 
            labelLName.AutoSize = true;
            labelLName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLName.ForeColor = SystemColors.ButtonHighlight;
            labelLName.Location = new Point(22, 189);
            labelLName.Name = "labelLName";
            labelLName.Size = new Size(179, 31);
            labelLName.TabIndex = 14;
            labelLName.Text = "User Last Name:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(38, 223);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(212, 38);
            textBox3.TabIndex = 15;
            // 
            // RemoveUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            ClientSize = new Size(734, 539);
            Controls.Add(textBox3);
            Controls.Add(labelLName);
            Controls.Add(DGVUserInfo);
            Controls.Add(buttonRemove);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(labelfname);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RemoveUser";
            Text = "RemoveUser";
            ((System.ComponentModel.ISupportInitialize)DGVUserInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRemove;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label labelfname;
        private DataGridView DGVUserInfo;
        private Label labelLName;
        private TextBox textBox3;
    }
}