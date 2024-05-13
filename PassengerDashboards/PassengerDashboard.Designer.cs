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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label = new Label();
            label7 = new Label();
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
            panelAccountInfo.Controls.Add(label7);
            panelAccountInfo.Controls.Add(label);
            panelAccountInfo.Controls.Add(label5);
            panelAccountInfo.Controls.Add(label4);
            panelAccountInfo.Controls.Add(label3);
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
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(109, 39);
            label1.Name = "label1";
            label1.Size = new Size(167, 31);
            label1.TabIndex = 0;
            label1.Text = "Passenger Info:";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 106);
            label3.Name = "label3";
            label3.Size = new Size(80, 31);
            label3.TabIndex = 4;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 162);
            label4.Name = "label4";
            label4.Size = new Size(150, 31);
            label4.TabIndex = 5;
            label4.Text = "Passenger ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 224);
            label5.Name = "label5";
            label5.Size = new Size(75, 31);
            label5.TabIndex = 6;
            label5.Text = "Email:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.Location = new Point(14, 290);
            label.Name = "label";
            label.Size = new Size(83, 31);
            label.TabIndex = 7;
            label.Text = "Phone:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(14, 359);
            label7.Name = "label7";
            label7.Size = new Size(58, 31);
            label7.TabIndex = 8;
            label7.Text = "NID:";
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Passenger Dashboard";
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
        private Label label7;
        private Label label;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}