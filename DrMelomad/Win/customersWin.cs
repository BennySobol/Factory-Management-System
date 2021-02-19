using DrMelomad.Database;
using DrMelomad.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DrMelomad.Win
{
    public partial class CustomersWin : Form
    {
        readonly dbEntities db = new dbEntities();
        customersTBL choseCus;
        public CustomersWin()
        {
            InitializeComponent();
        }

        private void AddEmpBTN_Click(object sender, EventArgs e)
        {
            if (!Tools.CheckName(addCustomerFirstName, Ep) || !Tools.CheckName(addCustomerLastName, Ep) || !Tools.CheckName(addCustomerAddress, Ep) || !Tools.CheckPhone(addCustomerPhone, Ep) || !Tools.CheckEmail(addCustomerEmail, Ep))
            {
                MessageBox.Show("ישנה שגיאה");
                return;
            }
            customersTBL cus = new customersTBL
            {
                address = addCustomerAddress.Text.Trim(),
                mail = addCustomerEmail.Text.Trim(),
                firstName = addCustomerFirstName.Text.Trim(),
                lastName = addCustomerLastName.Text.Trim(),
                phone = addCustomerPhone.Text.Trim(),
                notes = addCustomerNotes.Text.Trim()
            };

            db.customersTBL.Add(cus);
            db.SaveChanges();
            UpdateLists();
            MessageBox.Show("העובד התווסף בהצלחה");
            addCustomerAddress.Text = "";
            addCustomerEmail.Text = "";
            addCustomerFirstName.Text = "";
            addCustomerLastName.Text = "";
            addCustomerPhone.Text = "";
            addCustomerNotes.Text = "";
        }

        private void EditComboBoxEmpChose_SelectedIndexChanged(object sender, EventArgs e)
        {
            choseCus = (customersTBL)editComboBoxCustomerChose.SelectedItem;
            editCustomerAddress.Text = choseCus.address.Trim();
            editCustomerEmail.Text = choseCus.mail.Trim();
            editCustomerFirstName.Text = choseCus.firstName.Trim();
            editCustomerLastName.Text = choseCus.lastName.Trim();
            editCustomerPhone.Text = choseCus.phone.Trim();
            editCustomerNotes.Text = choseCus.notes.Trim();
        }

        private void EmpEditButton_Click(object sender, EventArgs e)
        {

            if (!Tools.CheckName(editCustomerFirstName, Ep) || !Tools.CheckName(editCustomerLastName, Ep) || !Tools.CheckName(editCustomerAddress, Ep) || !Tools.CheckPhone(editCustomerPhone, Ep) || !Tools.CheckEmail(editCustomerEmail, Ep))
            {
                MessageBox.Show("ישנה שגיאה");
                return;
            }
            choseCus.address = editCustomerAddress.Text.Trim();
            choseCus.mail = editCustomerEmail.Text.Trim();
            choseCus.firstName = editCustomerFirstName.Text.Trim();
            choseCus.lastName = editCustomerLastName.Text.Trim();
            choseCus.phone = editCustomerPhone.Text.Trim();
            choseCus.notes = editCustomerNotes.Text.Trim();
            db.SaveChanges();
            MessageBox.Show("פרטי העובד עודכנו בהצלחה");
            UpdateLists();
        }
        private void UpdateLists()
        {
            List<customersTBL> customersLST;
            switch (customerSortComboBox.SelectedIndex)
            {
                case 0:
                    customersLST = (from emp in db.customersTBL orderby emp.firstName select emp).ToList();
                    break;
                case 1:
                    customersLST = (from emp in db.customersTBL orderby emp.lastName select emp).ToList();
                    break;
                default:
                    customersLST = (from emp in db.customersTBL orderby emp.mail select emp).ToList();
                    break;
            }

            CustomerChoseDataGrid.DataSource = customersLST;
            CustomerChoseDataGrid.Columns[0].Visible = false;
            CustomerChoseDataGrid.Columns[1].Visible = false;
            CustomerChoseDataGrid.Columns[2].Visible = false;
            CustomerChoseDataGrid.Columns[3].HeaderText = "שם מלא";
            CustomerChoseDataGrid.Columns[3].Width = 150;
            CustomerChoseDataGrid.Columns[4].Visible = false;
            CustomerChoseDataGrid.Columns[5].HeaderText = "טלפון";
            CustomerChoseDataGrid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            CustomerChoseDataGrid.Columns[6].HeaderText = "כתובת מייל";
            CustomerChoseDataGrid.Columns[6].Width = 200;
            CustomerChoseDataGrid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            CustomerChoseDataGrid.Columns[7].Visible = false;
            CustomerChoseDataGrid.Columns[8].Visible = false;

            dataGridViewCustomers.DataSource = customersLST;
            dataGridViewCustomers.Columns[0].Visible = false;
            dataGridViewCustomers.Columns[1].Visible = false;
            dataGridViewCustomers.Columns[2].Visible = false;
            dataGridViewCustomers.Columns[3].HeaderText = "שם מלא";
            dataGridViewCustomers.Columns[3].Width = 150;
            dataGridViewCustomers.Columns[4].HeaderText = "כתובת";
            dataGridViewCustomers.Columns[4].Width = 150;
            dataGridViewCustomers.Columns[5].HeaderText = "טלפון";
            dataGridViewCustomers.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCustomers.Columns[6].HeaderText = "כתובת מייל";
            dataGridViewCustomers.Columns[6].Width = 250;
            dataGridViewCustomers.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCustomers.Columns[7].Visible = false;
            dataGridViewCustomers.Columns[8].Visible = false;

            editComboBoxCustomerChose.DataSource = customersLST;
            editComboBoxCustomerChose.DisplayMember = "fullName";
            editComboBoxCustomerChose.ValueMember = "Id";
        }

        private void EmpSortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLists();
        }

        private void CustomertsWin_Load(object sender, EventArgs e)
        {
            BackColor =  (Color)Settings.Default["color"];
            Tools.ColorDataGridView(CustomerChoseDataGrid);
            Tools.ColorDataGridView(dataGridViewCustomers);
            UpdateLists();

            customerSortComboBox.SelectedIndex = 0;
            try
            {
                editComboBoxCustomerChose.SelectedIndex = 0;
            }
            catch { }
        }
        private void PrintCustomersBTN_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            MyReports.DrawDataGridView(this.Font, e, "דוח לקוחות", dataGridViewCustomers);
        }

        private void AddCustomerFirstName_Leave(object sender, EventArgs e)
        {
            Tools.CheckName(addCustomerFirstName, Ep);
        }

        private void AddCustomerLastName_Leave(object sender, EventArgs e)
        {
            Tools.CheckName(addCustomerLastName, Ep);
        }

        private void AddCustomerPhone_Leave(object sender, EventArgs e)
        {
            Tools.CheckPhone(addCustomerPhone, Ep);
        }

        private void AddCustomerEmail_Leave(object sender, EventArgs e)
        {
            Tools.CheckEmail(addCustomerEmail, Ep);
        }

        private void EditCustomerFirstName_Leave(object sender, EventArgs e)
        {
            Tools.CheckName(editCustomerFirstName, Ep);
        }

        private void EditCustomerLastName_Leave(object sender, EventArgs e)
        {
            Tools.CheckName(editCustomerLastName, Ep);
        }

        private void EditCustomerEmail_Leave(object sender, EventArgs e)
        {
            Tools.CheckEmail(editCustomerEmail, Ep);
        }

        private void EditCustomerPhone_Leave(object sender, EventArgs e)
        {
            Tools.CheckPhone(editCustomerPhone, Ep);
        }
    }
}
