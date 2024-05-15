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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchTicket));
            panel1 = new Panel();
            buttonNext1 = new Button();
            groupBox1 = new GroupBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            radioButtonPlane = new RadioButton();
            radioButtonLaunch = new RadioButton();
            radioButtonTrain = new RadioButton();
            radioButtonBus = new RadioButton();
            panel2 = new Panel();
            dateTimePickerDate = new DateTimePicker();
            comboBoxClass = new ComboBox();
            comboBoxTo = new ComboBox();
            comboBoxFrom = new ComboBox();
            labelClass = new Label();
            labelDate = new Label();
            labelTo = new Label();
            buttonPrevious2 = new Button();
            buttonNext2 = new Button();
            labelFrom = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonNext1);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(725, 538);
            panel1.TabIndex = 0;
            // 
            // buttonNext1
            // 
            buttonNext1.BackColor = Color.FromArgb(187, 233, 237);
            buttonNext1.Cursor = Cursors.Hand;
            buttonNext1.FlatStyle = FlatStyle.Popup;
            buttonNext1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonNext1.ForeColor = Color.Black;
            buttonNext1.Location = new Point(597, 465);
            buttonNext1.Margin = new Padding(0);
            buttonNext1.Name = "buttonNext1";
            buttonNext1.Size = new Size(103, 39);
            buttonNext1.TabIndex = 27;
            buttonNext1.Text = "Next";
            buttonNext1.UseVisualStyleBackColor = false;
            buttonNext1.Click += buttonNext1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(radioButtonPlane);
            groupBox1.Controls.Add(radioButtonLaunch);
            groupBox1.Controls.Add(radioButtonTrain);
            groupBox1.Controls.Add(radioButtonBus);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(158, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(542, 374);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose desired vehicle:";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(319, 219);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(82, 65);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(319, 68);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(82, 65);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(69, 208);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // radioButtonPlane
            // 
            radioButtonPlane.AutoSize = true;
            radioButtonPlane.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonPlane.Location = new Point(418, 234);
            radioButtonPlane.Name = "radioButtonPlane";
            radioButtonPlane.Size = new Size(85, 32);
            radioButtonPlane.TabIndex = 3;
            radioButtonPlane.TabStop = true;
            radioButtonPlane.Text = "Plane";
            radioButtonPlane.UseVisualStyleBackColor = true;
            // 
            // radioButtonLaunch
            // 
            radioButtonLaunch.AutoSize = true;
            radioButtonLaunch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonLaunch.Location = new Point(418, 81);
            radioButtonLaunch.Name = "radioButtonLaunch";
            radioButtonLaunch.Size = new Size(100, 32);
            radioButtonLaunch.TabIndex = 2;
            radioButtonLaunch.TabStop = true;
            radioButtonLaunch.Text = "Launch";
            radioButtonLaunch.UseVisualStyleBackColor = true;
            // 
            // radioButtonTrain
            // 
            radioButtonTrain.AutoSize = true;
            radioButtonTrain.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonTrain.Location = new Point(171, 234);
            radioButtonTrain.Name = "radioButtonTrain";
            radioButtonTrain.Size = new Size(80, 32);
            radioButtonTrain.TabIndex = 1;
            radioButtonTrain.TabStop = true;
            radioButtonTrain.Text = "Train";
            radioButtonTrain.UseVisualStyleBackColor = true;
            // 
            // radioButtonBus
            // 
            radioButtonBus.AutoSize = true;
            radioButtonBus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonBus.Location = new Point(171, 84);
            radioButtonBus.Name = "radioButtonBus";
            radioButtonBus.Size = new Size(67, 32);
            radioButtonBus.TabIndex = 0;
            radioButtonBus.TabStop = true;
            radioButtonBus.Text = "Bus";
            radioButtonBus.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dateTimePickerDate);
            panel2.Controls.Add(comboBoxClass);
            panel2.Controls.Add(comboBoxTo);
            panel2.Controls.Add(comboBoxFrom);
            panel2.Controls.Add(labelClass);
            panel2.Controls.Add(labelDate);
            panel2.Controls.Add(labelTo);
            panel2.Controls.Add(buttonPrevious2);
            panel2.Controls.Add(buttonNext2);
            panel2.Controls.Add(labelFrom);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(725, 538);
            panel2.TabIndex = 17;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.CalendarFont = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerDate.Location = new Point(283, 242);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(277, 27);
            dateTimePickerDate.TabIndex = 33;
            // 
            // comboBoxClass
            // 
            comboBoxClass.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxClass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Items.AddRange(new object[] { "AC", "Non-AC" });
            comboBoxClass.Location = new Point(283, 303);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(277, 36);
            comboBoxClass.TabIndex = 32;
            // 
            // comboBoxTo
            // 
            comboBoxTo.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxTo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxTo.FormattingEnabled = true;
            comboBoxTo.Location = new Point(283, 174);
            comboBoxTo.Name = "comboBoxTo";
            comboBoxTo.Size = new Size(277, 36);
            comboBoxTo.TabIndex = 31;
            // 
            // comboBoxFrom
            // 
            comboBoxFrom.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxFrom.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxFrom.FormattingEnabled = true;
            comboBoxFrom.Location = new Point(283, 113);
            comboBoxFrom.Name = "comboBoxFrom";
            comboBoxFrom.Size = new Size(277, 36);
            comboBoxFrom.TabIndex = 30;
            // 
            // labelClass
            // 
            labelClass.AutoSize = true;
            labelClass.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelClass.ForeColor = Color.White;
            labelClass.Location = new Point(167, 303);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(73, 31);
            labelClass.TabIndex = 29;
            labelClass.Text = "Class:";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDate.ForeColor = Color.White;
            labelDate.Location = new Point(167, 238);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(70, 31);
            labelDate.TabIndex = 28;
            labelDate.Text = "Date:";
            // 
            // labelTo
            // 
            labelTo.AutoSize = true;
            labelTo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTo.ForeColor = Color.White;
            labelTo.Location = new Point(167, 174);
            labelTo.Name = "labelTo";
            labelTo.Size = new Size(45, 31);
            labelTo.TabIndex = 27;
            labelTo.Text = "To:";
            // 
            // buttonPrevious2
            // 
            buttonPrevious2.BackColor = Color.FromArgb(187, 233, 237);
            buttonPrevious2.Cursor = Cursors.Hand;
            buttonPrevious2.FlatStyle = FlatStyle.Popup;
            buttonPrevious2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPrevious2.ForeColor = Color.Black;
            buttonPrevious2.Location = new Point(336, 408);
            buttonPrevious2.Margin = new Padding(0);
            buttonPrevious2.Name = "buttonPrevious2";
            buttonPrevious2.Size = new Size(104, 39);
            buttonPrevious2.TabIndex = 25;
            buttonPrevious2.Text = "Previous";
            buttonPrevious2.UseVisualStyleBackColor = false;
            buttonPrevious2.Click += buttonPrevious2_Click;
            // 
            // buttonNext2
            // 
            buttonNext2.BackColor = Color.FromArgb(187, 233, 237);
            buttonNext2.Cursor = Cursors.Hand;
            buttonNext2.FlatStyle = FlatStyle.Popup;
            buttonNext2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonNext2.ForeColor = Color.Black;
            buttonNext2.Location = new Point(457, 408);
            buttonNext2.Margin = new Padding(0);
            buttonNext2.Name = "buttonNext2";
            buttonNext2.Size = new Size(103, 39);
            buttonNext2.TabIndex = 24;
            buttonNext2.Text = "Search";
            buttonNext2.UseVisualStyleBackColor = false;
            buttonNext2.Click += buttonNext2_Click;
            // 
            // labelFrom
            // 
            labelFrom.AutoSize = true;
            labelFrom.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFrom.ForeColor = Color.White;
            labelFrom.Location = new Point(167, 114);
            labelFrom.Name = "labelFrom";
            labelFrom.Size = new Size(76, 31);
            labelFrom.TabIndex = 18;
            labelFrom.Text = "From:";
            // 
            // SearchTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            ClientSize = new Size(725, 538);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchTicket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search Ticket";
            Load += SearchTicket_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox1;
        private RadioButton radioButtonPlane;
        private RadioButton radioButtonLaunch;
        private RadioButton radioButtonTrain;
        private RadioButton radioButtonBus;
        private Label labelFrom;
        private Button buttonPrevious2;
        private Button buttonNext2;
        private DateTimePicker dateTimePickerDate;
        private ComboBox comboBoxClass;
        private ComboBox comboBoxTo;
        private ComboBox comboBoxFrom;
        private Label labelClass;
        private Label labelDate;
        private Label labelTo;
        private Button buttonNext1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}