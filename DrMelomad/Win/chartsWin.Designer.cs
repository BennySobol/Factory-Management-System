namespace DrMelomad.Win
{
    partial class ChartsWin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PayWorkersBTN = new System.Windows.Forms.TabPage();
            this.monthDTP = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.empChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.orderChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabCorttntrol1 = new System.Windows.Forms.TabControl();
            this.PayWorkersBTN.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderChart)).BeginInit();
            this.tabCorttntrol1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PayWorkersBTN
            // 
            this.PayWorkersBTN.Controls.Add(this.groupBox1);
            this.PayWorkersBTN.Controls.Add(this.label11);
            this.PayWorkersBTN.Controls.Add(this.groupBox3);
            this.PayWorkersBTN.Controls.Add(this.monthDTP);
            this.PayWorkersBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(22)));
            this.PayWorkersBTN.Location = new System.Drawing.Point(4, 22);
            this.PayWorkersBTN.Name = "PayWorkersBTN";
            this.PayWorkersBTN.Padding = new System.Windows.Forms.Padding(3);
            this.PayWorkersBTN.Size = new System.Drawing.Size(806, 410);
            this.PayWorkersBTN.TabIndex = 1;
            this.PayWorkersBTN.Text = "סטטיסטיקות";
            this.PayWorkersBTN.UseVisualStyleBackColor = true;
            // 
            // monthDTP
            // 
            this.monthDTP.CustomFormat = "YYYY MM";
            this.monthDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monthDTP.Location = new System.Drawing.Point(386, 6);
            this.monthDTP.Name = "monthDTP";
            this.monthDTP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.monthDTP.ShowUpDown = true;
            this.monthDTP.Size = new System.Drawing.Size(93, 21);
            this.monthDTP.TabIndex = 35;
            this.monthDTP.ValueChanged += new System.EventHandler(this.monthDTP_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.empChart);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(405, 29);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(396, 376);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "תשלום עובדים";
            // 
            // empChart
            // 
            chartArea2.Name = "ChartArea1";
            this.empChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.empChart.Legends.Add(legend2);
            this.empChart.Location = new System.Drawing.Point(5, 27);
            this.empChart.Name = "empChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            this.empChart.Series.Add(series2);
            this.empChart.Size = new System.Drawing.Size(386, 343);
            this.empChart.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(485, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "חודש";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.orderChart);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(5, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(389, 376);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "הזמנות";
            // 
            // orderChart
            // 
            chartArea1.Name = "ChartArea1";
            this.orderChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.orderChart.Legends.Add(legend1);
            this.orderChart.Location = new System.Drawing.Point(5, 27);
            this.orderChart.Name = "orderChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            series1.YValuesPerPoint = 2;
            this.orderChart.Series.Add(series1);
            this.orderChart.Size = new System.Drawing.Size(379, 343);
            this.orderChart.TabIndex = 1;
            // 
            // tabCorttntrol1
            // 
            this.tabCorttntrol1.Controls.Add(this.PayWorkersBTN);
            this.tabCorttntrol1.Location = new System.Drawing.Point(4, 12);
            this.tabCorttntrol1.Name = "tabCorttntrol1";
            this.tabCorttntrol1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabCorttntrol1.RightToLeftLayout = true;
            this.tabCorttntrol1.SelectedIndex = 0;
            this.tabCorttntrol1.Size = new System.Drawing.Size(814, 436);
            this.tabCorttntrol1.TabIndex = 77;
            // 
            // ChartsWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 460);
            this.Controls.Add(this.tabCorttntrol1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChartsWin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loadWin";
            this.Load += new System.EventHandler(this.ChartsWin_Load);
            this.PayWorkersBTN.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderChart)).EndInit();
            this.tabCorttntrol1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage PayWorkersBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart orderChart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart empChart;
        private System.Windows.Forms.DateTimePicker monthDTP;
        private System.Windows.Forms.TabControl tabCorttntrol1;
    }
}