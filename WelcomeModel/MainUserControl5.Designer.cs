namespace TravelEase.WelcomeModel
{
    partial class MainUserControl5
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_ID = new Label();
            textBox_ID = new TextBox();
            SuspendLayout();
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_ID.ForeColor = Color.White;
            label_ID.Location = new Point(237, 189);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(301, 31);
            label_ID.TabIndex = 0;
            label_ID.Text = "Your unique TravelEase ID: ";
            // 
            // textBox_ID
            // 
            textBox_ID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_ID.Location = new Point(564, 193);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(317, 34);
            textBox_ID.TabIndex = 1;
            // 
            // MainUserControl5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            Controls.Add(textBox_ID);
            Controls.Add(label_ID);
            Name = "MainUserControl5";
            Size = new Size(1100, 475);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_ID;
        private TextBox textBox_ID;
    }
}
