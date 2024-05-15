using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ZXing;
using ZXing.Common;

namespace TravelEase.PassengerDashboards
{
    public partial class DownloadTicket : Form
    {
        public DownloadTicket()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            PassengerDashboard passengerDashboard = new PassengerDashboard();
            passengerDashboard.Show();
            this.Hide();
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save Ticket as PDF";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    try
                    {
                        CreatePdf(filePath);
                        MessageBox.Show("Ticket downloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PassengerDashboard passengerDashboard = new PassengerDashboard();
                        passengerDashboard.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error creating PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CreatePdf(string filePath)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    Document document = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(document, fs);

                    document.Open();

                    var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 40);
                    Paragraph title = new Paragraph("Ticket Details", titleFont)
                    {
                        Alignment = Element.ALIGN_CENTER
                    };
                    document.Add(title);

                    var textFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 24);
                    document.Add(new Paragraph("Ticket ID: " + textBoxTicketID.Text, textFont));
                    document.Add(new Paragraph("User ID: " + textBoxUserID.Text, textFont));
                    document.Add(new Paragraph("Vehicle ID: " + textBoxVehicleID.Text, textFont));
                    document.Add(new Paragraph("Vehicle Class: " + textBoxVehicleClass.Text, textFont));
                    document.Add(new Paragraph("Journey Date: " + textBoxJourneyDate.Text, textFont));
                    document.Add(new Paragraph("Seat Amount: " + textBoxSeatAmount.Text, textFont));
                    document.Add(new Paragraph("Seat Number: " + textBoxSeatNumbers.Text, textFont));
                    document.Add(new Paragraph("Paid Amount: " + textBoxPaidAmount.Text, textFont));

                    document.Close();
                    writer.Close();
                }
            }
            catch (DocumentException ex)
            {
                throw new Exception("PDF creation failed: " + ex.Message, ex);
            }
            catch (IOException ex)
            {
                throw new Exception("File IO operation failed: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("An unknown error occurred: " + ex.Message, ex);
            }
        }
    }
}
