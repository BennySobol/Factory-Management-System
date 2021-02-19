using DrMelomad.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace DrMelomad.Win
{
    public partial class mergeWin : Form
    {
        public mergeWin()
        {
            InitializeComponent();
        }

        private string[] filesDir;
        private bool isChecking;

        private void DirChoseBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog
            {
                ValidateNames = false,
                CheckFileExists = false,
                CheckPathExists = true,
                FileName = "Folder Selection."
            };
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                dirTB.Text = Path.GetDirectoryName(folderBrowser.FileName);
                errorProvider1.SetError(dirChoseBTN, "");
            }
        }

        private void MergeBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Valid(true))
                    return;

                string Text = namesRTB.Text.Trim();
                string[] sortBy = Text.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                if (sortBy.Length < 2)
                {
                    errorProvider1.SetError(namesRTB, "כתוב שמות של לפחות שני קבצים");
                    MessageBox.Show("שגיאה");
                    return;
                }
                List<string> endDir = new List<string>();
                foreach (string x in sortBy)
                {
                    string temp = DirFromName(filesDir, x);
                    if (temp == "error")
                        continue;
                    endDir.Add(temp);
                }
                string[] sorted = endDir.ToArray();

                if (sorted.Length < 2)
                {
                    errorProvider1.SetError(namesRTB, "כתוב שמות תקינים של לפחות שני קבצים");
                    MessageBox.Show("שגיאה");
                    return;
                }
                if (Merge(sorted, $"{dirTB.Text}\\{mergeNameTB.Text}.docx"))
                    MessageBox.Show("!הצליח המיזוג");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void PastBTN_Click(object sender, EventArgs e)
        {
            namesRTB.Paste();
        }

        private void CopyBTN_Click(object sender, EventArgs e)
        {
            if (namesRTB.SelectionLength == 0)
                namesRTB.SelectAll();
            namesRTB.Copy();
        }

        private void CutBTN_Click(object sender, EventArgs e)
        {
            if (namesRTB.SelectionLength == 0)
                namesRTB.SelectAll();
            namesRTB.Cut();
        }

        private void ClearBTN_Click(object sender, EventArgs e)
        {
            namesRTB.Text = "";
        }

        private void GetNamesBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Valid(false))
                    return;
                errorProvider1.SetError(dirChoseBTN, "");
                for (int i = 0; i < filesDir.Length; i++)
                {
                    filesDir[i] = (Path.GetFileName(filesDir[i]));
                    filesDir[i] = filesDir[i].Substring(0, filesDir[i].Length - 5);
                }
                namesRTB.Text = string.Join(", ", filesDir);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void CheckBTN_Click(object sender, EventArgs e)
        {
            isChecking = true;
            try
            {
                int S = namesRTB.SelectionStart;
                if (!Valid(true))
                    return;
                string Text = namesRTB.Text;
                Text = Text.Replace('\n', ',');
                string[] sortBy = Text.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (sortBy.Length > 250)
                {
                    MessageBox.Show("יש יותר מ250 שמות הקוד לא יעיל לכן לא לבדוק");
                    return;
                }

                foreach (string x in sortBy)
                {
                    if (DirFromName(filesDir, x) == "error")
                    {
                        int start = 0;
                        int end = namesRTB.Text.LastIndexOf(x.Trim());
                        while (start <= end)
                        {
                            namesRTB.Find(x.Trim(), start, namesRTB.TextLength, RichTextBoxFinds.MatchCase);
                            namesRTB.SelectionBackColor = Color.Red;
                            start = namesRTB.Text.IndexOf(x.Trim(), start) + 1;
                        }
                    }
                }
                namesRTB.DeselectAll();
                namesRTB.SelectionStart = S;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            isChecking = false;
        }

        private string DirFromName(string[] arrayStrings, string x)
        {
            int index = -1;
            for (int i = 0; i < arrayStrings.Length; i++)
            {
                string temp = Path.GetFileName(arrayStrings[i].Trim().ToLower());
                if (temp.Substring(0, temp.Length - 5).Contains(x.Trim().ToLower()))
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
                return "error";

            return arrayStrings[index];
        }

        public bool Merge(string[] filesToMerge, string outputFilename)
        {
            object missing = Type.Missing;
            object outputFile = outputFilename;
            Word._Application wordApplication = new Word.Application();
            try
            {
                Word.Document wordDocument = wordApplication.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                Word.Selection selection = wordApplication.Selection;

                foreach (string file in filesToMerge)
                {
                    selection.InsertFile(file, ref missing, ref missing, ref missing, ref missing);

                    if (spaceCB.SelectedIndex == 1)
                        selection.InsertBreak(7); // ref pageBreak
                    else
                        selection.InsertBreak(6); // Line break.
                }
                wordDocument.SaveAs(ref outputFile, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);
                wordDocument = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
            finally
            {
                wordApplication.Quit(ref missing, ref missing, ref missing);
            }
            return true;
        }

        private bool Valid(bool checkNames)
        {
            if (dirTB.Text == "")
            {
                errorProvider1.SetError(dirChoseBTN, "בחר תקיה");
                MessageBox.Show("שגיאה");
                return false;
            }
            errorProvider1.SetError(dirChoseBTN, "");

            if (checkNames && namesRTB.Text.Trim() == "")
            {
                errorProvider1.SetError(namesRTB, "בחר איזה קבצים למזג");
                MessageBox.Show("שגיאה");
                return false;
            }

            errorProvider1.SetError(dirChoseBTN, "");
            filesDir = Directory.GetFiles(dirTB.Text, "*.doc");

            if (filesDir.Length < 2)
            {
                errorProvider1.SetError(dirChoseBTN, "בחר תקיה עם לפחות שני קבצים");
                MessageBox.Show("שגיאה");
                return false;
            }
            errorProvider1.SetError(dirChoseBTN, "");
            if (mergeNameTB.Text.Trim() == "")
            {
                errorProvider1.SetError(mergeNameTB, "בחר שם לקובץ המיזוג");
                MessageBox.Show("שגיאה");
                return false;
            }
            errorProvider1.SetError(mergeNameTB, "");
            return true;
        }

        private void MergeWin_Load(object sender, EventArgs e)
        {
            BackColor = (Color)Settings.Default["color"];
            dirChoseBTN.Image = new Bitmap(Resources.folder, new Size((int)(dirChoseBTN.Height / 1.2), (int)(dirChoseBTN.Height / 1.2)));
            spaceCB.SelectedIndex = 0;
            mergeNameTB.Text = "מיזוג";
        }

        private void NamesRTB_Leave(object sender, EventArgs e)
        {
            if (namesRTB.Text.Trim() == "")
                errorProvider1.SetError(namesRTB, "בחר איזה קבצים למזג");
            else
                errorProvider1.SetError(namesRTB, "");
        }

        private void MergeNameTB_Leave(object sender, EventArgs e)
        {
            if (mergeNameTB.Text.Trim() == "")
                errorProvider1.SetError(mergeNameTB, "בחר שם לקובץ המיזוג");
            else
                errorProvider1.SetError(mergeNameTB, "");
        }

        private void NamesRTB_TextChanged(object sender, EventArgs e)
        {
            if(!isChecking)
            {
                int S = namesRTB.SelectionStart;
                namesRTB.SelectAll();
                namesRTB.SelectionBackColor = Color.White;
                namesRTB.DeselectAll();
                namesRTB.SelectionStart = S;
            }
        }
    }
}
