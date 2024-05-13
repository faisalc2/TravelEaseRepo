namespace TravelEase.System_Admin
{
    partial class SystemAdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemAdminDashboard));
            panelSlidebar = new Panel();
            pictureBox1 = new PictureBox();
            buttonLogOut = new Button();
            buttonRestrict = new Button();
            buttonRemoveUser = new Button();
            buttonVehicleCom = new Button();
            panel1 = new Panel();
            buttonProfile = new Button();
            pictureBoxProfile = new PictureBox();
            buttonExit = new Button();
            panelMainSystem = new Panel();
            panelSlidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            SuspendLayout();
            // 
            // panelSlidebar
            // 
            panelSlidebar.BackColor = Color.FromArgb(48, 56, 79);
            panelSlidebar.Controls.Add(pictureBox1);
            panelSlidebar.Controls.Add(buttonLogOut);
            panelSlidebar.Controls.Add(buttonRestrict);
            panelSlidebar.Controls.Add(buttonRemoveUser);
            panelSlidebar.Controls.Add(buttonVehicleCom);
            panelSlidebar.Dock = DockStyle.Left;
            panelSlidebar.Location = new Point(0, 0);
            panelSlidebar.Name = "panelSlidebar";
            panelSlidebar.Size = new Size(226, 575);
            panelSlidebar.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.Silver;
            buttonLogOut.FlatAppearance.BorderSize = 0;
            buttonLogOut.FlatStyle = FlatStyle.Flat;
            buttonLogOut.Font = new Font("Segoe UI", 13.8F);
            buttonLogOut.ForeColor = SystemColors.ActiveCaptionText;
            buttonLogOut.Image = (Image)resources.GetObject("buttonLogOut.Image");
            buttonLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogOut.Location = new Point(0, 500);
            buttonLogOut.Margin = new Padding(0);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(226, 74);
            buttonLogOut.TabIndex = 17;
            buttonLogOut.Text = "Log Out";
            buttonLogOut.UseVisualStyleBackColor = false;
            // 
            // buttonRestrict
            // 
            buttonRestrict.BackColor = Color.FromArgb(48, 56, 79);
            buttonRestrict.FlatAppearance.BorderSize = 0;
            buttonRestrict.FlatStyle = FlatStyle.Flat;
            buttonRestrict.Font = new Font("Segoe UI", 13.8F);
            buttonRestrict.ForeColor = SystemColors.ButtonHighlight;
            buttonRestrict.Image = (Image)resources.GetObject("buttonRestrict.Image");
            buttonRestrict.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRestrict.Location = new Point(0, 337);
            buttonRestrict.Margin = new Padding(0);
            buttonRestrict.Name = "buttonRestrict";
            buttonRestrict.Size = new Size(223, 74);
            buttonRestrict.TabIndex = 11;
            buttonRestrict.Text = " Restrict Vehicle";
            buttonRestrict.TextAlign = ContentAlignment.MiddleRight;
            buttonRestrict.UseVisualStyleBackColor = false;
            buttonRestrict.Click += buttonRestrict_Click;
            // 
            // buttonRemoveUser
            // 
            buttonRemoveUser.BackColor = Color.FromArgb(48, 56, 79);
            buttonRemoveUser.FlatAppearance.BorderSize = 0;
            buttonRemoveUser.FlatStyle = FlatStyle.Flat;
            buttonRemoveUser.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRemoveUser.ForeColor = SystemColors.ButtonHighlight;
            buttonRemoveUser.Image = (Image)resources.GetObject("buttonRemoveUser.Image");
            buttonRemoveUser.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRemoveUser.Location = new Point(9, 263);
            buttonRemoveUser.Margin = new Padding(0);
            buttonRemoveUser.Name = "buttonRemoveUser";
            buttonRemoveUser.Size = new Size(214, 74);
            buttonRemoveUser.TabIndex = 10;
            buttonRemoveUser.Text = "Remove User";
            buttonRemoveUser.TextAlign = ContentAlignment.MiddleRight;
            buttonRemoveUser.UseVisualStyleBackColor = false;
            buttonRemoveUser.Click += buttonRemoveUser_Click;
            // 
            // buttonVehicleCom
            // 
            buttonVehicleCom.BackColor = Color.FromArgb(48, 56, 79);
            buttonVehicleCom.FlatAppearance.BorderSize = 0;
            buttonVehicleCom.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVehicleCom.ForeColor = SystemColors.ButtonHighlight;
            buttonVehicleCom.Location = new Point(9, 188);
            buttonVehicleCom.Margin = new Padding(0);
            buttonVehicleCom.Name = "buttonVehicleCom";
            buttonVehicleCom.Size = new Size(214, 74);
            buttonVehicleCom.TabIndex = 9;
            buttonVehicleCom.Text = "Vehicle Company";
            buttonVehicleCom.UseVisualStyleBackColor = false;
            buttonVehicleCom.Click += buttonVehicleCom_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 56, 79);
            panel1.Controls.Add(buttonProfile);
            panel1.Controls.Add(pictureBoxProfile);
            panel1.Controls.Add(buttonExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(226, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 36);
            panel1.TabIndex = 2;
            // 
            // buttonProfile
            // 
            buttonProfile.BackColor = Color.FromArgb(48, 56, 79);
            buttonProfile.Dock = DockStyle.Left;
            buttonProfile.FlatAppearance.BorderSize = 0;
            buttonProfile.FlatStyle = FlatStyle.Flat;
            buttonProfile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonProfile.ForeColor = SystemColors.ButtonHighlight;
            buttonProfile.Location = new Point(55, 0);
            buttonProfile.Name = "buttonProfile";
            buttonProfile.Size = new Size(82, 36);
            buttonProfile.TabIndex = 2;
            buttonProfile.Text = "Profile";
            buttonProfile.UseVisualStyleBackColor = false;
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.Dock = DockStyle.Left;
            pictureBoxProfile.Image = (Image)resources.GetObject("pictureBoxProfile.Image");
            pictureBoxProfile.Location = new Point(0, 0);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(55, 36);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProfile.TabIndex = 1;
            pictureBoxProfile.TabStop = false;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(48, 56, 79);
            buttonExit.Dock = DockStyle.Right;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Image = (Image)resources.GetObject("buttonExit.Image");
            buttonExit.Location = new Point(689, 0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(45, 36);
            buttonExit.TabIndex = 0;
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // panelMainSystem
            // 
            panelMainSystem.Dock = DockStyle.Fill;
            panelMainSystem.Location = new Point(226, 36);
            panelMainSystem.Name = "panelMainSystem";
            panelMainSystem.Size = new Size(734, 539);
            panelMainSystem.TabIndex = 3;
            // 
            // SystemAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 575);
            Controls.Add(panelMainSystem);
            Controls.Add(panel1);
            Controls.Add(panelSlidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SystemAdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SystemAdminDashboard";
            panelSlidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSlidebar;
        private PictureBox pictureBox1;
        private Button buttonLogOut;
        private Button buttonRestrict;
        private Button buttonRemoveUser;
        private Button buttonVehicleCom;
        private Panel panel1;
        private Button buttonProfile;
        private PictureBox pictureBoxProfile;
        private Button buttonExit;
        private Panel panelMainSystem;
    }
}