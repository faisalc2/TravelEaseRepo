namespace TravelEase.Moduler_Admin
{
    partial class CancelationModule
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
            label29 = new Label();
            label26 = new Label();
            label11 = new Label();
            textBox11 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label29
            // 
            label29.Anchor = AnchorStyles.None;
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label29.ForeColor = SystemColors.ActiveCaptionText;
            label29.Location = new Point(29, 204);
            label29.Name = "label29";
            label29.Size = new Size(123, 31);
            label29.TabIndex = 7;
            label29.Text = "Ar ki dibo?";
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.None;
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.ForeColor = SystemColors.ActiveCaptionText;
            label26.Location = new Point(21, 137);
            label26.Name = "label26";
            label26.Size = new Size(231, 31);
            label26.TabIndex = 6;
            label26.Text = "Ticket Serial Number:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(27, 69);
            label11.Name = "label11";
            label11.Size = new Size(273, 41);
            label11.TabIndex = 5;
            label11.Text = "For Cancel a Ticket:";
            // 
            // textBox11
            // 
            textBox11.Anchor = AnchorStyles.None;
            textBox11.ForeColor = SystemColors.ActiveCaptionText;
            textBox11.Location = new Point(258, 141);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(175, 27);
            textBox11.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(207, 296);
            button1.Name = "button1";
            button1.Size = new Size(141, 39);
            button1.TabIndex = 8;
            button1.Text = "Cancel Ticket";
            button1.UseVisualStyleBackColor = true;
            // 
            // CancelationModule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label29);
            Controls.Add(label26);
            Controls.Add(label11);
            Controls.Add(textBox11);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CancelationModule";
            Text = "CancelationModule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label29;
        private Label label26;
        private Label label11;
        private TextBox textBox11;
        private Button button1;
    }
}