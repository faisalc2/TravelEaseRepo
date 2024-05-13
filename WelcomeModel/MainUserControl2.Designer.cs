namespace TravelEase.WelcomeModel
{
    partial class MainUserControl2
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
            textBox_Address = new TextBox();
            textBox_Email = new TextBox();
            textBox_Phone = new TextBox();
            label_Address = new Label();
            label_Email = new Label();
            label_Phone = new Label();
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
            buttonNext.TabIndex = 54;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = false;
            buttonNext.Click += buttonNext_Click;
            // 
            // textBox_Address
            // 
            textBox_Address.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_Address.Location = new Point(473, 259);
            textBox_Address.Multiline = true;
            textBox_Address.Name = "textBox_Address";
            textBox_Address.Size = new Size(370, 100);
            textBox_Address.TabIndex = 60;
            // 
            // textBox_Email
            // 
            textBox_Email.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_Email.Location = new Point(473, 192);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(370, 34);
            textBox_Email.TabIndex = 59;
            // 
            // textBox_Phone
            // 
            textBox_Phone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_Phone.Location = new Point(473, 129);
            textBox_Phone.Name = "textBox_Phone";
            textBox_Phone.Size = new Size(370, 34);
            textBox_Phone.TabIndex = 58;
            // 
            // label_Address
            // 
            label_Address.AutoSize = true;
            label_Address.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Address.ForeColor = Color.White;
            label_Address.Location = new Point(224, 262);
            label_Address.Name = "label_Address";
            label_Address.Size = new Size(105, 31);
            label_Address.TabIndex = 57;
            label_Address.Text = "Address:";
            // 
            // label_Email
            // 
            label_Email.AutoSize = true;
            label_Email.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Email.ForeColor = Color.White;
            label_Email.Location = new Point(224, 195);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(79, 31);
            label_Email.TabIndex = 56;
            label_Email.Text = "Email:";
            // 
            // label_Phone
            // 
            label_Phone.AutoSize = true;
            label_Phone.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Phone.ForeColor = Color.White;
            label_Phone.Location = new Point(224, 123);
            label_Phone.Name = "label_Phone";
            label_Phone.Size = new Size(88, 31);
            label_Phone.TabIndex = 55;
            label_Phone.Text = "Phone:";
            // 
            // MainUserControl2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            Controls.Add(textBox_Address);
            Controls.Add(textBox_Email);
            Controls.Add(textBox_Phone);
            Controls.Add(label_Address);
            Controls.Add(label_Email);
            Controls.Add(label_Phone);
            Controls.Add(buttonNext);
            Name = "MainUserControl2";
            Size = new Size(1100, 475);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonNext;
        private ComboBox comboBox_Gender;
        private DateTimePicker dateTimePicker_DOB;
        private TextBox textBox_Address;
        private TextBox textBox_Email;
        private TextBox textBox_Phone;
        private Label label_Gender;
        private Label label_DOB;
        private Label label_Address;
        private Label label_Email;
        private Label label_Phone;
    }
}
