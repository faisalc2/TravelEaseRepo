namespace TravelEase.System_Admin
{
    partial class RequestedCom
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            labelName = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labelID = new Label();
            buttonApprove = new Button();
            buttonRemove = new Button();
            radioButtonShip = new RadioButton();
            radioBtnAir = new RadioButton();
            radioBtnTrain = new RadioButton();
            radioBtnBus = new RadioButton();
            buttonOK = new Button();
            DGVPassengerInfo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGVPassengerInfo).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.ForeColor = SystemColors.ButtonHighlight;
            labelName.Location = new Point(12, 105);
            labelName.Name = "labelName";
            labelName.Size = new Size(209, 31);
            labelName.TabIndex = 1;
            labelName.Text = "Name of Company:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(22, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 38);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(22, 259);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 38);
            textBox2.TabIndex = 4;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelID.ForeColor = SystemColors.ButtonHighlight;
            labelID.Location = new Point(22, 214);
            labelID.Name = "labelID";
            labelID.Size = new Size(98, 31);
            labelID.TabIndex = 3;
            labelID.Text = "BRTC ID:";
            // 
            // buttonApprove
            // 
            buttonApprove.BackColor = Color.FromArgb(187, 233, 237);
            buttonApprove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonApprove.ForeColor = SystemColors.ActiveCaptionText;
            buttonApprove.Location = new Point(23, 335);
            buttonApprove.Name = "buttonApprove";
            buttonApprove.Size = new Size(117, 54);
            buttonApprove.TabIndex = 5;
            buttonApprove.Text = "Approve";
            buttonApprove.UseVisualStyleBackColor = false;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.FromArgb(187, 233, 237);
            buttonRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRemove.ForeColor = SystemColors.ActiveCaptionText;
            buttonRemove.Location = new Point(166, 335);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(117, 54);
            buttonRemove.TabIndex = 6;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            // 
            // radioButtonShip
            // 
            radioButtonShip.AutoSize = true;
            radioButtonShip.ForeColor = SystemColors.ButtonHighlight;
            radioButtonShip.Location = new Point(265, 22);
            radioButtonShip.Name = "radioButtonShip";
            radioButtonShip.Size = new Size(59, 24);
            radioButtonShip.TabIndex = 12;
            radioButtonShip.TabStop = true;
            radioButtonShip.Text = "Ship";
            radioButtonShip.UseVisualStyleBackColor = true;
            // 
            // radioBtnAir
            // 
            radioBtnAir.AutoSize = true;
            radioBtnAir.ForeColor = SystemColors.ButtonHighlight;
            radioBtnAir.Location = new Point(187, 22);
            radioBtnAir.Name = "radioBtnAir";
            radioBtnAir.Size = new Size(49, 24);
            radioBtnAir.TabIndex = 11;
            radioBtnAir.TabStop = true;
            radioBtnAir.Text = "Air";
            radioBtnAir.UseVisualStyleBackColor = true;
            // 
            // radioBtnTrain
            // 
            radioBtnTrain.AutoSize = true;
            radioBtnTrain.ForeColor = SystemColors.ButtonHighlight;
            radioBtnTrain.Location = new Point(102, 22);
            radioBtnTrain.Name = "radioBtnTrain";
            radioBtnTrain.Size = new Size(62, 24);
            radioBtnTrain.TabIndex = 10;
            radioBtnTrain.TabStop = true;
            radioBtnTrain.Text = "Train";
            radioBtnTrain.UseVisualStyleBackColor = true;
            // 
            // radioBtnBus
            // 
            radioBtnBus.AutoSize = true;
            radioBtnBus.ForeColor = SystemColors.ButtonHighlight;
            radioBtnBus.Location = new Point(32, 22);
            radioBtnBus.Name = "radioBtnBus";
            radioBtnBus.Size = new Size(53, 24);
            radioBtnBus.TabIndex = 9;
            radioBtnBus.TabStop = true;
            radioBtnBus.Text = "Bus";
            radioBtnBus.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            buttonOK.BackColor = Color.FromArgb(187, 233, 237);
            buttonOK.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOK.ForeColor = SystemColors.ActiveCaptionText;
            buttonOK.Location = new Point(102, 58);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(89, 44);
            buttonOK.TabIndex = 13;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click;
            // 
            // DGVPassengerInfo
            // 
            DGVPassengerInfo.AllowUserToAddRows = false;
            DGVPassengerInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(48, 56, 79);
            DGVPassengerInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGVPassengerInfo.BorderStyle = BorderStyle.None;
            DGVPassengerInfo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(48, 56, 79);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVPassengerInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGVPassengerInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVPassengerInfo.EnableHeadersVisualStyles = false;
            DGVPassengerInfo.Location = new Point(323, 77);
            DGVPassengerInfo.Name = "DGVPassengerInfo";
            DGVPassengerInfo.ReadOnly = true;
            DGVPassengerInfo.RowHeadersWidth = 51;
            DGVPassengerInfo.Size = new Size(399, 340);
            DGVPassengerInfo.TabIndex = 14;
            // 
            // RequestedCom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            ClientSize = new Size(734, 539);
            Controls.Add(DGVPassengerInfo);
            Controls.Add(buttonOK);
            Controls.Add(radioButtonShip);
            Controls.Add(radioBtnAir);
            Controls.Add(radioBtnTrain);
            Controls.Add(radioBtnBus);
            Controls.Add(buttonRemove);
            Controls.Add(buttonApprove);
            Controls.Add(textBox2);
            Controls.Add(labelID);
            Controls.Add(textBox1);
            Controls.Add(labelName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RequestedCom";
            Text = "RequestedBusCom";
            ((System.ComponentModel.ISupportInitialize)DGVPassengerInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelName;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label labelID;
        private Button buttonApprove;
        private Button buttonRemove;
        private RadioButton radioButtonShip;
        private RadioButton radioBtnAir;
        private RadioButton radioBtnTrain;
        private RadioButton radioBtnBus;
        private Button buttonOK;
        private DataGridView DGVPassengerInfo;
    }
}