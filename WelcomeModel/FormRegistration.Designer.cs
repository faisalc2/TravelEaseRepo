namespace TravelEase
{
    partial class FormRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistration));
            topPanel = new Panel();
            label1 = new Label();
            topLebel = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            topPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.Controls.Add(label1);
            topPanel.Controls.Add(topLebel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1048, 84);
            topPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(355, 53);
            label1.Name = "label1";
            label1.Size = new Size(328, 25);
            label1.TabIndex = 1;
            label1.Text = "Provide Information to Register Yourself";
            // 
            // topLebel
            // 
            topLebel.Anchor = AnchorStyles.None;
            topLebel.AutoSize = true;
            topLebel.FlatStyle = FlatStyle.Flat;
            topLebel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            topLebel.Location = new Point(367, 9);
            topLebel.Name = "topLebel";
            topLebel.Size = new Size(305, 54);
            topLebel.TabIndex = 0;
            topLebel.Text = "REGISTRATION";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 72);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(532, 3);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label3.Location = new Point(596, 24);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 1;
            label3.Text = "Profile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.Location = new Point(358, 24);
            label2.Name = "label2";
            label2.Size = new Size(181, 25);
            label2.TabIndex = 0;
            label2.Text = "General Information";
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 583);
            Controls.Add(panel1);
            Controls.Add(topPanel);
            Name = "FormRegistration";
            Text = "Registration";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private Label topLebel;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
