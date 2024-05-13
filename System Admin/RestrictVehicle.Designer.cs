namespace TravelEase.System_Admin
{
    partial class RestrictVehicle
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
            panel1 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            labelName = new Label();
            buttonRestrict = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(375, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 471);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 21);
            label1.Name = "label1";
            label1.Size = new Size(169, 20);
            label1.TabIndex = 0;
            label1.Text = "Bus Company requested";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(36, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 38);
            textBox1.TabIndex = 4;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.Location = new Point(26, 84);
            labelName.Name = "labelName";
            labelName.Size = new Size(120, 31);
            labelName.TabIndex = 3;
            labelName.Text = "Vehicle ID:";
            // 
            // buttonRestrict
            // 
            buttonRestrict.BackColor = Color.FromArgb(48, 56, 79);
            buttonRestrict.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRestrict.ForeColor = SystemColors.ButtonFace;
            buttonRestrict.Location = new Point(97, 257);
            buttonRestrict.Name = "buttonRestrict";
            buttonRestrict.Size = new Size(117, 54);
            buttonRestrict.TabIndex = 6;
            buttonRestrict.Text = "Restrict";
            buttonRestrict.UseVisualStyleBackColor = false;
            // 
            // RestrictVehicle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 539);
            Controls.Add(buttonRestrict);
            Controls.Add(textBox1);
            Controls.Add(labelName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RestrictVehicle";
            Text = "RestrictVehicle";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Label labelName;
        private Button buttonRestrict;
    }
}