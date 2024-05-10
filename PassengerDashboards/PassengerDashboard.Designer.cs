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
            buttonSearchTicket = new Button();
            panelAccountInfo = new Panel();
            buttonEditProfile = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panelAccountInfo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSearchTicket
            // 
            buttonSearchTicket.Location = new Point(588, 385);
            buttonSearchTicket.Name = "buttonSearchTicket";
            buttonSearchTicket.Size = new Size(212, 81);
            buttonSearchTicket.TabIndex = 0;
            buttonSearchTicket.Text = "Search New Ticket";
            buttonSearchTicket.UseVisualStyleBackColor = true;
            buttonSearchTicket.Click += buttonSearchTicket_Click;
            // 
            // panelAccountInfo
            // 
            panelAccountInfo.Controls.Add(buttonEditProfile);
            panelAccountInfo.Controls.Add(label1);
            panelAccountInfo.Location = new Point(12, 12);
            panelAccountInfo.Name = "panelAccountInfo";
            panelAccountInfo.Size = new Size(390, 550);
            panelAccountInfo.TabIndex = 1;
            // 
            // buttonEditProfile
            // 
            buttonEditProfile.Location = new Point(109, 452);
            buttonEditProfile.Name = "buttonEditProfile";
            buttonEditProfile.Size = new Size(212, 81);
            buttonEditProfile.TabIndex = 3;
            buttonEditProfile.Text = "Edit Profile";
            buttonEditProfile.UseVisualStyleBackColor = true;
            buttonEditProfile.Click += buttonEditProfile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 69);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Passenger Info";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Location = new Point(408, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 255);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 117);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "History";
            // 
            // PassengerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 574);
            Controls.Add(panel1);
            Controls.Add(panelAccountInfo);
            Controls.Add(buttonSearchTicket);
            Name = "PassengerDashboard";
            Text = "PassengerDashboard";
            panelAccountInfo.ResumeLayout(false);
            panelAccountInfo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSearchTicket;
        private Panel panelAccountInfo;
        private Label label1;
        private Button buttonEditProfile;
        private Panel panel1;
        private Label label2;
    }
}