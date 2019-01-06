using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using PdfSharp.Pdf;
using PdfSharp.Charting;
using PdfSharp.Fonts;
using PdfSharp.Forms;
using PdfSharp.Drawing;
using cinema_2.db.persistence;
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
        private static readonly int COLUMN_OFFSET = 300;
        private static readonly int MARGIN_LEFT = 45;

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
                "Начало", booking.Session.DateTime.ToString("dd.MM.yyyy HH: mm"), 2, 2);


            string filename = $"{booking.Id}-ticket.pdf";
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
