namespace TravelEase.Moduler_Admin
{
    partial class VehicleModule
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
            label3 = new Label();
            buttonCancel = new Button();
            buttonAdd = new Button();
            label4 = new Label();
            groupBox1 = new GroupBox();
            radioButtonAirPlane = new RadioButton();
            radioButtonLaunch = new RadioButton();
            radioButtonTrain = new RadioButton();
            radioButtonBus = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(349, 205);
            label3.Name = "label3";
            label3.Size = new Size(159, 31);
            label3.TabIndex = 4;
            label3.Text = "Vehicle Name:";
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.None;
            buttonCancel.BackColor = Color.FromArgb(187, 233, 237);
            buttonCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonCancel.Location = new Point(534, 412);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(107, 41);
            buttonCancel.TabIndex = 17;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.None;
            buttonAdd.BackColor = Color.FromArgb(187, 233, 237);
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(410, 412);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(107, 41);
            buttonAdd.TabIndex = 15;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(349, 293);
            label4.Name = "label4";
            label4.Size = new Size(126, 31);
            label4.TabIndex = 11;
            label4.Text = "BD Reg. ID:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonAirPlane);
            groupBox1.Controls.Add(radioButtonLaunch);
            groupBox1.Controls.Add(radioButtonTrain);
            groupBox1.Controls.Add(radioButtonBus);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(36, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 125);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select a vehicle type:";
            // 
            // radioButtonAirPlane
            // 
            radioButtonAirPlane.AutoSize = true;
            radioButtonAirPlane.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonAirPlane.Location = new Point(155, 79);
            radioButtonAirPlane.Name = "radioButtonAirPlane";
            radioButtonAirPlane.Size = new Size(98, 27);
            radioButtonAirPlane.TabIndex = 3;
            radioButtonAirPlane.TabStop = true;
            radioButtonAirPlane.Text = "AirPlane";
            radioButtonAirPlane.UseVisualStyleBackColor = true;
            // 
            // radioButtonLaunch
            // 
            radioButtonLaunch.AutoSize = true;
            radioButtonLaunch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonLaunch.Location = new Point(52, 79);
            radioButtonLaunch.Name = "radioButtonLaunch";
            radioButtonLaunch.Size = new Size(87, 27);
            radioButtonLaunch.TabIndex = 2;
            radioButtonLaunch.TabStop = true;
            radioButtonLaunch.Text = "Launch";
            radioButtonLaunch.UseVisualStyleBackColor = true;
            // 
            // radioButtonTrain
            // 
            radioButtonTrain.AutoSize = true;
            radioButtonTrain.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonTrain.Location = new Point(155, 46);
            radioButtonTrain.Name = "radioButtonTrain";
            radioButtonTrain.Size = new Size(71, 27);
            radioButtonTrain.TabIndex = 1;
            radioButtonTrain.TabStop = true;
            radioButtonTrain.Text = "Train";
            radioButtonTrain.UseVisualStyleBackColor = true;
            // 
            // radioButtonBus
            // 
            radioButtonBus.AutoSize = true;
            radioButtonBus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonBus.Location = new Point(52, 46);
            radioButtonBus.Name = "radioButtonBus";
            radioButtonBus.Size = new Size(59, 27);
            radioButtonBus.TabIndex = 0;
            radioButtonBus.TabStop = true;
            radioButtonBus.Text = "Bus";
            radioButtonBus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(49, 292);
            label1.Name = "label1";
            label1.Size = new Size(42, 31);
            label1.TabIndex = 21;
            label1.Text = "To:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(49, 205);
            label2.Name = "label2";
            label2.Size = new Size(71, 31);
            label2.TabIndex = 19;
            label2.Text = "From:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(138, 209);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(168, 27);
            textBox7.TabIndex = 22;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(138, 292);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(168, 27);
            textBox8.TabIndex = 23;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(523, 209);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(168, 27);
            textBox9.TabIndex = 24;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(523, 299);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(168, 27);
            textBox10.TabIndex = 25;
            // 
            // VehicleModule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            ClientSize = new Size(734, 491);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VehicleModule";
            Text = "VehicleModule";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label label3;
        private Button buttonCancel;
        private Button buttonAdd;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox2;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton radioButtonTrain;
        private RadioButton radioButtonBus;
        private RadioButton radioButtonAirPlane;
        private RadioButton radioButtonLaunch;
        private TextBox textBox4;
        private Label label1;
        private TextBox textBox5;
        private Label label2;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
    }
}