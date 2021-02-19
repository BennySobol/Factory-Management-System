
using System;
using System.Drawing.Printing;
using System.Drawing;
using DrMelomad.Database;
using System.Windows.Forms;
using System.Linq;

namespace DrMelomad
{

    class MyReports
    {
        static bool isFirstPage = true;
        static int i = 0;
        static DataGridViewRowCollection rows;
        public static void DrawDataGridView(Font font, PrintPageEventArgs e,string title, DataGridView DGV)
        {
            if(isFirstPage)
            {
                rows = DGV.Rows;
            }
            DrawHeader(new Font(font, FontStyle.Bold), e, title, DGV);
            DrawGridBody(e, DGV, font);
            DrawFooter(e);
        }

        public static void DrawFooter(PrintPageEventArgs e)
        {
            string message = "Dr. Melumad Laboratories, Be'er Tuvia Industrial Area, Israel. Tel +97288505099, Mail www.dr-melumad.com";
            Graphics g = e.Graphics;
            Font messageFont = new Font("Arial", 11, System.Drawing.GraphicsUnit.Point);
            g.DrawString(message, messageFont, Brushes.Black, 28, 1130);
            g.DrawLine(Pens.Green, new Point(0, 1120), new Point(850, 1120));
        }


        public static void DrawHeader(Font boldFont, PrintPageEventArgs e, string title, DataGridView DGV)
        {
            int columnPosition = 820;
            string message = "מעבדות ד\"ר מלומד";
            Image newImage = Properties.Resources.logo;
            Point ulCorner = new Point(10, 5);
            Point urCorner = new Point(180, 5);        
            Point llCorner = new Point(10, 60); 
            Point[] destPara = { ulCorner, urCorner, llCorner };
            Font messageFont = new Font("Arial", 14, System.Drawing.GraphicsUnit.Point);
            e.Graphics.DrawString(message, messageFont, Brushes.Black, 670, 30);
            e.Graphics.DrawImage(newImage, destPara);
            e.Graphics.DrawLine(Pens.Green, new Point(0, 65), new Point(850, 65));
            Font header = new Font("Arial", 25, System.Drawing.GraphicsUnit.Point);
            e.Graphics.DrawString(title, header, Brushes.Black, 360, 85);

            StringFormat df = new StringFormat
            {
                FormatFlags = StringFormatFlags.DirectionRightToLeft
            };

            foreach (DataGridViewColumn dc in DGV.Columns)
                if (dc.Visible)
                {
                    e.Graphics.DrawString(dc.HeaderText, boldFont, Brushes.Black, (float)columnPosition, (float)150, df);
                    columnPosition -= dc.Width + 10;
                }
        }

        public static void DrawGridBody(PrintPageEventArgs e, DataGridView DGV, Font font)
        {
            int rowPosition = 185;
            int index = 0;
            int columnPosition;

            StringFormat df = new StringFormat
            {
                FormatFlags = StringFormatFlags.DirectionRightToLeft
            };
          
            for (; !e.HasMorePages && rows != null && i < rows.Count; i++)
            {
                DataGridViewRow row = rows[i];
                columnPosition = 820;
                e.Graphics.DrawLine(Pens.Black, new Point(0, rowPosition), new Point(850, rowPosition));
                foreach (DataGridViewCell cell in row.Cells)
                {

                    if (rowPosition > 1080) // if page is full
                    {
                        e.HasMorePages = true;
                        isFirstPage = false;
           
                        break;
                    }
                    // draw string in the column
                    if (cell.Value != null && DGV.Columns[index].Visible)
                    {
                        if (cell.Value is byte[]) // draw image
                        {
                            Image newImage = (Bitmap)((new ImageConverter()).ConvertFrom(cell.Value));
                            Point urCorner = new Point(columnPosition, rowPosition + 1);
                            Point ulCorner = new Point(columnPosition - 70, rowPosition + 1);
                            Point llCorner = new Point(columnPosition - 70, rowPosition + 60);

                            Point[] destPara = { ulCorner, urCorner, llCorner };
                            e.Graphics.DrawImage(newImage, destPara);
                        }
                        else // draw string
                        {
                            string text;
                            if (cell.Value is DateTime)
                                text = cell.Value.ToString().Substring(0, 10);
                            else if (cell.Value is double)
                                text = (Math.Round((double)cell.Value, 1)).ToString();
                            else
                                text = cell.Value.ToString();

                            // 10f sets the space between the black line and the text below             
                            e.Graphics.DrawString(text, font, Brushes.Black, (float)columnPosition, (float)rowPosition + 10f, df);
                        }
                        // go to the next column position
                        columnPosition -= DGV.Columns[index].Width + 10;
                    }
                    index++;
                }
                index = 0;
                // go to the next row position
                rowPosition += 60; // this sets the space between the row text and the black line
            }
            if (!e.HasMorePages) // finish printing
            {
                isFirstPage = true; // reset global variables
                i = 0;
            }
        }
    }
}
