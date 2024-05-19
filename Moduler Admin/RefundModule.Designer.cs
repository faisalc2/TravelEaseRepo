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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DGVRefundInfo = new DataGridView();
            label2 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            buttonUpdateRule = new Button();
            textBoxNoR = new TextBox();
            textBox40 = new TextBox();
            textBox60 = new TextBox();
            textBox80 = new TextBox();
            label14 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVRefundInfo).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // DGVRefundInfo
            // 
            DGVRefundInfo.AllowUserToAddRows = false;
            DGVRefundInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(48, 56, 79);
            DGVRefundInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            DGVRefundInfo.BorderStyle = BorderStyle.None;
            DGVRefundInfo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(48, 56, 79);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DGVRefundInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DGVRefundInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVRefundInfo.EnableHeadersVisualStyles = false;
            DGVRefundInfo.Location = new Point(44, 54);
            DGVRefundInfo.Name = "DGVRefundInfo";
            DGVRefundInfo.ReadOnly = true;
            DGVRefundInfo.RowHeadersWidth = 51;
            DGVRefundInfo.Size = new Size(770, 169);
            DGVRefundInfo.TabIndex = 3;
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
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(buttonUpdateRule);
            panel2.Controls.Add(textBoxNoR);
            panel2.Controls.Add(textBox40);
            panel2.Controls.Add(textBox60);
            panel2.Controls.Add(textBox80);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(707, 81);
            label5.Name = "label5";
            label5.Size = new Size(37, 31);
            label5.TabIndex = 31;
            label5.Text = "hr";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(279, 188);
            label4.Name = "label4";
            label4.Size = new Size(37, 31);
            label4.TabIndex = 30;
            label4.Text = "hr";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(279, 134);
            label3.Name = "label3";
            label3.Size = new Size(37, 31);
            label3.TabIndex = 30;
            label3.Text = "hr";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(279, 77);
            label1.Name = "label1";
            label1.Size = new Size(37, 31);
            label1.TabIndex = 29;
            label1.Text = "hr";
            // 
            // buttonUpdateRule
            // 
            buttonUpdateRule.BackColor = Color.FromArgb(187, 233, 237);
            buttonUpdateRule.Cursor = Cursors.Hand;
            buttonUpdateRule.FlatStyle = FlatStyle.Popup;
            buttonUpdateRule.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdateRule.ForeColor = Color.Black;
            buttonUpdateRule.Location = new Point(463, 134);
            buttonUpdateRule.Margin = new Padding(0);
            buttonUpdateRule.Name = "buttonUpdateRule";
            buttonUpdateRule.Size = new Size(133, 70);
            buttonUpdateRule.TabIndex = 28;
            buttonUpdateRule.Text = "Update Information";
            buttonUpdateRule.UseVisualStyleBackColor = false;
            buttonUpdateRule.Click += buttonUpdateRule_Click;
            // 
            // textBoxNoR
            // 
            textBoxNoR.Location = new Point(567, 81);
            textBoxNoR.Name = "textBoxNoR";
            textBoxNoR.Size = new Size(121, 27);
            textBoxNoR.TabIndex = 27;
            // 
            // textBox40
            // 
            textBox40.Location = new Point(165, 188);
            textBox40.Name = "textBox40";
            textBox40.Size = new Size(108, 27);
            textBox40.TabIndex = 26;
            // 
            // textBox60
            // 
            textBox60.Location = new Point(165, 134);
            textBox60.Name = "textBox60";
            textBox60.Size = new Size(108, 27);
            textBox60.TabIndex = 25;
            // 
            // textBox80
            // 
            textBox80.Location = new Point(165, 77);
            textBox80.Name = "textBox80";
            textBox80.Size = new Size(108, 27);
            textBox80.TabIndex = 24;
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
            // RefundModule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            ClientSize = new Size(854, 538);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(DGVRefundInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RefundModule";
            Text = "CancelationModule";
            ((System.ComponentModel.ISupportInitialize)DGVRefundInfo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGVRefundInfo;
        private Label label2;
        private Panel panel2;
        private TextBox textBoxNoR;
        private TextBox textBox40;
        private TextBox textBox60;
        private TextBox textBox80;
        private Label label14;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button buttonUpdateRule;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}