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
            label2 = new Label();
            DGVPassengerInfo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGVPassengerInfo).BeginInit();
            SuspendLayout();
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.FromArgb(187, 233, 237);
            buttonRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRemove.ForeColor = SystemColors.ActiveCaptionText;
            buttonRemove.Location = new Point(110, 316);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(117, 54);
            buttonRemove.TabIndex = 12;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(47, 236);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 38);
            textBox2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(37, 191);
            label3.Name = "label3";
            label3.Size = new Size(93, 31);
            label3.TabIndex = 10;
            label3.Text = "User ID:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(47, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 38);
            textBox1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(37, 72);
            label2.Name = "label2";
            label2.Size = new Size(132, 31);
            label2.TabIndex = 8;
            label2.Text = "User Name:";
            // 
            // DGVPassengerInfo
            // 
            DGVPassengerInfo.AllowUserToAddRows = false;
            DGVPassengerInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(48, 56, 79);
            DGVPassengerInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGVPassengerInfo.BorderStyle = BorderStyle.None;
            DGVPassengerInfo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(48, 56, 79);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVPassengerInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGVPassengerInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVPassengerInfo.EnableHeadersVisualStyles = false;
            DGVPassengerInfo.Location = new Point(299, 91);
            DGVPassengerInfo.Name = "DGVPassengerInfo";
            DGVPassengerInfo.ReadOnly = true;
            DGVPassengerInfo.RowHeadersWidth = 51;
            DGVPassengerInfo.Size = new Size(423, 340);
            DGVPassengerInfo.TabIndex = 13;
            // 
            // RemoveUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            ClientSize = new Size(734, 539);
            Controls.Add(DGVPassengerInfo);
            Controls.Add(buttonRemove);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RemoveUser";
            Text = "RemoveUser";
            ((System.ComponentModel.ISupportInitialize)DGVPassengerInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRemove;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private DataGridView DGVPassengerInfo;
    }
}