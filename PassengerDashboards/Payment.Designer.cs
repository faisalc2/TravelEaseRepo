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
            panelPayemtMethod = new Panel();
            buttonNext1 = new Button();
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            radioButtonTrain = new RadioButton();
            radioButtonBus = new RadioButton();
            panel2 = new Panel();
            buttonpurchase = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            buttonExit = new Button();
            panelPayemtMethod.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelPayemtMethod
            // 
            panelPayemtMethod.BackColor = Color.FromArgb(48, 56, 79);
            panelPayemtMethod.Controls.Add(buttonNext1);
            panelPayemtMethod.Controls.Add(groupBox1);
            panelPayemtMethod.Location = new Point(139, 52);
            panelPayemtMethod.Name = "panelPayemtMethod";
            panelPayemtMethod.Size = new Size(804, 464);
            panelPayemtMethod.TabIndex = 0;
            // 
            // buttonNext1
            // 
            buttonNext1.BackColor = Color.FromArgb(187, 233, 237);
            buttonNext1.Cursor = Cursors.Hand;
            buttonNext1.FlatStyle = FlatStyle.Popup;
            buttonNext1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonNext1.ForeColor = Color.Black;
            buttonNext1.Location = new Point(576, 401);
            buttonNext1.Margin = new Padding(0);
            buttonNext1.Name = "buttonNext1";
            buttonNext1.Size = new Size(103, 39);
            buttonNext1.TabIndex = 28;
            buttonNext1.Text = "Next";
            buttonNext1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(radioButtonTrain);
            groupBox1.Controls.Add(radioButtonBus);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(74, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(631, 342);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose desired Payment method:";
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
            // radioButtonTrain
            // 
            radioButtonTrain.AutoSize = true;
            radioButtonTrain.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonTrain.Location = new Point(265, 224);
            radioButtonTrain.Name = "radioButtonTrain";
            radioButtonTrain.Size = new Size(233, 32);
            radioButtonTrain.TabIndex = 1;
            radioButtonTrain.TabStop = true;
            radioButtonTrain.Text = "Online Card Payment";
            radioButtonTrain.UseVisualStyleBackColor = true;
            // 
            // radioButtonBus
            // 
            radioButtonBus.AutoSize = true;
            radioButtonBus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonBus.Location = new Point(265, 96);
            radioButtonBus.Name = "radioButtonBus";
            radioButtonBus.Size = new Size(262, 32);
            radioButtonBus.TabIndex = 0;
            radioButtonBus.TabStop = true;
            radioButtonBus.Text = "Online Mobile Payment ";
            radioButtonBus.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 56, 79);
            panel2.Controls.Add(buttonpurchase);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(139, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(804, 464);
            panel2.TabIndex = 1;
            // 
            // buttonpurchase
            // 
            buttonpurchase.BackColor = Color.FromArgb(187, 233, 237);
            buttonpurchase.Cursor = Cursors.Hand;
            buttonpurchase.FlatStyle = FlatStyle.Popup;
            buttonpurchase.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonpurchase.ForeColor = Color.Black;
            buttonpurchase.Location = new Point(293, 259);
            buttonpurchase.Margin = new Padding(0);
            buttonpurchase.Name = "buttonpurchase";
            buttonpurchase.Size = new Size(145, 50);
            buttonpurchase.TabIndex = 28;
            buttonpurchase.Text = "purchase";
            buttonpurchase.UseVisualStyleBackColor = false;
            buttonpurchase.Click += buttonpurchase_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(365, 172);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(258, 165);
            label2.Name = "label2";
            label2.Size = new Size(55, 31);
            label2.TabIndex = 2;
            label2.Text = "Pin:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(133, 77);
            label1.Name = "label1";
            label1.Size = new Size(191, 31);
            label1.TabIndex = 1;
            label1.Text = "Mobile Number:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(365, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
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
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            ClientSize = new Size(1080, 574);
            Controls.Add(buttonExit);
            Controls.Add(panel2);
            Controls.Add(panelPayemtMethod);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Payment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            panelPayemtMethod.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPayemtMethod;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private RadioButton radioButtonTrain;
        private RadioButton radioButtonBus;
        private Button buttonNext1;
        private Panel panel2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private Button buttonpurchase;
        private Button buttonExit;
    }
}