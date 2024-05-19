namespace TravelEase.Moduler_Admin
{
    partial class CancelationModule
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
            label26 = new Label();
            textBoxVehicleID = new TextBox();
            buttonCancelTicketModular = new Button();
            buttonSearch = new Button();
            dataGridViewTicketSearchedbyVehicleID = new DataGridView();
            label1 = new Label();
            textBoxTicketID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicketSearchedbyVehicleID).BeginInit();
            SuspendLayout();
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.None;
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.ForeColor = SystemColors.ButtonHighlight;
            label26.Location = new Point(126, 54);
            label26.Name = "label26";
            label26.Size = new Size(189, 31);
            label26.TabIndex = 6;
            label26.Text = "Enter Vehicle ID:";
            // 
            // textBoxVehicleID
            // 
            textBoxVehicleID.Anchor = AnchorStyles.None;
            textBoxVehicleID.ForeColor = SystemColors.ActiveCaptionText;
            textBoxVehicleID.Location = new Point(322, 54);
            textBoxVehicleID.Name = "textBoxVehicleID";
            textBoxVehicleID.Size = new Size(257, 27);
            textBoxVehicleID.TabIndex = 4;
            // 
            // buttonCancelTicketModular
            // 
            buttonCancelTicketModular.BackColor = Color.FromArgb(187, 233, 237);
            buttonCancelTicketModular.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancelTicketModular.Location = new Point(486, 415);
            buttonCancelTicketModular.Name = "buttonCancelTicketModular";
            buttonCancelTicketModular.Size = new Size(139, 32);
            buttonCancelTicketModular.TabIndex = 7;
            buttonCancelTicketModular.Text = "Cancel Ticket";
            buttonCancelTicketModular.UseVisualStyleBackColor = false;
            buttonCancelTicketModular.Click += buttonCancelTicketModular_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.FromArgb(187, 233, 237);
            buttonSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.Location = new Point(601, 54);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(85, 31);
            buttonSearch.TabIndex = 8;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // dataGridViewTicketSearchedbyVehicleID
            // 
            dataGridViewTicketSearchedbyVehicleID.BackgroundColor = Color.White;
            dataGridViewTicketSearchedbyVehicleID.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTicketSearchedbyVehicleID.Location = new Point(12, 125);
            dataGridViewTicketSearchedbyVehicleID.Name = "dataGridViewTicketSearchedbyVehicleID";
            dataGridViewTicketSearchedbyVehicleID.RowHeadersWidth = 51;
            dataGridViewTicketSearchedbyVehicleID.Size = new Size(814, 188);
            dataGridViewTicketSearchedbyVehicleID.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(126, 420);
            label1.Name = "label1";
            label1.Size = new Size(177, 31);
            label1.TabIndex = 10;
            label1.Text = "Enter Ticket ID:";
            // 
            // textBoxTicketID
            // 
            textBoxTicketID.Anchor = AnchorStyles.None;
            textBoxTicketID.ForeColor = SystemColors.ActiveCaptionText;
            textBoxTicketID.Location = new Point(331, 420);
            textBoxTicketID.Name = "textBoxTicketID";
            textBoxTicketID.Size = new Size(119, 27);
            textBoxTicketID.TabIndex = 11;
            // 
            // CancelationModule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            ClientSize = new Size(854, 538);
            Controls.Add(textBoxTicketID);
            Controls.Add(label1);
            Controls.Add(dataGridViewTicketSearchedbyVehicleID);
            Controls.Add(buttonSearch);
            Controls.Add(buttonCancelTicketModular);
            Controls.Add(label26);
            Controls.Add(textBoxVehicleID);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CancelationModule";
            Text = "CancelationModule";
            Load += CancelationModule_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicketSearchedbyVehicleID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label26;
        private TextBox textBoxVehicleID;
        private Button buttonCancelTicketModular;
        private Button buttonSearch;
        private DataGridView dataGridViewTicketSearchedbyVehicleID;
        private Label label1;
        private TextBox textBoxTicketID;
    }
}