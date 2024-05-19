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
            textBoxUID = new TextBox();
            label3 = new Label();
            textBoxFname = new TextBox();
            labelfname = new Label();
            DGVUserInfo = new DataGridView();
            labelLName = new Label();
            textBoxLname = new TextBox();
            textBoxSearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGVUserInfo).BeginInit();
            SuspendLayout();
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.FromArgb(187, 233, 237);
            buttonRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRemove.ForeColor = SystemColors.ActiveCaptionText;
            buttonRemove.Location = new Point(110, 461);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(117, 54);
            buttonRemove.TabIndex = 12;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // textBoxUID
            // 
            textBoxUID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUID.Location = new Point(50, 383);
            textBoxUID.Name = "textBoxUID";
            textBoxUID.ReadOnly = true;
            textBoxUID.Size = new Size(212, 38);
            textBoxUID.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(34, 340);
            label3.Name = "label3";
            label3.Size = new Size(93, 31);
            label3.TabIndex = 10;
            label3.Text = "User ID:";
            // 
            // textBoxFname
            // 
            textBoxFname.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFname.Location = new Point(50, 165);
            textBoxFname.Name = "textBoxFname";
            textBoxFname.ReadOnly = true;
            textBoxFname.Size = new Size(212, 38);
            textBoxFname.TabIndex = 9;
            // 
            // labelfname
            // 
            labelfname.AutoSize = true;
            labelfname.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelfname.ForeColor = SystemColors.ButtonHighlight;
            labelfname.Location = new Point(34, 118);
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
            DGVUserInfo.Location = new Point(299, 117);
            DGVUserInfo.Name = "DGVUserInfo";
            DGVUserInfo.ReadOnly = true;
            DGVUserInfo.RowHeadersWidth = 51;
            DGVUserInfo.Size = new Size(423, 340);
            DGVUserInfo.TabIndex = 13;
            DGVUserInfo.CellContentClick += DGVUserInfo_CellContentClick;
            // 
            // labelLName
            // 
            labelLName.AutoSize = true;
            labelLName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLName.ForeColor = SystemColors.ButtonHighlight;
            labelLName.Location = new Point(34, 237);
            labelLName.Name = "labelLName";
            labelLName.Size = new Size(179, 31);
            labelLName.TabIndex = 14;
            labelLName.Text = "User Last Name:";
            // 
            // textBoxLname
            // 
            textBoxLname.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLname.Location = new Point(50, 271);
            textBoxLname.Name = "textBoxLname";
            textBoxLname.ReadOnly = true;
            textBoxLname.Size = new Size(212, 38);
            textBoxLname.TabIndex = 15;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(457, 44);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(212, 38);
            textBoxSearch.TabIndex = 16;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(414, 9);
            label1.Name = "label1";
            label1.Size = new Size(289, 31);
            label1.TabIndex = 17;
            label1.Text = "User First Name for Search:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(20, 27);
            label2.Name = "label2";
            label2.Size = new Size(195, 31);
            label2.TabIndex = 19;
            label2.Text = "Selected user is a:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(50, 61);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(212, 38);
            textBox1.TabIndex = 20;
            // 
            // RemoveUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            ClientSize = new Size(734, 539);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSearch);
            Controls.Add(textBoxLname);
            Controls.Add(labelLName);
            Controls.Add(DGVUserInfo);
            Controls.Add(buttonRemove);
            Controls.Add(textBoxUID);
            Controls.Add(label3);
            Controls.Add(textBoxFname);
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
        private TextBox textBoxUID;
        private Label label3;
        private TextBox textBoxFname;
        private Label labelfname;
        private DataGridView DGVUserInfo;
        private Label labelLName;
        private TextBox textBoxLname;
        private TextBox textBoxSearch;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
    }
}