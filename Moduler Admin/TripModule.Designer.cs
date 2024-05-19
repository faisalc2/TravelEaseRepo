namespace TravelEase.Moduler_Admin
{
    partial class TripModule
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
            textBox6 = new TextBox();
            label9 = new Label();
            button1 = new Button();
            button7 = new Button();
            button8 = new Button();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(41, 192);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(212, 38);
            textBox6.TabIndex = 24;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(41, 158);
            label9.Name = "label9";
            label9.Size = new Size(120, 31);
            label9.TabIndex = 23;
            label9.Text = "Vehicle ID:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(187, 233, 237);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(109, 423);
            button1.Name = "button1";
            button1.Size = new Size(107, 41);
            button1.TabIndex = 22;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.BackColor = Color.FromArgb(187, 233, 237);
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(173, 367);
            button7.Name = "button7";
            button7.Size = new Size(107, 41);
            button7.TabIndex = 21;
            button7.Text = "REMOVE";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.None;
            button8.BackColor = Color.FromArgb(187, 233, 237);
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(39, 367);
            button8.Name = "button8";
            button8.Size = new Size(107, 41);
            button8.TabIndex = 20;
            button8.Text = "ADD";
            button8.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(41, 298);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(212, 38);
            textBox5.TabIndex = 19;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(41, 264);
            label8.Name = "label8";
            label8.Size = new Size(147, 31);
            label8.TabIndex = 18;
            label8.Text = "Trip Number:";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(41, 75);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(212, 38);
            textBox4.TabIndex = 17;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(41, 41);
            label7.Name = "label7";
            label7.Size = new Size(80, 31);
            label7.TabIndex = 16;
            label7.Text = "Name:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(328, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 449);
            panel1.TabIndex = 25;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(91, 22);
            label2.Name = "label2";
            label2.Size = new Size(133, 31);
            label2.TabIndex = 3;
            label2.Text = "Trip Details:";
            // 
            // TripModule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            ClientSize = new Size(734, 491);
            Controls.Add(panel1);
            Controls.Add(textBox6);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(label7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TripModule";
            Text = "TripModule";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox6;
        private Label label9;
        private Button button1;
        private Button button7;
        private Button button8;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox4;
        private Label label7;
        private Panel panel1;
        private Label label2;
    }
}