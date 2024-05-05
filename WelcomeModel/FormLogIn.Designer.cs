namespace TravelEase
{
    partial class FormLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            labelUsername = new Label();
            label3 = new Label();
            buttonClear = new Button();
            buttonLogin = new Button();
            checkBoxShowPassword = new CheckBox();
            buttonClose = new Button();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(381, 485);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(488, 64);
            label1.Name = "label1";
            label1.Size = new Size(118, 41);
            label1.TabIndex = 1;
            label1.Text = "LOG IN";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(400, 185);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(118, 31);
            labelUsername.TabIndex = 3;
            labelUsername.Text = "Usename:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(398, 257);
            label3.Name = "label3";
            label3.Size = new Size(120, 31);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClear.Location = new Point(488, 372);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(99, 44);
            buttonClear.TabIndex = 6;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.Location = new Point(640, 372);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(103, 44);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Location = new Point(685, 307);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(132, 24);
            checkBoxShowPassword.TabIndex = 8;
            checkBoxShowPassword.Text = "Show Password";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBox1_CheckedChanged;
            //checkBoxShowPassword.Click += checkBox1_Click;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
            buttonClose.Location = new Point(802, -2);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(47, 41);
            buttonClose.TabIndex = 9;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsername.Location = new Point(562, 185);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(255, 38);
            textBoxUsername.TabIndex = 10;
            //textBoxUsername.TextChanged += textBoxPassword_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(562, 254);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(255, 38);
            textBoxPassword.TabIndex = 11;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 485);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(buttonClose);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(buttonLogin);
            Controls.Add(buttonClear);
            Controls.Add(label3);
            Controls.Add(labelUsername);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            //Load += FormLogIn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label labelUsername;
        private Label label3;
        private Button buttonClear;
        private Button buttonLogin;
        private CheckBox checkBoxShowPassword;
        private Button buttonClose;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
    }
}