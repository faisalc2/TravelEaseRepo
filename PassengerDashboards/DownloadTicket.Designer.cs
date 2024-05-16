namespace TravelEase.PassengerDashboards
{
    partial class DownloadTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadTicket));
            pictureBox1 = new PictureBox();
            labelTicketID = new Label();
            labelUserID = new Label();
            labelVehicleID = new Label();
            labelVehicleClass = new Label();
            labelJourneyDate = new Label();
            labelSeatAmount = new Label();
            labelPaidAmount = new Label();
            labelSeatNumbers = new Label();
            buttonDownload = new Button();
            buttonReturn = new Button();
            buttonExit = new PictureBox();
            textBoxTicketID = new TextBox();
            textBoxUserID = new TextBox();
            textBoxVehicleID = new TextBox();
            textBoxVehicleClass = new TextBox();
            textBoxJourneyDate = new TextBox();
            textBoxSeatAmount = new TextBox();
            textBoxSeatNumbers = new TextBox();
            textBoxPaidAmount = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonExit).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelTicketID
            // 
            labelTicketID.AutoSize = true;
            labelTicketID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTicketID.ForeColor = Color.White;
            labelTicketID.Location = new Point(74, 86);
            labelTicketID.Name = "labelTicketID";
            labelTicketID.Size = new Size(87, 23);
            labelTicketID.TabIndex = 1;
            labelTicketID.Text = "Ticket ID:";
            // 
            // labelUserID
            // 
            labelUserID.AutoSize = true;
            labelUserID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserID.ForeColor = Color.White;
            labelUserID.Location = new Point(74, 154);
            labelUserID.Name = "labelUserID";
            labelUserID.Size = new Size(73, 23);
            labelUserID.TabIndex = 2;
            labelUserID.Text = "User ID:";
            // 
            // labelVehicleID
            // 
            labelVehicleID.AutoSize = true;
            labelVehicleID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVehicleID.ForeColor = Color.White;
            labelVehicleID.Location = new Point(74, 223);
            labelVehicleID.Name = "labelVehicleID";
            labelVehicleID.Size = new Size(94, 23);
            labelVehicleID.TabIndex = 3;
            labelVehicleID.Text = "Vehicle ID:";
            // 
            // labelVehicleClass
            // 
            labelVehicleClass.AutoSize = true;
            labelVehicleClass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVehicleClass.ForeColor = Color.White;
            labelVehicleClass.Location = new Point(74, 290);
            labelVehicleClass.Name = "labelVehicleClass";
            labelVehicleClass.Size = new Size(115, 23);
            labelVehicleClass.TabIndex = 4;
            labelVehicleClass.Text = "Vehicle Class:";
            // 
            // labelJourneyDate
            // 
            labelJourneyDate.AutoSize = true;
            labelJourneyDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJourneyDate.ForeColor = Color.White;
            labelJourneyDate.Location = new Point(74, 362);
            labelJourneyDate.Name = "labelJourneyDate";
            labelJourneyDate.Size = new Size(121, 23);
            labelJourneyDate.TabIndex = 5;
            labelJourneyDate.Text = "Journey Date:";
            // 
            // labelSeatAmount
            // 
            labelSeatAmount.AutoSize = true;
            labelSeatAmount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSeatAmount.ForeColor = Color.White;
            labelSeatAmount.Location = new Point(459, 82);
            labelSeatAmount.Name = "labelSeatAmount";
            labelSeatAmount.Size = new Size(120, 23);
            labelSeatAmount.TabIndex = 6;
            labelSeatAmount.Text = "Seat Amount:";
            // 
            // labelPaidAmount
            // 
            labelPaidAmount.AutoSize = true;
            labelPaidAmount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPaidAmount.ForeColor = Color.White;
            labelPaidAmount.Location = new Point(459, 290);
            labelPaidAmount.Name = "labelPaidAmount";
            labelPaidAmount.Size = new Size(120, 23);
            labelPaidAmount.TabIndex = 8;
            labelPaidAmount.Text = "Paid Amount:";
            // 
            // labelSeatNumbers
            // 
            labelSeatNumbers.AutoSize = true;
            labelSeatNumbers.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSeatNumbers.ForeColor = Color.White;
            labelSeatNumbers.Location = new Point(459, 150);
            labelSeatNumbers.Name = "labelSeatNumbers";
            labelSeatNumbers.Size = new Size(128, 23);
            labelSeatNumbers.TabIndex = 9;
            labelSeatNumbers.Text = "Seat Numbers:";
            // 
            // buttonDownload
            // 
            buttonDownload.BackColor = Color.FromArgb(187, 233, 237);
            buttonDownload.Cursor = Cursors.Hand;
            buttonDownload.FlatStyle = FlatStyle.Popup;
            buttonDownload.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDownload.ForeColor = Color.Black;
            buttonDownload.Location = new Point(698, 434);
            buttonDownload.Margin = new Padding(0);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(109, 30);
            buttonDownload.TabIndex = 10;
            buttonDownload.Text = "Download";
            buttonDownload.UseVisualStyleBackColor = false;
            buttonDownload.Click += buttonDownload_Click;
            // 
            // buttonReturn
            // 
            buttonReturn.BackColor = Color.FromArgb(187, 233, 237);
            buttonReturn.Cursor = Cursors.Hand;
            buttonReturn.FlatStyle = FlatStyle.Popup;
            buttonReturn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReturn.ForeColor = Color.Black;
            buttonReturn.Location = new Point(533, 434);
            buttonReturn.Margin = new Padding(0);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(106, 30);
            buttonReturn.TabIndex = 11;
            buttonReturn.Text = "Return";
            buttonReturn.UseVisualStyleBackColor = false;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // buttonExit
            // 
            buttonExit.Cursor = Cursors.Hand;
            buttonExit.Image = (Image)resources.GetObject("buttonExit.Image");
            buttonExit.Location = new Point(830, -1);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(44, 38);
            buttonExit.SizeMode = PictureBoxSizeMode.Zoom;
            buttonExit.TabIndex = 12;
            buttonExit.TabStop = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // textBoxTicketID
            // 
            textBoxTicketID.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxTicketID.Location = new Point(196, 86);
            textBoxTicketID.Name = "textBoxTicketID";
            textBoxTicketID.Size = new Size(190, 27);
            textBoxTicketID.TabIndex = 13;
            // 
            // textBoxUserID
            // 
            textBoxUserID.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxUserID.Location = new Point(196, 150);
            textBoxUserID.Name = "textBoxUserID";
            textBoxUserID.Size = new Size(190, 27);
            textBoxUserID.TabIndex = 14;
            // 
            // textBoxVehicleID
            // 
            textBoxVehicleID.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxVehicleID.Location = new Point(196, 223);
            textBoxVehicleID.Name = "textBoxVehicleID";
            textBoxVehicleID.Size = new Size(190, 27);
            textBoxVehicleID.TabIndex = 15;
            // 
            // textBoxVehicleClass
            // 
            textBoxVehicleClass.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxVehicleClass.Location = new Point(196, 291);
            textBoxVehicleClass.Name = "textBoxVehicleClass";
            textBoxVehicleClass.Size = new Size(190, 27);
            textBoxVehicleClass.TabIndex = 16;
            // 
            // textBoxJourneyDate
            // 
            textBoxJourneyDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxJourneyDate.Location = new Point(196, 362);
            textBoxJourneyDate.Name = "textBoxJourneyDate";
            textBoxJourneyDate.Size = new Size(190, 27);
            textBoxJourneyDate.TabIndex = 17;
            // 
            // textBoxSeatAmount
            // 
            textBoxSeatAmount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxSeatAmount.Location = new Point(606, 82);
            textBoxSeatAmount.Name = "textBoxSeatAmount";
            textBoxSeatAmount.Size = new Size(190, 27);
            textBoxSeatAmount.TabIndex = 18;
            // 
            // textBoxSeatNumbers
            // 
            textBoxSeatNumbers.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxSeatNumbers.Location = new Point(606, 150);
            textBoxSeatNumbers.Multiline = true;
            textBoxSeatNumbers.Name = "textBoxSeatNumbers";
            textBoxSeatNumbers.Size = new Size(190, 97);
            textBoxSeatNumbers.TabIndex = 19;
            // 
            // textBoxPaidAmount
            // 
            textBoxPaidAmount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPaidAmount.Location = new Point(606, 290);
            textBoxPaidAmount.Name = "textBoxPaidAmount";
            textBoxPaidAmount.Size = new Size(190, 27);
            textBoxPaidAmount.TabIndex = 20;
            // 
            // DownloadTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            ClientSize = new Size(872, 487);
            Controls.Add(textBoxPaidAmount);
            Controls.Add(textBoxSeatNumbers);
            Controls.Add(textBoxSeatAmount);
            Controls.Add(textBoxJourneyDate);
            Controls.Add(textBoxVehicleClass);
            Controls.Add(textBoxVehicleID);
            Controls.Add(textBoxUserID);
            Controls.Add(textBoxTicketID);
            Controls.Add(buttonExit);
            Controls.Add(buttonReturn);
            Controls.Add(buttonDownload);
            Controls.Add(labelSeatNumbers);
            Controls.Add(labelPaidAmount);
            Controls.Add(labelSeatAmount);
            Controls.Add(labelJourneyDate);
            Controls.Add(labelVehicleClass);
            Controls.Add(labelVehicleID);
            Controls.Add(labelUserID);
            Controls.Add(labelTicketID);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DownloadTicket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DownloadTicket";
            Load += DownloadTicket_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonExit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelTicketID;
        private Label labelUserID;
        private Label labelVehicleID;
        private Label labelVehicleClass;
        private Label labelJourneyDate;
        private Label labelSeatAmount;
        private Label labelPaidAmount;
        private Label labelSeatNumbers;
        private Button buttonDownload;
        private Button buttonReturn;
        private PictureBox buttonExit;
        private TextBox textBoxTicketID;
        private TextBox textBoxUserID;
        private TextBox textBoxVehicleID;
        private TextBox textBoxVehicleClass;
        private TextBox textBoxJourneyDate;
        private TextBox textBoxSeatAmount;
        private TextBox textBoxSeatNumbers;
        private TextBox textBoxPaidAmount;
    }
}