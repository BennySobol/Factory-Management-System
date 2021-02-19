using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DrMelomad.Database;
using DrMelomad.Properties;
using Microsoft.Reporting.WinForms;

namespace DrMelomad.Win
{
    public partial class WorkTimeWin : Form
    {
        readonly dbEntities db = new dbEntities();
        public WorkTimeWin()
        {
            InitializeComponent();
        }

        private void EditEmpStartDateDTP_ValueChanged(object sender, EventArgs e)
        {
            workEndDTP.MinDate = workStartDTP.Value.AddHours(1);
        }

        private void WorkTimeWin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet.workHoursJoinedTBL' table. You can move, or remove it, as needed.
            this.workHoursJoinedTBLTableAdapter.Fill(this.dbDataSet.workHoursJoinedTBL);

            ReportParameter rp = new ReportParameter("hideDates", "false");
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp });
            workHoursJoinedTBLTableAdapter.Fill(dbDataSet.workHoursJoinedTBL);
            reportViewer1.RefreshReport();

            BackColor = (Color)Settings.Default["color"];

            allDatesRadioBTN.Checked = true;
            allWorkersRadioBTN.Checked = true;
            usualRadioBTN.Checked = true;
            allJobsRadioBTN.Checked = true;
            showDatesRadioBTN.Checked = true;

            List<roleTBL> roleLST = (from role in db.roleTBL orderby role.roleName select role).ToList();
            jobCB.DataSource = roleLST;
            jobCB.DisplayMember = "roleName";
            jobCB.ValueMember = "Id";


            List<empTBL> empLST = (from emp in db.empTBL orderby emp.fullName select emp).ToList();
            workerCB.DataSource = empLST;
            workerCB.DisplayMember = "fullName";
            workerCB.ValueMember = "Id";

            workEndDTP.MinDate = workStartDTP.Value.AddHours(5);
            choseEmpLV.Columns[0].Width = 250;
            foreach (empTBL emp in db.empTBL)
                choseEmpLV.Items.Add(emp.fullName);
        }

        private void ChoseEmpLV_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = choseEmpLV.Columns[e.ColumnIndex].Width;
        }

        private void allDatesRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            fromDTP.Enabled = false;
            toDTP.Enabled = false;
        }

        private void dateRangeRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            fromDTP.Enabled = true;
            toDTP.Enabled = true;
        }

        private void allWorkersRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            workerCB.Enabled = false;
            oneJobRadioBTN.Enabled = true;
        }

        private void oneWorkerRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            workerCB.Enabled = true;
            oneJobRadioBTN.Enabled = false;
            allJobsRadioBTN.Checked = true;
        }

        private void usualRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            workStartDTP.Enabled = false;
            workEndDTP.Enabled = false;
        }

        private void rangeRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            workStartDTP.Enabled = true;
            workEndDTP.Enabled = true;
        }

        private void EditRoleBTN_Click_1(object sender, EventArgs e)
        {
            if (!usualRadioBTN.Checked && workEndDTP.Value.Day < workStartDTP.Value.Day)
            {
                MessageBox.Show("!שעות העבודה אינם תקינים");
                return;
            }
            foreach (ListViewItem fullName in choseEmpLV.CheckedItems)
            {
                empTBL emp = (from x in db.empTBL where x.fullName == fullName.Text select x).FirstOrDefault();
                workHoursTBL work;
                if (usualRadioBTN.Checked)
                {
                    DateTime Today = DateTime.Today;
                    work = new workHoursTBL
                    {
                        startDate = new DateTime(Today.Year, Today.Month, Today.Day, 7, 00, 00),
                        endDate = new DateTime(Today.Year, Today.Month, Today.Day, 16, 30, 00),
                        workerID = emp.Id,
                        currentHourSalary = emp.roleTBL.HourSalary
                    };
                }
                else
                {
                    work = new workHoursTBL
                    {
                        startDate = workStartDTP.Value,
                        endDate = workEndDTP.Value,
                        workerID = emp.Id,
                        currentHourSalary = emp.roleTBL.HourSalary
                    };
                }

                db.workHoursTBL.Add(work);
            }
            db.SaveChanges();
            dbDataSet.workHoursJoinedTBL.Clear(); // Refresh workHoursJoinedTBL
            workHoursJoinedTBLTableAdapter.Fill(dbDataSet.workHoursJoinedTBL);
            MessageBox.Show("שעות העבודה התווספו בהצלחה");
        }


        private void oneJobRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            jobCB.Enabled = true;
        }

        private void allJobsRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            jobCB.Enabled = false;
        }

        private void createReportBTN_Click(object sender, EventArgs e)
        {
            tabCorttntrol1.SelectedTab = tabPage3;
            string filter = "";
            if (oneWorkerRadioBTN.Checked)
                filter += " AND fullName='" + ((empTBL)workerCB.SelectedItem).fullName.Replace("'", "''") + "'";

            if (dateRangeRadioBTN.Checked) // start??
                filter += " AND startDate <= '" + toDTP.Value.Date + "' AND startDate >= '" + fromDTP.Value.Date + "'";

            if (oneJobRadioBTN.Checked)
                filter += " AND roleName='" + ((roleTBL)jobCB.SelectedItem).roleName.Replace("'", "''") + "'";

            ReportParameter rp = new ReportParameter("hideDates", doNotShowDatesRadioBTN.Checked.ToString());
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp });
            workHoursJoinedTBLBindingSource.Filter = "true" + filter;
            workHoursJoinedTBLTableAdapter.Fill(dbDataSet.workHoursJoinedTBL);
            reportViewer1.RefreshReport();
        }

    }
}
