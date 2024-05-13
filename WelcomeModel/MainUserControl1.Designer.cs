namespace TravelEase.Resources
{
    partial class MainUserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonNext = new Button();
            comboBox_Gender = new ComboBox();
            dateTimePicker_DOB = new DateTimePicker();
            textBox_Lname = new TextBox();
            textBox_Fname = new TextBox();
            textBox_NID = new TextBox();
            label_Gender = new Label();
            label_DOB = new Label();
            label_lname = new Label();
            label_fname = new Label();
            label_NID = new Label();
            SuspendLayout();
            // 
            // buttonNext
            // 
            buttonNext.BackColor = Color.FromArgb(187, 233, 237);
            buttonNext.Cursor = Cursors.Hand;
            buttonNext.FlatStyle = FlatStyle.Popup;
            buttonNext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonNext.ForeColor = Color.Black;
            buttonNext.Location = new Point(749, 396);
            buttonNext.Margin = new Padding(0);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(94, 38);
            buttonNext.TabIndex = 43;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = false;
            buttonNext.Click += buttonNext_Click;
            // 
            // comboBox_Gender
            // 
            comboBox_Gender.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox_Gender.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox_Gender.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox_Gender.FormattingEnabled = true;
            comboBox_Gender.Items.AddRange(new object[] { "Male", "Female" });
            comboBox_Gender.Location = new Point(473, 319);
            comboBox_Gender.Name = "comboBox_Gender";
            comboBox_Gender.Size = new Size(370, 36);
            comboBox_Gender.TabIndex = 42;
            // 
            // dateTimePicker_DOB
            // 
            dateTimePicker_DOB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker_DOB.Location = new Point(473, 248);
            dateTimePicker_DOB.Margin = new Padding(0);
            dateTimePicker_DOB.Name = "dateTimePicker_DOB";
            dateTimePicker_DOB.Size = new Size(370, 34);
            dateTimePicker_DOB.TabIndex = 41;
            // 
            // textBox_Lname
            // 
            textBox_Lname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_Lname.Location = new Point(473, 177);
            textBox_Lname.Name = "textBox_Lname";
            textBox_Lname.Size = new Size(370, 34);
            textBox_Lname.TabIndex = 40;
            // 
            // textBox_Fname
            // 
            textBox_Fname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_Fname.Location = new Point(473, 110);
            textBox_Fname.Name = "textBox_Fname";
            textBox_Fname.Size = new Size(370, 34);
            textBox_Fname.TabIndex = 39;
            // 
            // textBox_NID
            // 
            textBox_NID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_NID.Location = new Point(473, 47);
            textBox_NID.Name = "textBox_NID";
            textBox_NID.Size = new Size(370, 34);
            textBox_NID.TabIndex = 38;
            // 
            // label_Gender
            // 
            label_Gender.AutoSize = true;
            label_Gender.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Gender.ForeColor = Color.White;
            label_Gender.Location = new Point(224, 320);
            label_Gender.Name = "label_Gender";
            label_Gender.Size = new Size(98, 31);
            label_Gender.TabIndex = 37;
            label_Gender.Text = "Gender:";
            // 
            // label_DOB
            // 
            label_DOB.AutoSize = true;
            label_DOB.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_DOB.ForeColor = Color.White;
            label_DOB.Location = new Point(224, 248);
            label_DOB.Name = "label_DOB";
            label_DOB.Size = new Size(160, 31);
            label_DOB.TabIndex = 36;
            label_DOB.Text = "Date of Birth:";
            // 
            // label_lname
            // 
            label_lname.AutoSize = true;
            label_lname.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_lname.ForeColor = Color.White;
            label_lname.Location = new Point(224, 180);
            label_lname.Name = "label_lname";
            label_lname.Size = new Size(132, 31);
            label_lname.TabIndex = 35;
            label_lname.Text = "Last Name:";
            // 
            // label_fname
            // 
            label_fname.AutoSize = true;
            label_fname.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_fname.ForeColor = Color.White;
            label_fname.Location = new Point(224, 113);
            label_fname.Name = "label_fname";
            label_fname.Size = new Size(136, 31);
            label_fname.TabIndex = 34;
            label_fname.Text = "First Name:";
            // 
            // label_NID
            // 
            label_NID.AutoSize = true;
            label_NID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_NID.ForeColor = Color.White;
            label_NID.Location = new Point(224, 41);
            label_NID.Name = "label_NID";
            label_NID.Size = new Size(157, 31);
            label_NID.TabIndex = 33;
            label_NID.Text = "NID Number:";
            // 
            // MainUserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            Controls.Add(buttonNext);
            Controls.Add(comboBox_Gender);
            Controls.Add(dateTimePicker_DOB);
            Controls.Add(textBox_Lname);
            Controls.Add(textBox_Fname);
            Controls.Add(textBox_NID);
            Controls.Add(label_Gender);
            Controls.Add(label_DOB);
            Controls.Add(label_lname);
            Controls.Add(label_fname);
            Controls.Add(label_NID);
            Name = "MainUserControl1";
            Size = new Size(1100, 475);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonNext;
        private ComboBox comboBox_Gender;
        private DateTimePicker dateTimePicker_DOB;
        private TextBox textBox_Lname;
        private TextBox textBox_Fname;
        private TextBox textBox_NID;
        private Label label_Gender;
        private Label label_DOB;
        private Label label_lname;
        private Label label_fname;
        private Label label_NID;
    }
}
