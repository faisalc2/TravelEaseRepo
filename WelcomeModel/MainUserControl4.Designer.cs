namespace TravelEase.WelcomeModel
{
    partial class MainUserControl4
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
            button_Register = new Button();
            button_EditAC = new Button();
            button_EditCI = new Button();
            button_EditPI = new Button();
            label_AC = new Label();
            label_CI = new Label();
            label_PI = new Label();
            SuspendLayout();
            // 
            // button_Register
            // 
            button_Register.BackColor = Color.FromArgb(187, 233, 237);
            button_Register.Cursor = Cursors.Hand;
            button_Register.FlatStyle = FlatStyle.Popup;
            button_Register.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Register.ForeColor = Color.Black;
            button_Register.Location = new Point(911, 409);
            button_Register.Margin = new Padding(0);
            button_Register.Name = "button_Register";
            button_Register.Size = new Size(122, 39);
            button_Register.TabIndex = 16;
            button_Register.Text = "Register";
            button_Register.UseVisualStyleBackColor = false;
            button_Register.Click += button_Register_Click;
            // 
            // button_EditAC
            // 
            button_EditAC.BackColor = Color.FromArgb(187, 233, 237);
            button_EditAC.Cursor = Cursors.Hand;
            button_EditAC.FlatStyle = FlatStyle.Popup;
            button_EditAC.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_EditAC.ForeColor = Color.Black;
            button_EditAC.Location = new Point(811, 66);
            button_EditAC.Margin = new Padding(0);
            button_EditAC.Name = "button_EditAC";
            button_EditAC.Size = new Size(71, 30);
            button_EditAC.TabIndex = 15;
            button_EditAC.Text = "Edit";
            button_EditAC.UseVisualStyleBackColor = false;
            button_EditAC.Click += button_EditAC_Click;
            // 
            // button_EditCI
            // 
            button_EditCI.BackColor = Color.FromArgb(187, 233, 237);
            button_EditCI.Cursor = Cursors.Hand;
            button_EditCI.FlatStyle = FlatStyle.Popup;
            button_EditCI.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_EditCI.ForeColor = Color.Black;
            button_EditCI.Location = new Point(467, 66);
            button_EditCI.Margin = new Padding(0);
            button_EditCI.Name = "button_EditCI";
            button_EditCI.Size = new Size(71, 30);
            button_EditCI.TabIndex = 14;
            button_EditCI.Text = "Edit";
            button_EditCI.UseVisualStyleBackColor = false;
            button_EditCI.Click += button_EditCI_Click;
            // 
            // button_EditPI
            // 
            button_EditPI.BackColor = Color.FromArgb(187, 233, 237);
            button_EditPI.Cursor = Cursors.Hand;
            button_EditPI.FlatStyle = FlatStyle.Popup;
            button_EditPI.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_EditPI.ForeColor = Color.Black;
            button_EditPI.Location = new Point(146, 66);
            button_EditPI.Margin = new Padding(0);
            button_EditPI.Name = "button_EditPI";
            button_EditPI.Size = new Size(71, 30);
            button_EditPI.TabIndex = 13;
            button_EditPI.Text = "Edit";
            button_EditPI.UseVisualStyleBackColor = false;
            button_EditPI.Click += button_EditPI_Click;
            // 
            // label_AC
            // 
            label_AC.AutoSize = true;
            label_AC.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_AC.ForeColor = Color.White;
            label_AC.Location = new Point(736, 26);
            label_AC.Name = "label_AC";
            label_AC.Size = new Size(229, 31);
            label_AC.TabIndex = 12;
            label_AC.Text = "Account Credentials";
            // 
            // label_CI
            // 
            label_CI.AutoSize = true;
            label_CI.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_CI.ForeColor = Color.White;
            label_CI.Location = new Point(387, 26);
            label_CI.Name = "label_CI";
            label_CI.Size = new Size(242, 31);
            label_CI.TabIndex = 11;
            label_CI.Text = "Contract Information";
            // 
            // label_PI
            // 
            label_PI.AutoSize = true;
            label_PI.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_PI.ForeColor = Color.White;
            label_PI.Location = new Point(68, 26);
            label_PI.Name = "label_PI";
            label_PI.Size = new Size(241, 31);
            label_PI.TabIndex = 10;
            label_PI.Text = "Personal Information";
            // 
            // MainUserControl4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            Controls.Add(button_Register);
            Controls.Add(button_EditAC);
            Controls.Add(button_EditCI);
            Controls.Add(button_EditPI);
            Controls.Add(label_AC);
            Controls.Add(label_CI);
            Controls.Add(label_PI);
            Name = "MainUserControl4";
            Size = new Size(1100, 475);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Register;
        private Button button_EditAC;
        private Button button_EditCI;
        private Button button_EditPI;
        private Label label_AC;
        private Label label_CI;
        private Label label_PI;
    }
}
