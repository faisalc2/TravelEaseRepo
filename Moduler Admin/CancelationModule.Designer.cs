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
            label26 = new Label();
            label11 = new Label();
            textBox11 = new TextBox();
            buttonCancelTicket = new Button();
            SuspendLayout();
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.None;
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.ForeColor = SystemColors.ButtonHighlight;
            label26.Location = new Point(210, 203);
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
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(210, 135);
            label11.Name = "label11";
            label11.Size = new Size(273, 41);
            label11.TabIndex = 5;
            label11.Text = "For Cancel a Ticket:";
            // 
            // textBox11
            // 
            textBox11.Anchor = AnchorStyles.None;
            textBox11.ForeColor = SystemColors.ActiveCaptionText;
            textBox11.Location = new Point(447, 207);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(175, 27);
            textBox11.TabIndex = 4;
            // 
            // buttonCancelTicket
            // 
            buttonCancelTicket.BackColor = Color.FromArgb(187, 233, 237);
            buttonCancelTicket.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonCancelTicket.Location = new Point(311, 291);
            buttonCancelTicket.Name = "buttonCancelTicket";
            buttonCancelTicket.Size = new Size(163, 56);
            buttonCancelTicket.TabIndex = 7;
            buttonCancelTicket.Text = "Cancel Ticket";
            buttonCancelTicket.UseVisualStyleBackColor = false;
            // 
            // CancelationModule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            ClientSize = new Size(854, 538);
            Controls.Add(buttonCancelTicket);
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
        private Label label26;
        private Label label11;
        private TextBox textBox11;
        private Button buttonCancelTicket;
    }
}