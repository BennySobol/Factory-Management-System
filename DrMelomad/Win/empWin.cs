using DrMelomad.Database;
using DrMelomad.Properties;
using DrMelomad.Win;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace DrMelomad
{
    public partial class EmpWin : Form
    {
        readonly dbEntities db = new dbEntities();

        empTBL choseEmp;
        roleTBL ChoseRole;
        private byte[] addImgBytes;
        private byte[] editImgBytes;

        public EmpWin()
        {
            InitializeComponent();
        }

        private void EmpWin_Load(object sender, EventArgs e)
        {
            BackColor = (Color)Settings.Default["color"];
            bDateEmpDTP.MaxDate = DateTime.Now.AddYears(-18);
            bDateEmpDTP.MinDate = DateTime.Now.AddYears(-85);
            editEmpbDateDTP.MaxDate = DateTime.Now.AddYears(-18);
            editEmpbDateDTP.MinDate = DateTime.Now.AddYears(-85);
            Tools.ColorDataGridView(roleDataGrid);
            Tools.ColorDataGridView(dataGridViewEmp);
            Tools.ColorDataGridView(roleChoseDataGrid);
            UpdateLists();

            AddEmpPictureBox.Image = new Bitmap(Resources.defaultProfileImage);

            try
            {
                editRoleComboBox.SelectedIndex = 0;
                addEmpRoleComboBox.SelectedIndex = 0;
                editRoleComboBox.SelectedIndex = 0;
            }
            catch{ }
            hourSelCB.SelectedIndex = 0;
            empSortComboBox.SelectedIndex = 0;
            addEmpGenderComboBox.SelectedIndex = 0;
            editComboBoxEmpGender.SelectedIndex = 0;

            editEmpLeaveReason.Visible = false;
            leaveReasonLBL.Visible = false;
            empSortActiveCheckBox.Checked = false;
        }

        private void AddEmpBTN_Click(object sender, EventArgs e)
        {
            if (!Tools.CheckName(addEmpFirstName, Ep) || !Tools.CheckName(addEmpLastName, Ep) || !Tools.CheckPhone(addEmpPhone, Ep) || !Tools.CheckEmail(addEmpEmail, Ep))
            {
                MessageBox.Show("ישנה שגיאה");
                return;
            }
            empTBL emp = new empTBL
            {
                address = addEmpAddress.Text.Trim(),
                bDate = bDateEmpDTP.Value,
                email = addEmpEmail.Text.Trim(),
                startDate = startDateEmpDTP.Value,
                firstName = addEmpFirstName.Text.Trim(),
                gender = (addEmpGenderComboBox.SelectedIndex == 0),
                isActive = true,
                lastName = addEmpLastName.Text.Trim(),
                phone = addEmpPhone.Text.Trim(),
                img = addImgBytes,
                roleID = ((roleTBL)addEmpRoleComboBox.SelectedItem).Id
            };
            if (addEmpRoleComboBox.SelectedItem != null)
                emp.roleID = ((roleTBL)addEmpRoleComboBox.SelectedItem).Id;

            db.empTBL.Add(emp);
            db.SaveChanges();
            UpdateLists();
            MessageBox.Show("העובד התווסף בהצלחה");
            AddEmpPictureBox.Image = new Bitmap(Resources.defaultProfileImage);
            addEmpInageDirLBL.Text = "";
            addEmpAddress.Text = "";
            addEmpEmail.Text = "";
            addEmpFirstName.Text = "";
            addEmpLastName.Text = "";
            addEmpPhone.Text = "";
        }

        private void EmpEditButton_Click(object sender, EventArgs e)
        {
            if (!Tools.CheckName(editEmpFirstName, Ep) || !Tools.CheckName(editEmpLastName, Ep) || !Tools.CheckPhone(editEmpPhone, Ep) || !Tools.CheckEmail(editEmpEmail, Ep))
            {
                MessageBox.Show("ישנה שגיאה");
                return;
            }
            if (editImgBytes != null)
                choseEmp.img = editImgBytes;
            choseEmp.address = editEmpAddress.Text.Trim();
            choseEmp.bDate = editEmpbDateDTP.Value;
            choseEmp.email = editEmpEmail.Text.Trim();
            choseEmp.startDate = editEmpStartDateDTP.Value;
            choseEmp.firstName = editEmpFirstName.Text.Trim();
            choseEmp.gender = (editComboBoxEmpGender.SelectedIndex == 0);
            choseEmp.lastName = editEmpLastName.Text.Trim();
            choseEmp.phone = editEmpPhone.Text.Trim();
            choseEmp.isActive = editCheckBoxIsActive.Checked;
            choseEmp.roleID = editEmpRoleComboBox.SelectedIndex;
            choseEmp.nots = editEmpNots.Text.Trim();
            if (editEmpRoleComboBox.SelectedItem != null)
                choseEmp.roleID = ((roleTBL)editEmpRoleComboBox.SelectedItem).Id;

            if (editCheckBoxIsActive.Checked)
                choseEmp.endDate = DateTime.Now;
            db.SaveChanges();
            UpdateLists();
            MessageBox.Show("פרטי העובד עודכנו בהצלחה");
        }
        private void UpdateLists()
        {
            List<empTBL> empList = (from emp in db.empTBL orderby emp.lastName select emp).ToList();
            List<empView> empViewsSortLST;

            switch (empSortComboBox.SelectedIndex)
            {
                case 0:
                    empViewsSortLST = (from emp in db.empView orderby emp.fullName select emp).ToList();
                    break;
                case 1:
                    empViewsSortLST = (from emp in db.empView orderby emp.bDate select emp).ToList();
                    break;
                default:
                    empViewsSortLST = (from emp in db.empView orderby emp.startDate select emp).ToList();
                    break;
            }
            if (empSortActiveCheckBox.Checked)
                empViewsSortLST = (from emp in empViewsSortLST where emp.isActive select emp).ToList();
   
            List<roleTBL> roleLST;
            switch (hourSelCB.SelectedIndex)
            {
                case 0:
                    roleLST = (from role in db.roleTBL orderby role.roleName select role).ToList();
                    break;
                default:
                    roleLST = (from role in db.roleTBL orderby role.HourSalary select role).ToList();
                    break;
            }
            if (onlyActiveWorkCB.Checked)         
                roleLST = (from role in roleLST where role.isActive select role).ToList();

       
            dataGridViewEmp.DataSource = null;
            dataGridViewEmp.DataSource = empViewsSortLST;
            dataGridViewEmp.Columns[0].HeaderText = "שם מלא";
            dataGridViewEmp.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewEmp.Columns[1].HeaderText = "כתובת מייל";
            dataGridViewEmp.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewEmp.Columns[1].Width = 190;
            dataGridViewEmp.Columns[2].HeaderText = "טלפון";
            dataGridViewEmp.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;     
            dataGridViewEmp.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewEmp.Columns[2].Width = 125;
            dataGridViewEmp.Columns[3].HeaderText = "תאריך לידה";
            dataGridViewEmp.Columns[3].Width = 90;
            dataGridViewEmp.Columns[4].HeaderText = "תחילת עבודה";
            dataGridViewEmp.Columns[4].Width = 90;
            dataGridViewEmp.Columns[5].HeaderText = "תפקיד";
            dataGridViewEmp.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewEmp.Columns[6].Visible = false;
            dataGridViewEmp.Columns[7].HeaderText = "תמונה";
            dataGridViewEmp.Columns[8].Visible = false;
            dataGridViewEmp.RowTemplate.Height = 90;

            for (int i = 0; i < dataGridViewEmp.Columns.Count; i++)
                if (dataGridViewEmp.Columns[i] is DataGridViewImageColumn)
                    ((DataGridViewImageColumn)dataGridViewEmp.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;

            foreach (var column in dataGridViewEmp.Columns)
                if (column is DataGridViewImageColumn)
                    (column as DataGridViewImageColumn).DefaultCellStyle.NullValue = Resources.defaultProfileImage;

            roleDataGrid.DataSource = roleLST;
            roleDataGrid.Columns[0].Visible = false;
            roleDataGrid.Columns[1].HeaderText = "תפקיד";
            roleDataGrid.Columns[1].Width = 150;
            roleDataGrid.Columns[2].HeaderText = "תאיור";
            roleDataGrid.Columns[2].Width = 300;
            roleDataGrid.Columns[3].Visible = false;
            roleDataGrid.Columns[4].HeaderText = "משכורת לשעה";
            roleDataGrid.Columns[5].Visible = false;


            editComboBoxEmpChose.DataSource = empList;
            editComboBoxEmpChose.DisplayMember = "fullName";
            editComboBoxEmpChose.ValueMember = "Id";

            addEmpRoleComboBox.DataSource = roleLST;
            addEmpRoleComboBox.DisplayMember = "roleName";
            addEmpRoleComboBox.ValueMember = "Id";

            roleChoseDataGrid.DataSource = roleLST;
            roleChoseDataGrid.Columns[0].Visible = false;
            roleChoseDataGrid.Columns[1].HeaderText = "תפקיד";
            roleChoseDataGrid.Columns[1].Width = 150;
            roleChoseDataGrid.Columns[2].Visible = false;
            roleChoseDataGrid.Columns[3].Visible = false;
            roleChoseDataGrid.Columns[4].Visible = false;
            roleChoseDataGrid.Columns[5].Visible = false;

            editEmpRoleComboBox.DataSource = roleLST;
            editEmpRoleComboBox.DisplayMember = "roleName";
            editEmpRoleComboBox.ValueMember = "Id";

            editRoleComboBox.DataSource = roleLST;
            editRoleComboBox.DisplayMember = "roleName";
            editRoleComboBox.ValueMember = "Id";
        }

        private void EditComboBoxEmpChose_SelectedIndexChanged(object sender, EventArgs e)
        {
            choseEmp = (empTBL)editComboBoxEmpChose.SelectedItem;
            if (choseEmp.img == null)
                editEmpPictureBox.Image = new Bitmap(Resources.defaultProfileImage);
            else
                using (MemoryStream mStrem = new MemoryStream(choseEmp.img))
                    editEmpPictureBox.Image = Image.FromStream(mStrem);

            editEmpAddress.Text = choseEmp.address.Trim();
            editEmpbDateDTP.Value = choseEmp.bDate;
            editEmpEmail.Text = choseEmp.email.Trim();
            editEmpStartDateDTP.Value = choseEmp.startDate;
            editEmpFirstName.Text = choseEmp.firstName.Trim();
            editComboBoxEmpGender.SelectedIndex = choseEmp.gender ? 0 : 1;
            editEmpLastName.Text = choseEmp.lastName.Trim();
            editEmpPhone.Text = choseEmp.phone.Trim();
            editCheckBoxIsActive.Checked = choseEmp.isActive;
            editEmpInageDirLBL.Text = "";
            if (choseEmp.nots != null)
                editEmpNots.Text = choseEmp.nots.Trim();
            roleTBL empRole = (from x in db.roleTBL where x.Id == choseEmp.roleID select x).FirstOrDefault();
            editEmpRoleComboBox.SelectedItem = empRole;
        }


        private void EditCheckBoxIsActive_CheckedChanged_1(object sender, EventArgs e)
        {
            editEmpLeaveReason.Visible = !editCheckBoxIsActive.Checked;
            leaveReasonLBL.Visible = !editCheckBoxIsActive.Checked;
        }

        private void AddRoleBTN_Click(object sender, EventArgs e)
        {
            if (!Tools.CheckName(addRoleName, Ep) || !Tools.CheckNum(addRoleSalaryUD, Ep))
            {
                MessageBox.Show("ישנה שגיאה");
                return;
            }

            roleTBL role = new roleTBL
            {
                description = addRoleDescription.Text.Trim(),
                roleName = addRoleName.Text.Trim(),
                HourSalary = (int)addRoleSalaryUD.Value
            };
            db.roleTBL.Add(role);
            db.SaveChanges();
            UpdateLists();
            MessageBox.Show("המקצוע התווסף בהצלחה");
            addRoleLBL.Text = "";
            addRoleDescription.Text = "";
            addRoleName.Text = "";

        }

        private void EditRoleBTN_Click(object sender, EventArgs e)
        {
            if (!Tools.CheckName(editRoleName, Ep) || !Tools.CheckNum(editRoleSalaryUD, Ep))
            {
                MessageBox.Show("ישנה שגיאה");
                return;
            }
            ChoseRole.description = editRoleDescription.Text.Trim();
            ChoseRole.roleName = editRoleName.Text.Trim();
            ChoseRole.isActive = isActiveCB.Checked;
            ChoseRole.HourSalary = (int)editRoleSalaryUD.Value;
            db.SaveChanges();
            MessageBox.Show("המקצוע עודכן בהצלחה");
            UpdateLists();
        }

        private void EditRoleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChoseRole = (roleTBL)editRoleComboBox.SelectedItem;
            editRoleName.Text = ChoseRole.roleName.Trim();
            editRoleDescription.Text = ChoseRole.description.Trim();
            editRoleSalaryUD.Value = ChoseRole.HourSalary;
            isActiveCB.Checked = ChoseRole.isActive;
        }

        private void AddEmpChoseImageBTN_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                addEmpInageDirLBL.Text = openFileDialog1.FileName;
                Image myImg = Image.FromFile(addEmpInageDirLBL.Text);
                Bitmap bt1 = (Bitmap)myImg;
                bt1 = Tools.ResizeImage(bt1, AddEmpPictureBox.Width, AddEmpPictureBox.Height);

                myImg = bt1;
                MemoryStream ms = new MemoryStream();
                myImg.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                addImgBytes = ms.ToArray();
                AddEmpPictureBox.Image = myImg;
            }
        }

        private void EditEmpChoseImageBTN_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                editEmpInageDirLBL.Text = openFileDialog1.FileName;
                Image myImg = Image.FromFile(editEmpInageDirLBL.Text);
                Bitmap bt1 = (Bitmap)myImg;
                bt1 = Tools.ResizeImage(bt1, editEmpPictureBox.Width, editEmpPictureBox.Height);

                myImg = bt1;
                MemoryStream ms = new MemoryStream();
                myImg.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                editImgBytes = ms.ToArray();
                editEmpPictureBox.Image = myImg;
            }
        }
        private void AddEmpFirstName_Leave(object sender, EventArgs e)
        {
            Tools.CheckName(addEmpFirstName, Ep);
        }

        private void AddEmpLastName_Leave(object sender, EventArgs e)
        {
            Tools.CheckName(addEmpLastName, Ep);
        }

        private void AddEmpPhone_Leave(object sender, EventArgs e)
        {
            Tools.CheckPhone(addEmpPhone, Ep);
        }

        private void AddEmpEmail_Leave(object sender, EventArgs e)
        {
            Tools.CheckEmail(addEmpEmail, Ep);
        }

        private void EditEmpFirstName_Leave(object sender, EventArgs e)
        {
            Tools.CheckName(editEmpFirstName, Ep);
        }

        private void EditEmpLastName_Leave(object sender, EventArgs e)
        {
            Tools.CheckName(editEmpLastName, Ep);
        }

        private void EditEmpPhone_Leave(object sender, EventArgs e)
        {
            Tools.CheckPhone(editEmpPhone, Ep);
        }

        private void EditEmpEmail_Leave(object sender, EventArgs e)
        {
            Tools.CheckEmail(editEmpEmail, Ep);
        }

        private void AddRoleName_Leave(object sender, EventArgs e)
        {
            Tools.CheckName(addRoleName, Ep);
        }

        private void EditRoleName_Leave(object sender, EventArgs e)
        {
            Tools.CheckName(editRoleName, Ep);
        }
     

        private void EmpSortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLists();
        }

        private void EmpSortActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLists();
        }

        private void OnlyActiveWorkCB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLists();
        }

        private void HourSelCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLists();
        }


        private void PrintBTN_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printEmpDoc;
            printPreviewDialog1.ShowDialog();
        }

        private void PrintWorkBTN_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printWorkDoc;
            printPreviewDialog1.ShowDialog();
        }

        private void PrintWorkDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            MyReports.DrawDataGridView(this.Font, e, "דוח מקצעות עובדים", roleDataGrid);
        }

        private void PrintEmpDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            MyReports.DrawDataGridView(this.Font, e, "דוח עובדים", dataGridViewEmp);
        }
    }

}
