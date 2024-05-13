namespace TravelEase.WelcomeModel
{
    partial class MainUserControl3
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
            textBox_Password1 = new TextBox();
            textBox_Username = new TextBox();
            label_Password2 = new Label();
            label_Password1 = new Label();
            label_Username = new Label();
            textBox_Password2 = new TextBox();
            checkBox_ShowPassword = new CheckBox();
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
            buttonNext.TabIndex = 61;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = false;
            buttonNext.Click += buttonNext_Click;
            // 
            // textBox_Password1
            // 
            textBox_Password1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_Password1.Location = new Point(473, 197);
            textBox_Password1.Name = "textBox_Password1";
            textBox_Password1.Size = new Size(370, 34);
            textBox_Password1.TabIndex = 59;
            textBox_Password1.UseSystemPasswordChar = true;
            // 
            // textBox_Username
            // 
            textBox_Username.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_Username.Location = new Point(473, 129);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(370, 34);
            textBox_Username.TabIndex = 58;
            // 
            // label_Password2
            // 
            label_Password2.AutoSize = true;
            label_Password2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Password2.ForeColor = Color.White;
            label_Password2.Location = new Point(224, 262);
            label_Password2.Name = "label_Password2";
            label_Password2.Size = new Size(200, 31);
            label_Password2.TabIndex = 57;
            label_Password2.Text = "Retype password:";
            // 
            // label_Password1
            // 
            label_Password1.AutoSize = true;
            label_Password1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Password1.ForeColor = Color.White;
            label_Password1.Location = new Point(224, 195);
            label_Password1.Name = "label_Password1";
            label_Password1.Size = new Size(120, 31);
            label_Password1.TabIndex = 56;
            label_Password1.Text = "Password:";
            // 
            // label_Username
            // 
            label_Username.AutoSize = true;
            label_Username.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Username.ForeColor = Color.White;
            label_Username.Location = new Point(224, 123);
            label_Username.Name = "label_Username";
            label_Username.Size = new Size(127, 31);
            label_Username.TabIndex = 55;
            label_Username.Text = "Username:";
            // 
            // textBox_Password2
            // 
            textBox_Password2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_Password2.Location = new Point(473, 266);
            textBox_Password2.Name = "textBox_Password2";
            textBox_Password2.Size = new Size(370, 34);
            textBox_Password2.TabIndex = 62;
            textBox_Password2.UseSystemPasswordChar = true;
            // 
            // checkBox_ShowPassword
            // 
            checkBox_ShowPassword.AutoSize = true;
            checkBox_ShowPassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox_ShowPassword.ForeColor = Color.White;
            checkBox_ShowPassword.Location = new Point(692, 327);
            checkBox_ShowPassword.Name = "checkBox_ShowPassword";
            checkBox_ShowPassword.Size = new Size(151, 27);
            checkBox_ShowPassword.TabIndex = 63;
            checkBox_ShowPassword.Text = "Show Password";
            checkBox_ShowPassword.UseVisualStyleBackColor = true;
            checkBox_ShowPassword.CheckedChanged += checkBox_ShowPassword_CheckedChanged;
            // 
            // MainUserControl3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            Controls.Add(checkBox_ShowPassword);
            Controls.Add(textBox_Password2);
            Controls.Add(buttonNext);
            Controls.Add(textBox_Password1);
            Controls.Add(textBox_Username);
            Controls.Add(label_Password2);
            Controls.Add(label_Password1);
            Controls.Add(label_Username);
            Name = "MainUserControl3";
            Size = new Size(1100, 475);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonNext;
        private TextBox textBox_Password1;
        private TextBox textBox_Username;
        private Label label_Password2;
        private Label label_Password1;
        private Label label_Username;
        private TextBox textBox_Password2;
        private CheckBox checkBox_ShowPassword;
    }
}
