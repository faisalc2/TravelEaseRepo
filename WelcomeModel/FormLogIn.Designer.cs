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
            textBoxUserName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxPassword = new TextBox();
            buttonClear = new Button();
            buttonLogin = new Button();
            checkBox1 = new CheckBox();
            buttonClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(376, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(525, 82);
            label1.Name = "label1";
            label1.Size = new Size(153, 61);
            label1.TabIndex = 1;
            label1.Text = "LOG IN";
            // 
            // textBoxUserName
            // 
            textBoxUserName.BorderStyle = BorderStyle.None;
            textBoxUserName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUserName.Location = new Point(582, 191);
            textBoxUserName.Multiline = true;
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(206, 46);
            textBoxUserName.TabIndex = 2;
            textBoxUserName.Text = "asd";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(400, 185);
            label2.Name = "label2";
            label2.Size = new Size(189, 61);
            label2.TabIndex = 3;
            label2.Text = "Usename:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(392, 272);
            label3.Name = "label3";
            label3.Size = new Size(197, 61);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(582, 278);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(206, 39);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.Text = "asd";
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClear.Location = new Point(475, 372);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(99, 44);
            buttonClear.TabIndex = 6;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogin.Location = new Point(605, 372);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(103, 44);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "Log in";
            buttonLogin.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(667, 335);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(130, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Showpassword";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            checkBox1.Click += checkBox1_Click;
            // 
            // buttonClose
            // 
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.Image = (Image)resources.GetObject("buttonClose.Image");
            buttonClose.Location = new Point(756, 0);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(47, 41);
            buttonClose.TabIndex = 9;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClose);
            Controls.Add(checkBox1);
            Controls.Add(buttonLogin);
            Controls.Add(buttonClear);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxUserName);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBoxUserName;
        private Label label2;
        private Label label3;
        private TextBox textBoxPassword;
        private Button buttonClear;
        private Button buttonLogin;
        private CheckBox checkBox1;
        private Button buttonClose;
    }
}