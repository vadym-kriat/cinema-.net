using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Drawing.BarCodes;
using cinema_2.models;

namespace cinema_2.services
{
    public class PDFFileService
    {
        private static readonly XPdfFontOptions FONT_OPTIONS
            = new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Always);

        private static readonly XFont TITLE_FONT = new XFont("Times New Roman", 20, XFontStyle.Bold, FONT_OPTIONS);
        private static readonly XFont TEXT_FONT = new XFont("Times New Roman", 14, XFontStyle.Regular, FONT_OPTIONS);
        private static readonly XFont BOLD_TEXT_FONT = new XFont("Times New Roman", 14, XFontStyle.Bold, FONT_OPTIONS);

        private static readonly int ROW_OFFSET = 45;
        private static readonly int COLUMN_OFFSET = 250;
        private static readonly int MARGIN_LEFT = 35;

        private static readonly string ROOT_PATH = AppDomain.CurrentDomain.BaseDirectory;

        public static void SaveTicketToPDF(Booking booking)
        {
            PdfDocument document = new PdfDocument();

            PdfPage page = document.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(page);

            DrawTextBlock(gfx,
                "Покупатель", $"{booking.Customer.FirstName} {booking.Customer.LastName}", 1, 1);
            DrawTextBlock(gfx,
                "Стоимость билета", $"{booking.Session.Film.Cost}", 2, 1);
            DrawTextBlock(gfx,
                "Фильм", booking.Session.Film.Name, 3, 1);

            DrawTextBlock(gfx,
               "Номер заказа", booking.Id.ToString(), 1, 2);
            DrawTextBlock(gfx,
                "Начало", booking.Session.DateTime.ToString("dd.MM.yyyy HH:mm"), 2, 2);
            DrawTextBlock(gfx,
                "Место", $"Ряд: {booking.Row} Место: {booking.Seat}", 3, 2);

            DrawBarCode(gfx, $"ticket-id-{booking.Id}", booking.Id);
            DrawBorder(gfx, page);

            string filename = $"{ROOT_PATH}/tickets/{booking.Id}-ticket.pdf";
            document.Save(filename);
        }

        private static void DrawTextBlock(XGraphics gfx, string title, string text, int row, int column)
        {
            int x = MARGIN_LEFT + (column - 1) * COLUMN_OFFSET;
            int y = row * ROW_OFFSET;

            gfx.DrawString($"{title}:", TEXT_FONT, XBrushes.Black,
                x, y);
            gfx.DrawString(text, BOLD_TEXT_FONT, XBrushes.Black,
                x, y + 18);
        }

        private static void DrawBarCode(XGraphics gfx, string barcodeText, long id)
        {
            Code3of9Standard bc39 = new Code3of9Standard(barcodeText, new XSize(90, 40));
            bc39.Text = id.ToString();
            double width = ROW_OFFSET * 3;
            bc39.Size = new XSize(width, width / 3);
            bc39.TextLocation = TextLocation.Above;
            bc39.Direction = CodeDirection.BottomToTop;

            gfx.DrawBarCode(bc39, XBrushes.Black, new XPoint(520, 163));
        }

        private static void DrawBorder(XGraphics gfx, PdfPage page)
        {
            XRect rect = new XRect(10, 10, page.Width - 20, ROW_OFFSET * 4 - 5);

            XFont font = new XFont("Verdana", 5);
            XBrush brush = XBrushes.Purple;
            XStringFormat format = new XStringFormat();

            gfx.DrawRectangle(XPens.Black, rect);
        }
    }

    public class ImageService
    {
        public static byte[] ImageToByteArray(System.Drawing.Image image)
        {
            if (image == null)
            {
                return null;
            }

            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public static System.Drawing.Image ByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null)
            {
                return null;
            }

            MemoryStream ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;
        }
    }
}
