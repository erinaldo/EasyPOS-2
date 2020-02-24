﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.RepSalesReport
{
    public partial class RepSalesReportStockWithdrawalReportForm : Form
    {
        public RepSalesReportStockWithdrawalReportForm(String filePath, List<Entities.RepSalesReportTrnCollectionEntity> collectionLists)
        {
            InitializeComponent();
            PrintStockWithdrawalReport(filePath, collectionLists);
        }

        public void PrintStockWithdrawalReport(String filePath, List<Entities.RepSalesReportTrnCollectionEntity> collectionLists)
        {
            try
            {
                Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

                var fileName = filePath + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf";
                var currentUser = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;

                iTextSharp.text.Rectangle pagesize = new iTextSharp.text.Rectangle(612, 861);

                Document document = new Document(pagesize.Rotate());
                document.SetMargins(30f, 461f, 10f, 10f);

                PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));

                document.Open();

                if (collectionLists.Any())
                {
                    foreach (var collectionList in collectionLists)
                    {
                        var collection = from d in db.TrnCollections where d.Id == collectionList.Id select d;

                        iTextSharp.text.Font fontArial09 = FontFactory.GetFont("Arial", 09);
                        iTextSharp.text.Font fontArial09Italic = FontFactory.GetFont("Arial", 09, iTextSharp.text.Font.ITALIC);
                        iTextSharp.text.Font fontArial0Italic = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.ITALIC);
                        iTextSharp.text.Font fontArial10 = FontFactory.GetFont("Arial", 10);
                        iTextSharp.text.Font fontArial10Bold = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD);
                        iTextSharp.text.Font fontArial11 = FontFactory.GetFont("Arial", 11);
                        iTextSharp.text.Font fontArial11Bold = FontFactory.GetFont("Arial", 11, iTextSharp.text.Font.BOLD);
                        iTextSharp.text.Font fontArial14Bold = FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD);

                        var systemCurrent = Modules.SysCurrentModule.GetCurrentSettings();

                        String documentTitle = systemCurrent.ORPrintTitle;
                        String documentDate = DateTime.Today.ToShortDateString();

                        PdfPTable tableHeader = new PdfPTable(2);
                        tableHeader.SetWidths(new float[] { 70f, 30f });
                        tableHeader.WidthPercentage = 100;
                        tableHeader.AddCell(new PdfPCell(new Phrase(documentTitle, fontArial14Bold)) { Border = 0, Padding = 0 });
                        tableHeader.AddCell(new PdfPCell(new Phrase(documentDate, fontArial11)) { Border = 0, Padding = 0, HorizontalAlignment = Element.ALIGN_RIGHT, PaddingTop = 5f });
                        document.Add(tableHeader);

                        Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.5F, 100.0F, BaseColor.DARK_GRAY, Element.ALIGN_MIDDLE, 7F)));
                        document.Add(line);

                        String term = collection.FirstOrDefault().MstCustomer.MstTerm.Term;
                        String dueDate = collection.FirstOrDefault().CollectionDate.AddDays(Convert.ToDouble(collection.FirstOrDefault().MstCustomer.MstTerm.NumberOfDays)).Date.ToShortDateString();
                        String deliveryDate = collection.FirstOrDefault().CollectionDate.ToShortDateString();

                        PdfPTable tableDates = new PdfPTable(3);
                        tableDates.SetWidths(new float[] { 80f, 100f, 100f });
                        tableDates.WidthPercentage = 100;
                        tableDates.AddCell(new PdfPCell(new Phrase("Term: " + term, fontArial11)) { Border = 0, Padding = 0 });
                        tableDates.AddCell(new PdfPCell(new Phrase("Due Date: " + dueDate, fontArial11)) { Border = 0, Padding = 0 });
                        tableDates.AddCell(new PdfPCell(new Phrase("Delivery Date: " + deliveryDate, fontArial11)) { Border = 0, Padding = 0 });
                        document.Add(tableDates);
                        document.Add(line);

                        String customer = collection.FirstOrDefault().MstCustomer.Customer;
                        String address = collection.FirstOrDefault().MstCustomer.Address;

                        PdfPTable tableCustomer = new PdfPTable(1);
                        tableCustomer.SetWidths(new float[] { 100f });
                        tableCustomer.WidthPercentage = 100;
                        tableCustomer.AddCell(new PdfPCell(new Phrase(customer, fontArial11Bold)) { Border = 0, Padding = 0 });
                        tableCustomer.AddCell(new PdfPCell(new Phrase(address, fontArial11)) { Border = 0, Padding = 0 });
                        document.Add(tableCustomer);
                        document.Add(line);

                        PdfPTable tableItem = new PdfPTable(3);
                        tableItem.SetWidths(new float[] { 100f, 20f, 30f });
                        tableItem.WidthPercentage = 100;

                        tableItem.AddCell(new PdfPCell(new Phrase("Description", fontArial11Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 4f });
                        tableItem.AddCell(new PdfPCell(new Phrase("Qty.", fontArial11Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 4f });
                        tableItem.AddCell(new PdfPCell(new Phrase("Unit", fontArial11Bold)) { HorizontalAlignment = 1, PaddingTop = 2f, PaddingBottom = 4f });

                        if (collection.FirstOrDefault().TrnSale.TrnSalesLines.Any())
                        {
                            foreach (var salesItem in collection.FirstOrDefault().TrnSale.TrnSalesLines)
                            {
                                tableItem.AddCell(new PdfPCell(new Phrase(salesItem.MstItem.ItemDescription, fontArial11)) { Border = 0, Padding = 3f });
                                tableItem.AddCell(new PdfPCell(new Phrase(salesItem.Quantity.ToString("#,##0.00"), fontArial11)) { Border = 0, Padding = 3f, HorizontalAlignment = 2 });
                                tableItem.AddCell(new PdfPCell(new Phrase(salesItem.MstItem.MstUnit.Unit, fontArial11)) { Border = 0, Padding = 3f });
                            }
                        }

                        document.Add(tableItem);
                        document.Add(line);

                        PdfPTable tableSignature = new PdfPTable(1);
                        tableSignature.SetWidths(new float[] { 100f });
                        tableSignature.WidthPercentage = 100;
                        tableSignature.AddCell(new PdfPCell(new Phrase("Received by / Date Received:", fontArial0Italic)) { Border = 0, Padding = 3f });
                        tableSignature.AddCell(new PdfPCell(new Phrase("_____________________")) { Border = 0, PaddingTop = 25f });
                        tableSignature.AddCell(new PdfPCell(new Phrase("DR No.: " + collection.FirstOrDefault().CollectionNumber, fontArial11Bold)) { Border = 0, Padding = 3f });
                        document.Add(tableSignature);

                        String ORFooter = systemCurrent.ReceiptFooter;
                        PdfPTable tableFooter = new PdfPTable(1);
                        tableFooter.SetWidths(new float[] { 100f });
                        tableFooter.WidthPercentage = 100;
                        tableFooter.AddCell(new PdfPCell(new Phrase(ORFooter, fontArial11)) { Border = 0, PaddingLeft = 3f, PaddingRight = 3f, PaddingTop = 10f });
                        document.Add(tableFooter);

                        document.NewPage();
                    }
                }

                document.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Easy ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}