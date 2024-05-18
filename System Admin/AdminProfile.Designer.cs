namespace TravelEase.System_Admin
{
    partial class AdminProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProfile));
            textBoxComName = new TextBox();
            labelName = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            pictureBox7 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // textBoxComName
            // 
            textBoxComName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxComName.Location = new Point(104, 134);
            textBoxComName.Name = "textBoxComName";
            textBoxComName.ReadOnly = true;
            textBoxComName.Size = new Size(275, 38);
            textBoxComName.TabIndex = 4;
            textBoxComName.Text = "Foisal Ahmed Chowdhury";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.ForeColor = SystemColors.ButtonHighlight;
            labelName.Location = new Point(73, 83);
            labelName.Name = "labelName";
            labelName.Size = new Size(232, 31);
            labelName.TabIndex = 3;
            labelName.Text = "System Admin Name:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(104, 247);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(275, 38);
            textBox1.TabIndex = 6;
            textBox1.Text = "Admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(73, 201);
            label1.Name = "label1";
            label1.Size = new Size(115, 31);
            label1.TabIndex = 5;
            label1.Text = "Admin ID:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(104, 395);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(275, 38);
            textBox2.TabIndex = 8;
            textBox2.Text = "Admin123";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(73, 336);
            label2.Name = "label2";
            label2.Size = new Size(189, 31);
            label2.TabIndex = 7;
            label2.Text = "Admin Password:";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(410, 106);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(312, 296);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 12;
            pictureBox7.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(501, 418);
            label3.Name = "label3";
            label3.Size = new Size(126, 37);
            label3.TabIndex = 13;
            label3.Text = "Admin ";
            // 
            // AdminProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            ClientSize = new Size(734, 539);
            Controls.Add(label3);
            Controls.Add(pictureBox7);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(textBoxComName);
            Controls.Add(labelName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminProfile";
            Text = "AdminProfile";
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxComName;
        private Label labelName;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private PictureBox pictureBox7;
        private Label label3;
    }
}