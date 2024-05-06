namespace TravelEase.PassengerDashboards
{
    partial class BuyTicket
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
            panelShowSeat = new Panel();
            panelAmount = new Panel();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            textBox2 = new TextBox();
            buttonBuyTicket = new Button();
            button1 = new Button();
            panelShowSeat.SuspendLayout();
            panelAmount.SuspendLayout();
            SuspendLayout();
            // 
            // panelShowSeat
            // 
            panelShowSeat.Controls.Add(textBox1);
            panelShowSeat.Controls.Add(label2);
            panelShowSeat.Dock = DockStyle.Right;
            panelShowSeat.Location = new Point(477, 0);
            panelShowSeat.Name = "panelShowSeat";
            panelShowSeat.Size = new Size(501, 574);
            panelShowSeat.TabIndex = 0;
            // 
            // panelAmount
            // 
            panelAmount.Controls.Add(button1);
            panelAmount.Controls.Add(buttonBuyTicket);
            panelAmount.Controls.Add(textBox2);
            panelAmount.Controls.Add(label1);
            panelAmount.Controls.Add(comboBox1);
            panelAmount.Controls.Add(label3);
            panelAmount.Dock = DockStyle.Left;
            panelAmount.Location = new Point(0, 0);
            panelAmount.Name = "panelAmount";
            panelAmount.Size = new Size(471, 574);
            panelAmount.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 37);
            label2.Name = "label2";
            label2.Size = new Size(144, 28);
            label2.TabIndex = 1;
            label2.Text = "Available Seat :";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(187, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 2;
            textBox1.Text = "10";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 27);
            label3.Name = "label3";
            label3.Size = new Size(396, 31);
            label3.TabIndex = 1;
            label3.Text = "How many seat do you want to book?";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4" });
            comboBox1.Location = new Point(28, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(84, 28);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 148);
            label1.Name = "label1";
            label1.Size = new Size(130, 28);
            label1.TabIndex = 3;
            label1.Text = "Total Amount";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(68, 198);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 34);
            textBox2.TabIndex = 4;
            textBox2.Text = "4*100 =400";
            // 
            // buttonBuyTicket
            // 
            buttonBuyTicket.Location = new Point(121, 312);
            buttonBuyTicket.Name = "buttonBuyTicket";
            buttonBuyTicket.Size = new Size(134, 56);
            buttonBuyTicket.TabIndex = 5;
            buttonBuyTicket.Text = "Buy Ticket";
            buttonBuyTicket.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(277, 312);
            button1.Name = "button1";
            button1.Size = new Size(134, 56);
            button1.TabIndex = 6;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            // 
            // BuyTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 574);
            Controls.Add(panelAmount);
            Controls.Add(panelShowSeat);
            Name = "BuyTicket";
            Text = "BuyTicket";
            panelShowSeat.ResumeLayout(false);
            panelShowSeat.PerformLayout();
            panelAmount.ResumeLayout(false);
            panelAmount.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelShowSeat;
        private TextBox textBox1;
        private Label label2;
        private Panel panelAmount;
        private Button buttonBuyTicket;
        private TextBox textBox2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label3;
        private Button button1;
    }
}