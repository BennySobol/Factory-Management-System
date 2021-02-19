using DrMelomad.Database;
using DrMelomad.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;

namespace DrMelomad.Win
{
    public partial class supplierWin : Form
    {
        readonly dbEntities db = new dbEntities();
        suppliersTBL choseSupplier;
        public supplierWin()
        {
            InitializeComponent();
        }

        private void AddEmpBTN_Click(object sender, EventArgs e)
        {

            if (!Tools.CheckName(addSupplierFirstName, Ep) || !Tools.CheckName(addSupplierLastName, Ep) || !Tools.CheckPhone(addSupplierPhone, Ep) || !Tools.CheckEmail(addSupplierEmail, Ep))
            {
                MessageBox.Show("ישנה שגיאה");
                return;
            }
            suppliersTBL supplier = new suppliersTBL
            {
                address = addSupplierAddress.Text.Trim(),
                mail = addSupplierEmail.Text.Trim(),
                firstName = addSupplierFirstName.Text.Trim(),
                lastName = addSupplierLastName.Text.Trim(),
                phone = addSupplierPhone.Text.Trim(),
                notes = addSupplierNotes.Text.Trim()
            };

            db.suppliersTBL.Add(supplier);
            db.SaveChanges();
            UpdateLists();
            MessageBox.Show("העובד התווסף בהצלחה");
            addSupplierAddress.Text = "";
            addSupplierEmail.Text = "";
            addSupplierFirstName.Text = "";
            addSupplierLastName.Text = "";
            addSupplierPhone.Text = "";
            addSupplierNotes.Text = "";
        }

        private void EditComboBoxEmpChose_SelectedIndexChanged(object sender, EventArgs e)
        {
            choseSupplier = (suppliersTBL)editComboBoxSupplierChose.SelectedItem;

            editSupplierNotes.Text = choseSupplier.notes.Trim();
            editSupplierAddress.Text = choseSupplier.address.Trim();
            editSupplierEmail.Text = choseSupplier.mail.Trim();
            editSupplierFirstName.Text = choseSupplier.firstName.Trim();
            editSupplierLastName.Text = choseSupplier.lastName.Trim();
            editSupplierPhone.Text = choseSupplier.phone.Trim();
        }

        private void EmpEditButton_Click(object sender, EventArgs e)
        {
            if (!Tools.CheckName(editSupplierFirstName, Ep) || !Tools.CheckName(editSupplierLastName, Ep) || !Tools.CheckPhone(editSupplierPhone, Ep) || !Tools.CheckEmail(editSupplierEmail, Ep))
            {
                MessageBox.Show("ישנה שגיאה");
                return;
            }
            choseSupplier.notes = editSupplierNotes.Text.Trim();
            choseSupplier.address = editSupplierAddress.Text.Trim();
            choseSupplier.mail = editSupplierEmail.Text.Trim();
            choseSupplier.firstName = editSupplierFirstName.Text.Trim();
            choseSupplier.lastName = editSupplierLastName.Text.Trim();
            choseSupplier.phone = editSupplierPhone.Text.Trim();
            db.SaveChanges();
            MessageBox.Show("פרטי העובד עודכנו בהצלחה");
            editComboBoxSupplierChose.SelectedIndex = 0;
            UpdateLists();
        }

        private void UpdateLists()
        {
            List<suppliersTBL> suppliersList;

            switch (empSortComboBox.SelectedIndex)
            {
                case 0:
                    suppliersList = (from emp in db.suppliersTBL orderby emp.firstName select emp).ToList();
                    break;
                case 1:
                    suppliersList = (from emp in db.suppliersTBL orderby emp.lastName select emp).ToList();
                    break;
                default:
                    suppliersList = (from emp in db.suppliersTBL orderby emp.mail select emp).ToList();
                    break;
            }
            supDGV.DataSource = suppliersList;
            supDGV.Columns[0].Visible = false;
            supDGV.Columns[1].Visible = false;
            supDGV.Columns[2].Visible = false;
            supDGV.Columns[3].HeaderText = "שם מלא";
            supDGV.Columns[3].Width = 150;
            supDGV.Columns[4].HeaderText = "כתובת";
            supDGV.Columns[5].HeaderText = "טלפון";
            supDGV.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            supDGV.Columns[6].HeaderText = "כתובת מייל";
            supDGV.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            supDGV.Columns[6].Width = 200;
            supDGV.Columns[7].Visible = false;

            SupplierChoseDataGrid.DataSource = suppliersList;
            SupplierChoseDataGrid.Columns[0].Visible = false;
            SupplierChoseDataGrid.Columns[1].Visible = false;
            SupplierChoseDataGrid.Columns[2].Visible = false;
            SupplierChoseDataGrid.Columns[3].HeaderText = "שם מלא";
            SupplierChoseDataGrid.Columns[3].Width = 150;
            SupplierChoseDataGrid.Columns[4].Visible = false;
            SupplierChoseDataGrid.Columns[5].HeaderText = "טלפון";
            SupplierChoseDataGrid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            SupplierChoseDataGrid.Columns[6].HeaderText = "כתובת מייל";
            SupplierChoseDataGrid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            SupplierChoseDataGrid.Columns[6].Width = 200;
            SupplierChoseDataGrid.Columns[7].Visible = false;

            editComboBoxSupplierChose.DataSource = suppliersList;
            editComboBoxSupplierChose.DisplayMember = "fullName";
            editComboBoxSupplierChose.ValueMember = "Id";
        }

