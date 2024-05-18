namespace TravelEase.PassengerDashboards
{
    partial class AvailableVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvailableVehicle));
            label1 = new Label();
            panel1 = new Panel();
            DGVAvailableVehicle = new DataGridView();
            buttonBookNow = new Button();
            button2 = new Button();
            buttonExit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVAvailableVehicle).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(31, 25);
            label1.Name = "label1";
            label1.Size = new Size(195, 31);
            label1.TabIndex = 0;
            label1.Text = "Available Vehicle";
            // 
            // panel1
            // 
            panel1.Controls.Add(DGVAvailableVehicle);
            panel1.Location = new Point(31, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(1022, 409);
            panel1.TabIndex = 1;
            // 
            // DGVAvailableVehicle
            // 
            DGVAvailableVehicle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVAvailableVehicle.Location = new Point(3, 3);
            DGVAvailableVehicle.Name = "DGVAvailableVehicle";
            DGVAvailableVehicle.RowHeadersWidth = 51;
            DGVAvailableVehicle.Size = new Size(1016, 230);
            DGVAvailableVehicle.TabIndex = 5;
            DGVAvailableVehicle.CellClick += DGVAvailableVehicle_CellClick;
            // 
            // buttonBookNow
            // 
            buttonBookNow.BackColor = Color.FromArgb(187, 233, 237);
            buttonBookNow.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonBookNow.Location = new Point(380, 519);
            buttonBookNow.Name = "buttonBookNow";
            buttonBookNow.Size = new Size(103, 43);
            buttonBookNow.TabIndex = 2;
            buttonBookNow.Text = "Book Now";
            buttonBookNow.UseVisualStyleBackColor = false;
            buttonBookNow.Click += buttonBookNow_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(187, 233, 237);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(512, 519);
            button2.Name = "button2";
            button2.Size = new Size(106, 43);
            button2.TabIndex = 3;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // buttonExit
            // 
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Image = (Image)resources.GetObject("buttonExit.Image");
            buttonExit.Location = new Point(1036, -1);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(45, 36);
            buttonExit.TabIndex = 4;
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // AvailableVehicle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 574);
            Controls.Add(buttonExit);
            Controls.Add(button2);
            Controls.Add(buttonBookNow);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AvailableVehicle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AvailableVehicle";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVAvailableVehicle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button buttonBookNow;
        private Button button2;
        private Button buttonExit;
        private DataGridView DGVAvailableVehicle;
    }
}