namespace TravelEase.PassengerDashboards
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            panel1 = new Panel();
            buttonCancel1 = new Button();
            buttonNext = new Button();
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            radioButtonCardPayment = new RadioButton();
            radioButtonMobileBanking = new RadioButton();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            buttonCancel2 = new Button();
            buttonPurchase2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            buttonExit = new Button();
            panel3 = new Panel();
            groupBox3 = new GroupBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            buttonCancel3 = new Button();
            buttonPurchase3 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(96, 184, 196);
            panel1.Controls.Add(buttonCancel1);
            panel1.Controls.Add(buttonNext);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(127, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 480);
            panel1.TabIndex = 0;
            // 
            // buttonCancel1
            // 
            buttonCancel1.BackColor = Color.FromArgb(187, 233, 237);
            buttonCancel1.Cursor = Cursors.Hand;
            buttonCancel1.FlatStyle = FlatStyle.Popup;
            buttonCancel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel1.ForeColor = Color.Black;
            buttonCancel1.Location = new Point(453, 401);
            buttonCancel1.Margin = new Padding(0);
            buttonCancel1.Name = "buttonCancel1";
            buttonCancel1.Size = new Size(102, 37);
            buttonCancel1.TabIndex = 30;
            buttonCancel1.Text = "Cancel";
            buttonCancel1.UseVisualStyleBackColor = false;
            buttonCancel1.Click += buttonCancel1_Click;
            // 
            // buttonNext
            // 
            buttonNext.BackColor = Color.FromArgb(187, 233, 237);
            buttonNext.Cursor = Cursors.Hand;
            buttonNext.FlatStyle = FlatStyle.Popup;
            buttonNext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonNext.ForeColor = Color.Black;
            buttonNext.Location = new Point(576, 401);
            buttonNext.Margin = new Padding(0);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(103, 39);
            buttonNext.TabIndex = 28;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = false;
            buttonNext.Click += buttonNext_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(radioButtonCardPayment);
            groupBox1.Controls.Add(radioButtonMobileBanking);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(74, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(631, 342);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose A Payment Method:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(163, 200);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(163, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // radioButtonCardPayment
            // 
            radioButtonCardPayment.AutoSize = true;
            radioButtonCardPayment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonCardPayment.Location = new Point(265, 224);
            radioButtonCardPayment.Name = "radioButtonCardPayment";
            radioButtonCardPayment.Size = new Size(165, 32);
            radioButtonCardPayment.TabIndex = 1;
            radioButtonCardPayment.TabStop = true;
            radioButtonCardPayment.Text = "Card Payment";
            radioButtonCardPayment.UseVisualStyleBackColor = true;
            // 
            // radioButtonMobileBanking
            // 
            radioButtonMobileBanking.AutoSize = true;
            radioButtonMobileBanking.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonMobileBanking.Location = new Point(265, 96);
            radioButtonMobileBanking.Name = "radioButtonMobileBanking";
            radioButtonMobileBanking.Size = new Size(182, 32);
            radioButtonMobileBanking.TabIndex = 0;
            radioButtonMobileBanking.TabStop = true;
            radioButtonMobileBanking.Text = "Mobile Banking";
            radioButtonMobileBanking.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(96, 184, 196);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(buttonCancel2);
            panel2.Controls.Add(buttonPurchase2);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(130, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(822, 473);
            panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(96, 184, 196);
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(38, 107);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Select a gateway:";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(146, 81);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(146, 47);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(49, 83);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(95, 32);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nagad";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(49, 47);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(91, 32);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "BKash";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // buttonCancel2
            // 
            buttonCancel2.BackColor = Color.FromArgb(187, 233, 237);
            buttonCancel2.Cursor = Cursors.Hand;
            buttonCancel2.FlatStyle = FlatStyle.Popup;
            buttonCancel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel2.ForeColor = Color.Black;
            buttonCancel2.Location = new Point(278, 343);
            buttonCancel2.Margin = new Padding(0);
            buttonCancel2.Name = "buttonCancel2";
            buttonCancel2.Size = new Size(116, 37);
            buttonCancel2.TabIndex = 29;
            buttonCancel2.Text = "Cancel";
            buttonCancel2.UseVisualStyleBackColor = false;
            // 
            // buttonPurchase2
            // 
            buttonPurchase2.BackColor = Color.FromArgb(187, 233, 237);
            buttonPurchase2.Cursor = Cursors.Hand;
            buttonPurchase2.FlatStyle = FlatStyle.Popup;
            buttonPurchase2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPurchase2.ForeColor = Color.Black;
            buttonPurchase2.Location = new Point(485, 343);
            buttonPurchase2.Margin = new Padding(0);
            buttonPurchase2.Name = "buttonPurchase2";
            buttonPurchase2.Size = new Size(116, 37);
            buttonPurchase2.TabIndex = 28;
            buttonPurchase2.Text = "Purchase";
            buttonPurchase2.UseVisualStyleBackColor = false;
            buttonPurchase2.Click += buttonpurchase_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(537, 185);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 27);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(96, 184, 196);
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(318, 179);
            label2.Name = "label2";
            label2.Size = new Size(59, 31);
            label2.TabIndex = 2;
            label2.Text = "PIN:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(96, 184, 196);
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(318, 134);
            label1.Name = "label1";
            label1.Size = new Size(191, 31);
            label1.TabIndex = 1;
            label1.Text = "Mobile Number:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(537, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 27);
            textBox1.TabIndex = 0;
            // 
            // buttonExit
            // 
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Image = (Image)resources.GetObject("buttonExit.Image");
            buttonExit.Location = new Point(1033, 1);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(45, 36);
            buttonExit.TabIndex = 28;
            buttonExit.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(96, 184, 196);
            panel3.Controls.Add(groupBox3);
            panel3.Controls.Add(buttonCancel3);
            panel3.Controls.Add(buttonPurchase3);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBox4);
            panel3.Location = new Point(127, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(828, 483);
            panel3.TabIndex = 29;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox5);
            groupBox3.Controls.Add(pictureBox6);
            groupBox3.Controls.Add(radioButton3);
            groupBox3.Controls.Add(radioButton4);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(38, 107);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 125);
            groupBox3.TabIndex = 30;
            groupBox3.TabStop = false;
            groupBox3.Text = "Select a card:";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(146, 81);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(55, 34);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(146, 47);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(55, 34);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(49, 83);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(99, 32);
            radioButton3.TabIndex = 1;
            radioButton3.TabStop = true;
            radioButton3.Text = "Master";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(49, 47);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(77, 32);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "VISA";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // buttonCancel3
            // 
            buttonCancel3.BackColor = Color.FromArgb(187, 233, 237);
            buttonCancel3.Cursor = Cursors.Hand;
            buttonCancel3.FlatStyle = FlatStyle.Popup;
            buttonCancel3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel3.ForeColor = Color.Black;
            buttonCancel3.Location = new Point(278, 343);
            buttonCancel3.Margin = new Padding(0);
            buttonCancel3.Name = "buttonCancel3";
            buttonCancel3.Size = new Size(116, 37);
            buttonCancel3.TabIndex = 29;
            buttonCancel3.Text = "Cancel";
            buttonCancel3.UseVisualStyleBackColor = false;
            // 
            // buttonPurchase3
            // 
            buttonPurchase3.BackColor = Color.FromArgb(187, 233, 237);
            buttonPurchase3.Cursor = Cursors.Hand;
            buttonPurchase3.FlatStyle = FlatStyle.Popup;
            buttonPurchase3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPurchase3.ForeColor = Color.Black;
            buttonPurchase3.Location = new Point(485, 343);
            buttonPurchase3.Margin = new Padding(0);
            buttonPurchase3.Name = "buttonPurchase3";
            buttonPurchase3.Size = new Size(116, 37);
            buttonPurchase3.TabIndex = 28;
            buttonPurchase3.Text = "Purchase";
            buttonPurchase3.UseVisualStyleBackColor = false;
            buttonPurchase3.Click += buttonPurchase3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(537, 185);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(236, 27);
            textBox3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(318, 179);
            label3.Name = "label3";
            label3.Size = new Size(59, 31);
            label3.TabIndex = 2;
            label3.Text = "PIN:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(318, 134);
            label4.Name = "label4";
            label4.Size = new Size(164, 31);
            label4.TabIndex = 1;
            label4.Text = "Card Number:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(537, 140);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(236, 27);
            textBox4.TabIndex = 0;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(96, 184, 196);
            ClientSize = new Size(1080, 574);
            Controls.Add(buttonExit);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Payment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            Load += Payment_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private RadioButton radioButtonCardPayment;
        private RadioButton radioButtonMobileBanking;
        private Button buttonNext;
        private Panel panel2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private Button buttonPurchase2;
        private Button buttonExit;
        private GroupBox groupBox2;
        private Button buttonCancel2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Panel panel3;
        private GroupBox groupBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button buttonCancel3;
        private Button buttonPurchase3;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private Button buttonCancel1;
    }
}