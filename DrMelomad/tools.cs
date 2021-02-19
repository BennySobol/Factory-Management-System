
using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace DrMelomad.Win
{
    class Tools
    {
        public static void ColorDataGridView(DataGridView dataGridView)
        {
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.MultiSelect = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView.BackgroundColor = Color.White;

            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public static byte[] ResizeMax50Kbytes(byte[] byteImageIn)
        {
            byte[] currentByteImageArray = byteImageIn;
            double scale = 1f;

            MemoryStream inputMemoryStream = new MemoryStream(byteImageIn);
            Image fullsizeImage = Image.FromStream(inputMemoryStream);

            while (Convert.ToBase64String(currentByteImageArray).Length > 50000)
            {
                Bitmap fullSizeBitmap = new Bitmap(fullsizeImage, new Size((int)(fullsizeImage.Width * scale), (int)(fullsizeImage.Height * scale)));
                MemoryStream resultStream = new MemoryStream();

                fullSizeBitmap.Save(resultStream, fullsizeImage.RawFormat);

                currentByteImageArray = resultStream.ToArray();
                resultStream.Dispose();
                resultStream.Close();

                scale -= 0.05f;
            }

            return currentByteImageArray;
        }

        //////////////////////////////////////
        public static bool CheckName(TextBox textBox, ErrorProvider errorProvider1)
        {
            if (textBox.Text.Length < 2)
            {
                errorProvider1.SetError(textBox, "שדה זה חייב להחיל לפחות 2 אותיות");
                return false;
            }
            errorProvider1.SetError(textBox, "");
            return true;
        }
        public static bool CheckNum(NumericUpDown upDown, ErrorProvider errorProvider1)
        {
            try
            { /////////////////////////////
                if ((double)upDown.Value < 0.1)//
                {
                    errorProvider1.SetError(upDown, "שדה זה חייב להחיל גדול מ 0");
                    return false;
                }
                errorProvider1.SetError(upDown, "");
                return true;
            }
            catch { return false; }
        }
        public static bool CheckPhone(MaskedTextBox textBox, ErrorProvider errorProvider1)
        {
            if (textBox.Text.Length == 0)
            {
                errorProvider1.SetError(textBox, "שדה חובה");
                return false;
            }
            if (textBox.Text.Length != 12)
            {
                errorProvider1.SetError(textBox, "מספר הטלפון אינו תקין");
                return false;
            }
            errorProvider1.SetError(textBox, "");
            return true;
        }
        public static bool CheckEmail(TextBox textBox, ErrorProvider errorProvider1)
        {
            if (textBox.Text.Length == 0)
            {
                errorProvider1.SetError(textBox, "שדה חובה");
                return false;
            }
            if (!new EmailAddressAttribute().IsValid(textBox.Text))
            {
                errorProvider1.SetError(textBox, "כתובת מייל אינה תקינה");
                return false;
            }
            errorProvider1.SetError(textBox, "");
            return true;
        }

        public static bool CheckText(RichTextBox textBox, ErrorProvider errorProvider1)
        {
            if (textBox.Text.Length == 0)
            {
                errorProvider1.SetError(textBox, "שדה חובה");
                return false;
            }
            if (!new EmailAddressAttribute().IsValid(textBox.Text))
            {
                errorProvider1.SetError(textBox, "כתובת מייל אינה תקינה");
                return false;
            }
            errorProvider1.SetError(textBox, "");
            return true;
        }
    }
}
