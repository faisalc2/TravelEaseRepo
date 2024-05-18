namespace TravelEase.Moduler_Admin
{
    partial class NewModuler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewModuler));
            panelMain = new Panel();
            buttonExit = new Button();
            pictureBoxProfile = new PictureBox();
            buttonProfile = new Button();
            panel1 = new Panel();
            buttonVehicle = new Button();
            buttonTrip = new Button();
            buttonRefundModAdmin = new Button();
            buttonCancelation = new Button();
            buttonLogOut = new Button();
            panelSlidebar = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            panel1.SuspendLayout();
            panelSlidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(226, 36);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(854, 538);
            panelMain.TabIndex = 2;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(48, 56, 79);
            buttonExit.Dock = DockStyle.Right;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Image = (Image)resources.GetObject("buttonExit.Image");
            buttonExit.Location = new Point(809, 0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(45, 36);
            buttonExit.TabIndex = 0;
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
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
            pictureBoxProfile.Click += pictureBoxProfile_Click;
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
            buttonProfile.Click += buttonProfile_Click;
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
            panel1.Size = new Size(854, 36);
            panel1.TabIndex = 1;
            // 
            // buttonVehicle
            // 
            buttonVehicle.BackColor = Color.FromArgb(48, 56, 79);
            buttonVehicle.FlatAppearance.BorderSize = 0;
            buttonVehicle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVehicle.ForeColor = SystemColors.ButtonHighlight;
            buttonVehicle.Location = new Point(9, 188);
            buttonVehicle.Margin = new Padding(0);
            buttonVehicle.Name = "buttonVehicle";
            buttonVehicle.Size = new Size(214, 74);
            buttonVehicle.TabIndex = 9;
            buttonVehicle.Text = "Vehicle";
            buttonVehicle.UseVisualStyleBackColor = false;
            buttonVehicle.Click += buttonVehicle_Click;
            // 
            // buttonTrip
            // 
            buttonTrip.BackColor = Color.FromArgb(48, 56, 79);
            buttonTrip.FlatAppearance.BorderSize = 0;
            buttonTrip.FlatStyle = FlatStyle.Flat;
            buttonTrip.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonTrip.ForeColor = SystemColors.ButtonHighlight;
            buttonTrip.Image = (Image)resources.GetObject("buttonTrip.Image");
            buttonTrip.ImageAlign = ContentAlignment.MiddleLeft;
            buttonTrip.Location = new Point(9, 263);
            buttonTrip.Margin = new Padding(0);
            buttonTrip.Name = "buttonTrip";
            buttonTrip.Size = new Size(214, 74);
            buttonTrip.TabIndex = 10;
            buttonTrip.Text = "Trip";
            buttonTrip.UseVisualStyleBackColor = false;
            buttonTrip.Click += buttonTrip_Click;
            // 
            // buttonRefundModAdmin
            // 
            buttonRefundModAdmin.BackColor = Color.FromArgb(48, 56, 79);
            buttonRefundModAdmin.FlatAppearance.BorderSize = 0;
            buttonRefundModAdmin.FlatStyle = FlatStyle.Flat;
            buttonRefundModAdmin.Font = new Font("Segoe UI", 13.8F);
            buttonRefundModAdmin.ForeColor = SystemColors.ButtonHighlight;
            buttonRefundModAdmin.Image = (Image)resources.GetObject("buttonRefundModAdmin.Image");
            buttonRefundModAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRefundModAdmin.Location = new Point(9, 337);
            buttonRefundModAdmin.Margin = new Padding(0);
            buttonRefundModAdmin.Name = "buttonRefundModAdmin";
            buttonRefundModAdmin.Size = new Size(214, 74);
            buttonRefundModAdmin.TabIndex = 11;
            buttonRefundModAdmin.Text = "Refund Rule";
            buttonRefundModAdmin.TextAlign = ContentAlignment.MiddleRight;
            buttonRefundModAdmin.UseVisualStyleBackColor = false;
            buttonRefundModAdmin.Click += buttonRefundAdmin_Click;
            // 
            // buttonCancelation
            // 
            buttonCancelation.BackColor = Color.FromArgb(48, 56, 79);
            buttonCancelation.FlatAppearance.BorderSize = 0;
            buttonCancelation.FlatStyle = FlatStyle.Flat;
            buttonCancelation.Font = new Font("Segoe UI", 13.8F);
            buttonCancelation.ForeColor = SystemColors.ButtonHighlight;
            buttonCancelation.Image = (Image)resources.GetObject("buttonCancelation.Image");
            buttonCancelation.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancelation.Location = new Point(9, 411);
            buttonCancelation.Margin = new Padding(0);
            buttonCancelation.Name = "buttonCancelation";
            buttonCancelation.Size = new Size(214, 74);
            buttonCancelation.TabIndex = 12;
            buttonCancelation.Text = "Cancelation";
            buttonCancelation.TextAlign = ContentAlignment.MiddleRight;
            buttonCancelation.UseVisualStyleBackColor = false;
            buttonCancelation.Click += buttonCancelation_Click;
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
            // panelSlidebar
            // 
            panelSlidebar.BackColor = Color.FromArgb(48, 56, 79);
            panelSlidebar.Controls.Add(pictureBox1);
            panelSlidebar.Controls.Add(buttonLogOut);
            panelSlidebar.Controls.Add(buttonCancelation);
            panelSlidebar.Controls.Add(buttonRefundModAdmin);
            panelSlidebar.Controls.Add(buttonTrip);
            panelSlidebar.Controls.Add(buttonVehicle);
            panelSlidebar.Dock = DockStyle.Left;
            panelSlidebar.Location = new Point(0, 0);
            panelSlidebar.Name = "panelSlidebar";
            panelSlidebar.Size = new Size(226, 574);
            panelSlidebar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // NewModuler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 574);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Controls.Add(panelSlidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewModuler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewModuler";
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            panel1.ResumeLayout(false);
            panelSlidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMain;
        private Button buttonExit;
        private PictureBox pictureBoxProfile;
        private Button buttonProfile;
        private Panel panel1;
        private Button buttonVehicle;
        private Button buttonTrip;
        private Button buttonRefundModAdmin;
        private Button buttonCancelation;
        private Button buttonLogOut;
        private Panel panelSlidebar;
        private PictureBox pictureBox1;
    }
}