        private void EmpSortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLists();
        }

        private void SupplierWin_Load(object sender, EventArgs e)
        {
            BackColor = (Color)Settings.Default["color"];
            Tools.ColorDataGridView(supDGV);
            Tools.ColorDataGridView(SupplierChoseDataGrid);
            UpdateLists();
            choseSupLV.Columns[0].Width = 250;
            choseSupLV.Width = 255;
            foreach (suppliersTBL sup in db.suppliersTBL)
                choseSupLV.Items.Add(sup.fullName);

            empSortComboBox.SelectedIndex = 0;
            try
            {
                editComboBoxSupplierChose.SelectedIndex = 0;
            }
            catch { }
        }

        private void PrintSupplierDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            MyReports.DrawDataGridView(this.Font, e, "דוח ספקים", supDGV);
        }

        private void AddMailBTN_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lv in choseSupLV.SelectedItems)
            {
                suppliersTBL sup = (from s in db.suppliersTBL where s.fullName == lv.Text select s).FirstOrDefault();
                if (!supMailTB.Text.Contains(sup.mail))
                    supMailTB.Text += sup.mail + ", ";
            }
        }

        private void SendBTN_Click(object sender, EventArgs e)
        {
            if (!Tools.CheckName(subjectTB, Ep) || !Tools.CheckName(bodyTB, Ep))
            {
                MessageBox.Show("ישנה שגיאה");
                return;
            }
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new System.Net.NetworkCredential("webEmailSender1@gmail.com", "webEmailSender123"),
                EnableSsl = true
            };
            MailMessage mail = new MailMessage
            {
                From = new MailAddress("webEmailSender1@gmail.com")
            };
            foreach (string s in supMailTB.Text.Split(','))
                    if(s.Trim() != "")   
                        mail.To.Add(s.Trim());

            if (addFileDirTB.Text.Trim() != "")
            {
                mail.Attachments.Add(new Attachment(addFileDirTB.Text.Trim()));
            }
            mail.Subject = supMailTB.Text;
            mail.Body = bodyTB.Text;
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            try
            {
                SmtpServer.Send(mail);
                MessageBox.Show("ההודעה נשלחה בהצלחה", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            }
        }


        private void PrintSupplierBTN_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void ClearSerchBTN_Click(object sender, EventArgs e)
        {
            supMailTB.Text = "";
        }

        private void AddSupplierFirstName_Leave(object sender, EventArgs e)
        {
            Tools.CheckName(addSupplierFirstName, Ep);
        }

        private void AddSupplierLastName_Leave(object sender, EventArgs e)
        {
            Tools.CheckName(addSupplierLastName, Ep);
        }

        private void AddSupplierPhone_Leave(object sender, EventArgs e)
        {
            Tools.CheckPhone(addSupplierPhone, Ep);
        }

        private void AddSupplierEmail_Leave(object sender, EventArgs e)
        {
            Tools.CheckName(addSupplierEmail, Ep);
        }

        private void EditSupplierFirstName_Leave(object sender, EventArgs e)
        {
            Tools.CheckName(editSupplierFirstName, Ep);
        }

        private void EditSupplierLastName_Leave(object sender, EventArgs e)
        {
            Tools.CheckName(editSupplierLastName, Ep);
        }

        private void EditSupplierPhone_Leave(object sender, EventArgs e)
        {
            Tools.CheckPhone(editSupplierPhone, Ep);
        }

        private void EditSupplierEmail_Leave(object sender, EventArgs e)
        {
            Tools.CheckName(editSupplierEmail, Ep);
        }

        private void SubjectTB_Leave(object sender, EventArgs e)
        {
            Tools.CheckName(subjectTB, Ep);
        }

        private void BodyRTB_Leave(object sender, EventArgs e)
        {
            Tools.CheckName(bodyTB, Ep);
        }

        private void FileChoseBTN_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                addFileDirTB.Text = openFileDialog1.FileName;
            else
                addFileDirTB.Text = "";
        }

        private void ChoseSupLV_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = choseSupLV.Columns[e.ColumnIndex].Width;
        }
    }
}
