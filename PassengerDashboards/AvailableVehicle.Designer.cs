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
            label1 = new Label();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 25);
            label1.Name = "label1";
            label1.Size = new Size(168, 31);
            label1.TabIndex = 0;
            label1.Text = "Available Bus//";
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(31, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(935, 409);
            panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(906, 45);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(15, 100);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(906, 45);
            comboBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(397, 519);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Book Now";
            button1.UseVisualStyleBackColor = true;
            // 
            // AvailableVehicle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 574);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "AvailableVehicle";
            Text = "AvailableVehicle";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button1;
    }
}