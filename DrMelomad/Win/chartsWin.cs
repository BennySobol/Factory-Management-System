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
    public partial class ChartsWin : Form
    {
        readonly dbEntities db = new dbEntities();
        public ChartsWin()
        {
            InitializeComponent();
        }

        private void ChartsWin_Load(object sender, EventArgs e)
        {
            monthDTP.CustomFormat = "MMMM yyyy";

            BackColor = (Color)Settings.Default["color"];

            uptate();


        }

        private void monthDTP_ValueChanged(object sender, EventArgs e)
        {
            uptate();
        }
        private void uptate()
        {
            List<orderTBL> orders = (from x in db.orderTBL where x.isDiliverd && x.orderStartDate.Month == monthDTP.Value.Month && x.orderStartDate.Year == monthDTP.Value.Year select x).ToList();
            var ordergrops = orders.GroupBy(order => order.orderToken);

            double profits = 0;
            double costs = 0;
            double saveCost = 0;
            foreach (var orderGrop in ordergrops)
            {
                foreach (orderTBL order in orderGrop) // date responsive
                {
                    profits += order.currentOrderPrice;
                    saveCost = (double)order.allOrderCost;
                }
                costs += saveCost;
            }
            orderChart.Series["Series1"].Points.Clear();
            orderChart.Series["Series1"].Points.Add((double)profits);
            orderChart.Series["Series1"].Points[0].Color = Color.LightBlue;
            orderChart.Series["Series1"].Points[0].LegendText = "רווחים";
            orderChart.Series["Series1"].Points[0].Label = "₪" + profits.ToString("0.0"); ;
            orderChart.Series["Series1"].Points.Add((double)costs);
            orderChart.Series["Series1"].Points[1].Color = Color.Red;
            orderChart.Series["Series1"].Points[1].LegendText = "עלויות";
            orderChart.Series["Series1"].Points[1].Label = "₪" + costs.ToString("0.0");

            List<workHoursTBL> workHours = (from x in db.workHoursTBL where x.startDate.Month == monthDTP.Value.Month && x.startDate.Year == monthDTP.Value.Year orderby x.workerID select x).ToList();

            int index = 0;
            empChart.Series["Series1"].Points.Clear();
            var workHoursGrops = workHours.GroupBy(work => work.workerID);
            foreach (var workHour in workHoursGrops)
            {
                double MonthWorkHours = workHour.Sum(work => work.endDate.TimeOfDay.Subtract(work.startDate.TimeOfDay).TotalHours);

                int id = workHour.Select(s => s.workerID).ToList()[0];
                empTBL emp = (from w in db.empTBL where w.Id == id select w).FirstOrDefault();
                empChart.Series["Series1"].Points.Add(emp.roleTBL.HourSalary * MonthWorkHours);
                empChart.Series["Series1"].Points[index].LegendText = emp.fullName;
                empChart.Series["Series1"].Points[index].Label = "₪" + (emp.roleTBL.HourSalary * MonthWorkHours).ToString("0.0");
                 
                index++;
            }
        }

    }
}
