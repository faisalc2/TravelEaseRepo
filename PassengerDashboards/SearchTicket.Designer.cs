namespace TravelEase.Dashboards
{
    partial class SearchTicket
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
            buttonBus = new Button();
            buttonTrain = new Button();
            buttonAir = new Button();
            buttonLaunch = new Button();
            label1 = new Label();
            label2 = new Label();
            comboBoxFrom = new ComboBox();
            comboBoxTo = new ComboBox();
            buttonOk = new Button();
            buttonSearch = new Button();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // buttonBus
            // 
            buttonBus.Location = new Point(179, 74);
            buttonBus.Name = "buttonBus";
            buttonBus.Size = new Size(94, 29);
            buttonBus.TabIndex = 0;
            buttonBus.Text = "Bus";
            buttonBus.UseVisualStyleBackColor = true;
            // 
            // buttonTrain
            // 
            buttonTrain.Location = new Point(332, 74);
            buttonTrain.Name = "buttonTrain";
            buttonTrain.Size = new Size(94, 29);
            buttonTrain.TabIndex = 1;
            buttonTrain.Text = "Train";
            buttonTrain.UseVisualStyleBackColor = true;
            // 
            // buttonAir
            // 
            buttonAir.Location = new Point(482, 74);
            buttonAir.Name = "buttonAir";
            buttonAir.Size = new Size(94, 29);
            buttonAir.TabIndex = 2;
            buttonAir.Text = "Air Flight";
            buttonAir.UseVisualStyleBackColor = true;
            // 
            // buttonLaunch
            // 
            buttonLaunch.Location = new Point(630, 74);
            buttonLaunch.Name = "buttonLaunch";
            buttonLaunch.Size = new Size(94, 29);
            buttonLaunch.TabIndex = 3;
            buttonLaunch.Text = "Launch";
            buttonLaunch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 194);
            label1.Name = "label1";
            label1.Size = new Size(87, 38);
            label1.TabIndex = 4;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(97, 268);
            label2.Name = "label2";
            label2.Size = new Size(51, 38);
            label2.TabIndex = 5;
            label2.Text = "To:";
            // 
            // comboBoxFrom
            // 
            comboBoxFrom.FormattingEnabled = true;
            comboBoxFrom.Items.AddRange(new object[] { "Dhaka", "Sylhet" });
            comboBoxFrom.Location = new Point(186, 204);
            comboBoxFrom.Name = "comboBoxFrom";
            comboBoxFrom.Size = new Size(151, 28);
            comboBoxFrom.TabIndex = 6;
            // 
            // comboBoxTo
            // 
            comboBoxTo.FormattingEnabled = true;
            comboBoxTo.Items.AddRange(new object[] { "Dhaka", "Sylhet" });
            comboBoxTo.Location = new Point(186, 278);
            comboBoxTo.Name = "comboBoxTo";
            comboBoxTo.Size = new Size(151, 28);
            comboBoxTo.TabIndex = 7;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(179, 146);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 8;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(186, 465);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(182, 79);
            buttonSearch.TabIndex = 9;
            buttonSearch.Text = "Search for";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(252, 344);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 335);
            label3.Name = "label3";
            label3.Size = new Size(219, 38);
            label3.TabIndex = 11;
            label3.Text = "Date of Journey:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 408);
            label4.Name = "label4";
            label4.Size = new Size(185, 38);
            label4.TabIndex = 12;
            label4.Text = "Choose Class:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dhaka", "Sylhet" });
            comboBox1.Location = new Point(240, 418);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 13;
            // 
            // SearchTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 574);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(buttonSearch);
            Controls.Add(buttonOk);
            Controls.Add(comboBoxTo);
            Controls.Add(comboBoxFrom);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonLaunch);
            Controls.Add(buttonAir);
            Controls.Add(buttonTrain);
            Controls.Add(buttonBus);
            Name = "SearchTicket";
            Text = "PassengerDashboards";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBus;
        private Button buttonTrain;
        private Button buttonAir;
        private Button buttonLaunch;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxFrom;
        private ComboBox comboBoxTo;
        private Button buttonOk;
        private Button buttonSearch;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
    }
}