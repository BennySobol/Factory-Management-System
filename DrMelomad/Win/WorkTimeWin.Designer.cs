namespace DrMelomad.Win
{
    partial class WorkTimeWin
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.workHoursJoinedTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new DrMelomad.dbDataSet();
            this.tabCorttntrol1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rangeRadioBTN = new System.Windows.Forms.RadioButton();
            this.usualRadioBTN = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.workStartDTP = new System.Windows.Forms.DateTimePicker();
            this.workEndDTP = new System.Windows.Forms.DateTimePicker();
            this.EditRoleBTN = new System.Windows.Forms.Button();
            this.choseEmpLV = new System.Windows.Forms.ListView();
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.showDatesRadioBTN = new System.Windows.Forms.RadioButton();
            this.doNotShowDatesRadioBTN = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.jobCB = new System.Windows.Forms.ComboBox();
            this.oneJobRadioBTN = new System.Windows.Forms.RadioButton();
            this.allJobsRadioBTN = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toDTP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.fromDTP = new System.Windows.Forms.DateTimePicker();
            this.dateRangeRadioBTN = new System.Windows.Forms.RadioButton();
            this.allDatesRadioBTN = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.workerCB = new System.Windows.Forms.ComboBox();
            this.oneWorkerRadioBTN = new System.Windows.Forms.RadioButton();
            this.allWorkersRadioBTN = new System.Windows.Forms.RadioButton();
            this.createReportBTN = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.workHoursJoinedTBLTableAdapter = new DrMelomad.dbDataSetTableAdapters.workHoursJoinedTBLTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.workHoursJoinedTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            this.tabCorttntrol1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // workHoursJoinedTBLBindingSource
            // 
            this.workHoursJoinedTBLBindingSource.DataMember = "workHoursJoinedTBL";
            this.workHoursJoinedTBLBindingSource.DataSource = this.dbDataSet;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabCorttntrol1
            // 
            this.tabCorttntrol1.Controls.Add(this.tabPage1);
            this.tabCorttntrol1.Controls.Add(this.tabPage2);
            this.tabCorttntrol1.Controls.Add(this.tabPage3);
            this.tabCorttntrol1.Location = new System.Drawing.Point(4, 12);
            this.tabCorttntrol1.Name = "tabCorttntrol1";
            this.tabCorttntrol1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabCorttntrol1.RightToLeftLayout = true;
            this.tabCorttntrol1.SelectedIndex = 0;
            this.tabCorttntrol1.Size = new System.Drawing.Size(814, 436);
            this.tabCorttntrol1.TabIndex = 76;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.EditRoleBTN);
            this.tabPage1.Controls.Add(this.choseEmpLV);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(22)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(806, 410);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "הוספת שעות עבודה";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rangeRadioBTN);
            this.groupBox1.Controls.Add(this.usualRadioBTN);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.workStartDTP);
            this.groupBox1.Controls.Add(this.workEndDTP);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(232, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(234, 153);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "שעות עבודה";
            // 
            // rangeRadioBTN
            // 
            this.rangeRadioBTN.AutoSize = true;
            this.rangeRadioBTN.Location = new System.Drawing.Point(131, 56);
            this.rangeRadioBTN.Name = "rangeRadioBTN";
            this.rangeRadioBTN.Size = new System.Drawing.Size(83, 19);
            this.rangeRadioBTN.TabIndex = 100;
            this.rangeRadioBTN.TabStop = true;
            this.rangeRadioBTN.Text = "תווח מסויים";
            this.rangeRadioBTN.UseVisualStyleBackColor = true;
            this.rangeRadioBTN.CheckedChanged += new System.EventHandler(this.rangeRadioBTN_CheckedChanged);
            // 
            // usualRadioBTN
            // 
            this.usualRadioBTN.AutoSize = true;
            this.usualRadioBTN.Location = new System.Drawing.Point(125, 31);
            this.usualRadioBTN.Name = "usualRadioBTN";
            this.usualRadioBTN.Size = new System.Drawing.Size(89, 19);
            this.usualRadioBTN.TabIndex = 99;
            this.usualRadioBTN.TabStop = true;
            this.usualRadioBTN.Text = "מ7 עד 16:30";
            this.usualRadioBTN.UseVisualStyleBackColor = true;
            this.usualRadioBTN.CheckedChanged += new System.EventHandler(this.usualRadioBTN_CheckedChanged);
            // 
            // label10
            // 
            this.label10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(122, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 18);
            this.label10.TabIndex = 69;
            this.label10.Text = "תאריך התחלה";
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(138, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 74;
            this.label1.Text = "תאריך סיום";
            // 
            // workStartDTP
            // 
            this.workStartDTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.workStartDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.workStartDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.workStartDTP.Location = new System.Drawing.Point(17, 78);
            this.workStartDTP.Name = "workStartDTP";
            this.workStartDTP.Size = new System.Drawing.Size(88, 22);
            this.workStartDTP.TabIndex = 71;
            // 
            // workEndDTP
            // 
            this.workEndDTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.workEndDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.workEndDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.workEndDTP.Location = new System.Drawing.Point(17, 106);
            this.workEndDTP.Name = "workEndDTP";
            this.workEndDTP.Size = new System.Drawing.Size(88, 22);
            this.workEndDTP.TabIndex = 72;
            // 
            // EditRoleBTN
            // 
            this.EditRoleBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.EditRoleBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditRoleBTN.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EditRoleBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditRoleBTN.Location = new System.Drawing.Point(341, 214);
            this.EditRoleBTN.Name = "EditRoleBTN";
            this.EditRoleBTN.Size = new System.Drawing.Size(125, 40);
            this.EditRoleBTN.TabIndex = 75;
            this.EditRoleBTN.Text = "הוסף";
            this.EditRoleBTN.UseVisualStyleBackColor = false;
            this.EditRoleBTN.Click += new System.EventHandler(this.EditRoleBTN_Click_1);
            // 
            // choseEmpLV
            // 
            this.choseEmpLV.AutoArrange = false;
            this.choseEmpLV.CheckBoxes = true;
            this.choseEmpLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader});
            this.choseEmpLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.choseEmpLV.GridLines = true;
            this.choseEmpLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.choseEmpLV.HideSelection = false;
            this.choseEmpLV.Location = new System.Drawing.Point(573, 40);
            this.choseEmpLV.Name = "choseEmpLV";
            this.choseEmpLV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.choseEmpLV.RightToLeftLayout = true;
            this.choseEmpLV.Size = new System.Drawing.Size(196, 295);
            this.choseEmpLV.TabIndex = 73;
            this.choseEmpLV.UseCompatibleStateImageBehavior = false;
            this.choseEmpLV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader
            // 
            this.columnHeader.Text = "שם העובד";
            this.columnHeader.Width = 157;
            // 
            // label16
            // 
            this.label16.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label16.Location = new System.Drawing.Point(689, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 18);
            this.label16.TabIndex = 37;
            this.label16.Text = "בחר עובדים";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label13.Location = new System.Drawing.Point(590, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 15);
            this.label13.TabIndex = 68;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.createReportBTN);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(806, 410);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "דוח שעות עבודה";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.showDatesRadioBTN);
            this.groupBox5.Controls.Add(this.doNotShowDatesRadioBTN);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox5.Location = new System.Drawing.Point(345, 153);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(232, 93);
            this.groupBox5.TabIndex = 104;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "תאריכי העבודה";
            // 
            // showDatesRadioBTN
            // 
            this.showDatesRadioBTN.AutoSize = true;
            this.showDatesRadioBTN.Location = new System.Drawing.Point(80, 27);
            this.showDatesRadioBTN.Name = "showDatesRadioBTN";
            this.showDatesRadioBTN.Size = new System.Drawing.Size(147, 17);
            this.showDatesRadioBTN.TabIndex = 99;
            this.showDatesRadioBTN.TabStop = true;
            this.showDatesRadioBTN.Text = "הצג את תאריכי העבודה";
            this.showDatesRadioBTN.UseVisualStyleBackColor = true;
            // 
            // doNotShowDatesRadioBTN
            // 
            this.doNotShowDatesRadioBTN.AutoSize = true;
            this.doNotShowDatesRadioBTN.Location = new System.Drawing.Point(57, 50);
            this.doNotShowDatesRadioBTN.Name = "doNotShowDatesRadioBTN";
            this.doNotShowDatesRadioBTN.Size = new System.Drawing.Size(170, 17);
            this.doNotShowDatesRadioBTN.TabIndex = 103;
            this.doNotShowDatesRadioBTN.TabStop = true;
            this.doNotShowDatesRadioBTN.Text = "אל תציג את תאריכי העבודה";
            this.doNotShowDatesRadioBTN.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.jobCB);
            this.groupBox2.Controls.Add(this.oneJobRadioBTN);
            this.groupBox2.Controls.Add(this.allJobsRadioBTN);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(599, 153);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(184, 130);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "מקצוע";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(92, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 102;
            this.label2.Text = "שם המקצוע";
            // 
            // jobCB
            // 
            this.jobCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobCB.FormattingEnabled = true;
            this.jobCB.Location = new System.Drawing.Point(55, 96);
            this.jobCB.Name = "jobCB";
            this.jobCB.Size = new System.Drawing.Size(121, 21);
            this.jobCB.TabIndex = 101;
            // 
            // oneJobRadioBTN
            // 
            this.oneJobRadioBTN.AutoSize = true;
            this.oneJobRadioBTN.Location = new System.Drawing.Point(82, 50);
            this.oneJobRadioBTN.Name = "oneJobRadioBTN";
            this.oneJobRadioBTN.Size = new System.Drawing.Size(97, 17);
            this.oneJobRadioBTN.TabIndex = 100;
            this.oneJobRadioBTN.TabStop = true;
            this.oneJobRadioBTN.Text = "מקצוע מסויים";
            this.oneJobRadioBTN.UseVisualStyleBackColor = true;
            this.oneJobRadioBTN.CheckedChanged += new System.EventHandler(this.oneJobRadioBTN_CheckedChanged);
            // 
            // allJobsRadioBTN
            // 
            this.allJobsRadioBTN.AutoSize = true;
            this.allJobsRadioBTN.Location = new System.Drawing.Point(85, 27);
            this.allJobsRadioBTN.Name = "allJobsRadioBTN";
            this.allJobsRadioBTN.Size = new System.Drawing.Size(94, 17);
            this.allJobsRadioBTN.TabIndex = 99;
            this.allJobsRadioBTN.TabStop = true;
            this.allJobsRadioBTN.Text = "כל המקצועות";
            this.allJobsRadioBTN.UseVisualStyleBackColor = true;
            this.allJobsRadioBTN.CheckedChanged += new System.EventHandler(this.allJobsRadioBTN_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.toDTP);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.fromDTP);
            this.groupBox4.Controls.Add(this.dateRangeRadioBTN);
            this.groupBox4.Controls.Add(this.allDatesRadioBTN);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(345, 19);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(232, 130);
            this.groupBox4.TabIndex = 101;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "תאריך";
            // 
            // label8
            // 
            this.label8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(136, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 104;
            this.label8.Text = "עד תאריך";
            // 
            // toDTP
            // 
            this.toDTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.toDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.toDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDTP.Location = new System.Drawing.Point(26, 92);
            this.toDTP.Name = "toDTP";
            this.toDTP.Size = new System.Drawing.Size(88, 22);
            this.toDTP.TabIndex = 103;
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(120, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 101;
            this.label4.Text = "מתאריך ";
            // 
            // fromDTP
            // 
            this.fromDTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fromDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.fromDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDTP.Location = new System.Drawing.Point(26, 64);
            this.fromDTP.Name = "fromDTP";
            this.fromDTP.Size = new System.Drawing.Size(88, 22);
            this.fromDTP.TabIndex = 102;
            // 
            // dateRangeRadioBTN
            // 
            this.dateRangeRadioBTN.AutoSize = true;
            this.dateRangeRadioBTN.Location = new System.Drawing.Point(120, 41);
            this.dateRangeRadioBTN.Name = "dateRangeRadioBTN";
            this.dateRangeRadioBTN.Size = new System.Drawing.Size(97, 17);
            this.dateRangeRadioBTN.TabIndex = 100;
            this.dateRangeRadioBTN.TabStop = true;
            this.dateRangeRadioBTN.Text = "תווך תאריכים";
            this.dateRangeRadioBTN.UseVisualStyleBackColor = true;
            this.dateRangeRadioBTN.CheckedChanged += new System.EventHandler(this.dateRangeRadioBTN_CheckedChanged);
            // 
            // allDatesRadioBTN
            // 
            this.allDatesRadioBTN.AutoSize = true;
            this.allDatesRadioBTN.Location = new System.Drawing.Point(123, 18);
            this.allDatesRadioBTN.Name = "allDatesRadioBTN";
            this.allDatesRadioBTN.Size = new System.Drawing.Size(94, 17);
            this.allDatesRadioBTN.TabIndex = 99;
            this.allDatesRadioBTN.TabStop = true;
            this.allDatesRadioBTN.Text = "כל התאריכים";
            this.allDatesRadioBTN.UseVisualStyleBackColor = true;
            this.allDatesRadioBTN.CheckedChanged += new System.EventHandler(this.allDatesRadioBTN_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.workerCB);
            this.groupBox3.Controls.Add(this.oneWorkerRadioBTN);
            this.groupBox3.Controls.Add(this.allWorkersRadioBTN);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(599, 19);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(184, 130);
            this.groupBox3.TabIndex = 100;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "עובד";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(123, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 102;
            this.label5.Text = "שם העבד";
            // 
            // workerCB
            // 
            this.workerCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerCB.FormattingEnabled = true;
            this.workerCB.Location = new System.Drawing.Point(55, 96);
            this.workerCB.Name = "workerCB";
            this.workerCB.Size = new System.Drawing.Size(121, 21);
            this.workerCB.TabIndex = 101;
            // 
            // oneWorkerRadioBTN
            // 
            this.oneWorkerRadioBTN.AutoSize = true;
            this.oneWorkerRadioBTN.Location = new System.Drawing.Point(89, 50);
            this.oneWorkerRadioBTN.Name = "oneWorkerRadioBTN";
            this.oneWorkerRadioBTN.Size = new System.Drawing.Size(90, 17);
            this.oneWorkerRadioBTN.TabIndex = 100;
            this.oneWorkerRadioBTN.TabStop = true;
            this.oneWorkerRadioBTN.Text = "עובד מסויים";
            this.oneWorkerRadioBTN.UseVisualStyleBackColor = true;
            this.oneWorkerRadioBTN.CheckedChanged += new System.EventHandler(this.oneWorkerRadioBTN_CheckedChanged);
            // 
            // allWorkersRadioBTN
            // 
            this.allWorkersRadioBTN.AutoSize = true;
            this.allWorkersRadioBTN.Location = new System.Drawing.Point(92, 27);
            this.allWorkersRadioBTN.Name = "allWorkersRadioBTN";
            this.allWorkersRadioBTN.Size = new System.Drawing.Size(87, 17);
            this.allWorkersRadioBTN.TabIndex = 99;
            this.allWorkersRadioBTN.TabStop = true;
            this.allWorkersRadioBTN.Text = "כל העובדים";
            this.allWorkersRadioBTN.UseVisualStyleBackColor = true;
            this.allWorkersRadioBTN.CheckedChanged += new System.EventHandler(this.allWorkersRadioBTN_CheckedChanged);
            // 
            // createReportBTN
            // 
            this.createReportBTN.BackColor = System.Drawing.Color.LightSeaGreen;
            this.createReportBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createReportBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.createReportBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createReportBTN.Location = new System.Drawing.Point(345, 251);
            this.createReportBTN.Name = "createReportBTN";
            this.createReportBTN.Size = new System.Drawing.Size(232, 32);
            this.createReportBTN.TabIndex = 79;
            this.createReportBTN.Text = "צור דו\"ח";
            this.createReportBTN.UseVisualStyleBackColor = false;
            this.createReportBTN.Click += new System.EventHandler(this.createReportBTN_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(806, 410);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "תצוגה מקדימה";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.workHoursJoinedTBLBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DrMelomad.WorkHoursReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 404);
            this.reportViewer1.TabIndex = 103;
            // 
            // workHoursJoinedTBLTableAdapter
            // 
            this.workHoursJoinedTBLTableAdapter.ClearBeforeFill = true;
            // 
            // WorkTimeWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 460);
            this.Controls.Add(this.tabCorttntrol1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkTimeWin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "WorkTimeWin";
            this.Load += new System.EventHandler(this.WorkTimeWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workHoursJoinedTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            this.tabCorttntrol1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCorttntrol1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button EditRoleBTN;
        private System.Windows.Forms.ListView choseEmpLV;
        private System.Windows.Forms.ColumnHeader columnHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker workEndDTP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker workStartDTP;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button createReportBTN;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker toDTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fromDTP;
        private System.Windows.Forms.RadioButton dateRangeRadioBTN;
        private System.Windows.Forms.RadioButton allDatesRadioBTN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox workerCB;
        private System.Windows.Forms.RadioButton oneWorkerRadioBTN;
        private System.Windows.Forms.RadioButton allWorkersRadioBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rangeRadioBTN;
        private System.Windows.Forms.RadioButton usualRadioBTN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox jobCB;
        private System.Windows.Forms.RadioButton oneJobRadioBTN;
        private System.Windows.Forms.RadioButton allJobsRadioBTN;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.RadioButton doNotShowDatesRadioBTN;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton showDatesRadioBTN;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource workHoursJoinedTBLBindingSource;
        private dbDataSetTableAdapters.workHoursJoinedTBLTableAdapter workHoursJoinedTBLTableAdapter;
    }
}