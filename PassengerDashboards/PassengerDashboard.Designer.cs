namespace TravelEase.PassengerDashboards
{
    partial class PassengerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassengerDashboard));
            buttonSearchTicket = new Button();
            panelMain = new Panel();
            buttonProfile = new Button();
            pictureBoxProfile = new PictureBox();
            buttonExit = new Button();
            panel1 = new Panel();
            buttonLogOut = new Button();
            buttonCancelation = new Button();
            buttonHistory = new Button();
            buttonAccountDetails = new Button();
            panelSlidebar = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            panel1.SuspendLayout();
            panelSlidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonSearchTicket
            // 
            buttonSearchTicket.BackColor = Color.FromArgb(48, 56, 79);
            buttonSearchTicket.FlatAppearance.BorderSize = 0;
            buttonSearchTicket.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearchTicket.ForeColor = SystemColors.ButtonHighlight;
            buttonSearchTicket.Image = (Image)resources.GetObject("buttonSearchTicket.Image");
            buttonSearchTicket.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSearchTicket.Location = new Point(12, 189);
            buttonSearchTicket.Margin = new Padding(0);
            buttonSearchTicket.Name = "buttonSearchTicket";
            buttonSearchTicket.Size = new Size(241, 74);
            buttonSearchTicket.TabIndex = 9;
            buttonSearchTicket.Text = "            Search Ticket";
            buttonSearchTicket.UseVisualStyleBackColor = false;
            buttonSearchTicket.Click += buttonSearchTicket_Click_1;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(253, 36);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(725, 538);
            panelMain.TabIndex = 5;
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
            buttonExit.Location = new Point(680, 0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(45, 36);
            buttonExit.TabIndex = 0;
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 56, 79);
            panel1.Controls.Add(buttonProfile);
            panel1.Controls.Add(pictureBoxProfile);
            panel1.Controls.Add(buttonExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(253, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(725, 36);
            panel1.TabIndex = 4;
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
            buttonLogOut.Size = new Size(253, 74);
            buttonLogOut.TabIndex = 17;
            buttonLogOut.Text = "Log Out";
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
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
            buttonCancelation.Location = new Point(18, 411);
            buttonCancelation.Margin = new Padding(0);
            buttonCancelation.Name = "buttonCancelation";
            buttonCancelation.Size = new Size(217, 74);
            buttonCancelation.TabIndex = 12;
            buttonCancelation.Text = "      Cancelation";
            buttonCancelation.TextAlign = ContentAlignment.MiddleRight;
            buttonCancelation.UseVisualStyleBackColor = false;
            buttonCancelation.Click += buttonCancelation_Click;
            // 
            // buttonHistory
            // 
            buttonHistory.BackColor = Color.FromArgb(48, 56, 79);
            buttonHistory.FlatAppearance.BorderSize = 0;
            buttonHistory.FlatStyle = FlatStyle.Flat;
            buttonHistory.Font = new Font("Segoe UI", 13.8F);
            buttonHistory.ForeColor = SystemColors.ButtonHighlight;
            buttonHistory.Image = (Image)resources.GetObject("buttonHistory.Image");
            buttonHistory.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHistory.Location = new Point(25, 337);
            buttonHistory.Margin = new Padding(0);
            buttonHistory.Name = "buttonHistory";
            buttonHistory.Size = new Size(210, 74);
            buttonHistory.TabIndex = 11;
            buttonHistory.Text = "History";
            buttonHistory.TextAlign = ContentAlignment.MiddleRight;
            buttonHistory.UseVisualStyleBackColor = false;
            buttonHistory.Click += buttonHistory_Click;
            // 
            // buttonAccountDetails
            // 
            buttonAccountDetails.BackColor = Color.FromArgb(48, 56, 79);
            buttonAccountDetails.FlatAppearance.BorderSize = 0;
            buttonAccountDetails.FlatStyle = FlatStyle.Flat;
            buttonAccountDetails.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAccountDetails.ForeColor = SystemColors.ButtonHighlight;
            buttonAccountDetails.Image = (Image)resources.GetObject("buttonAccountDetails.Image");
            buttonAccountDetails.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAccountDetails.Location = new Point(9, 263);
            buttonAccountDetails.Margin = new Padding(0);
            buttonAccountDetails.Name = "buttonAccountDetails";
            buttonAccountDetails.Size = new Size(241, 74);
            buttonAccountDetails.TabIndex = 10;
            buttonAccountDetails.Text = "        Account Details";
            buttonAccountDetails.UseVisualStyleBackColor = false;
            buttonAccountDetails.Click += buttonAccountDetails_Click;
            // 
            // panelSlidebar
            // 
            panelSlidebar.BackColor = Color.FromArgb(48, 56, 79);
            panelSlidebar.Controls.Add(pictureBox1);
            panelSlidebar.Controls.Add(buttonLogOut);
            panelSlidebar.Controls.Add(buttonCancelation);
            panelSlidebar.Controls.Add(buttonHistory);
            panelSlidebar.Controls.Add(buttonAccountDetails);
            panelSlidebar.Controls.Add(buttonSearchTicket);
            panelSlidebar.Dock = DockStyle.Left;
            panelSlidebar.Location = new Point(0, 0);
            panelSlidebar.Name = "panelSlidebar";
            panelSlidebar.Size = new Size(253, 574);
            panelSlidebar.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // PassengerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 574);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Controls.Add(panelSlidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PassengerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Passenger Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            panel1.ResumeLayout(false);
            panelSlidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSearchTicket;
        private Panel panelMain;
        private Button buttonProfile;
        private PictureBox pictureBoxProfile;
        private Button buttonExit;
        private Panel panel1;
        private Button buttonLogOut;
        private Button buttonCancelation;
        private Button buttonHistory;
        private Button buttonAccountDetails;
        private Panel panelSlidebar;
        private PictureBox pictureBox1;
    }
}