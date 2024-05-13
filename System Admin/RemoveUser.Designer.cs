namespace TravelEase.System_Admin
{
    partial class RemoveUser
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
            buttonRemove = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.FromArgb(48, 56, 79);
            buttonRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRemove.ForeColor = SystemColors.ButtonFace;
            buttonRemove.Location = new Point(110, 316);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(117, 54);
            buttonRemove.TabIndex = 12;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(47, 236);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 38);
            textBox2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 191);
            label3.Name = "label3";
            label3.Size = new Size(93, 31);
            label3.TabIndex = 10;
            label3.Text = "User ID:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(47, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 38);
            textBox1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 72);
            label2.Name = "label2";
            label2.Size = new Size(132, 31);
            label2.TabIndex = 8;
            label2.Text = "User Name:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(355, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 391);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 21);
            label1.Name = "label1";
            label1.Size = new Size(279, 31);
            label1.TabIndex = 0;
            label1.Text = "User id name ar onno kisu";
            // 
            // RemoveUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 492);
            Controls.Add(buttonRemove);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RemoveUser";
            Text = "RemoveUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRemove;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Panel panel1;
        private Label label1;
    }
}