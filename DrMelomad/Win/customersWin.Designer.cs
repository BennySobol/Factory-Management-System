namespace DrMelomad.Win
{
    partial class CustomersWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersWin));
            this.printCustomerDoc = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabCorttntrol1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addCustomerBTN = new System.Windows.Forms.Button();
            this.addCustomerNotes = new System.Windows.Forms.RichTextBox();
            this.addEmpErrorLBL = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.addCustomerLastName = new System.Windows.Forms.TextBox();
            this.addCustomerAddress = new System.Windows.Forms.TextBox();
            this.addCustomerEmail = new System.Windows.Forms.TextBox();
            this.addCustomerPhone = new System.Windows.Forms.MaskedTextBox();
            this.addCustomerFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CustomerChoseDataGrid = new System.Windows.Forms.DataGridView();
            this.editComboBoxCustomerChose = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.editCustomerNotes = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.editCustomerLastName = new System.Windows.Forms.TextBox();
            this.editCustomerAddress = new System.Windows.Forms.TextBox();
            this.editCustomerEmail = new System.Windows.Forms.TextBox();
            this.editCustomerPhone = new System.Windows.Forms.MaskedTextBox();
            this.editCustomerFirstName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.editCustomerBTN = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label28 = new System.Windows.Forms.Label();
            this.customerSortComboBox = new System.Windows.Forms.ComboBox();
            this.printCustomersBTN = new System.Windows.Forms.Button();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Ep)).BeginInit();
            this.tabCorttntrol1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerChoseDataGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // printCustomerDoc
            // 
            this.printCustomerDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printCustomerDoc;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Ep
            // 
            this.Ep.ContainerControl = this;
            // 
            // tabCorttntrol1
            // 
            this.tabCorttntrol1.Controls.Add(this.tabPage1);
            this.tabCorttntrol1.Controls.Add(this.tabPage2);
            this.tabCorttntrol1.Controls.Add(this.tabPage3);
            this.tabCorttntrol1.Location = new System.Drawing.Point(12, 12);
            this.tabCorttntrol1.Name = "tabCorttntrol1";
            this.tabCorttntrol1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabCorttntrol1.RightToLeftLayout = true;
            this.tabCorttntrol1.SelectedIndex = 0;
            this.tabCorttntrol1.Size = new System.Drawing.Size(814, 436);
            this.tabCorttntrol1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.addCustomerBTN);
            this.tabPage1.Controls.Add(this.addCustomerNotes);
            this.tabPage1.Controls.Add(this.addEmpErrorLBL);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.addCustomerLastName);
            this.tabPage1.Controls.Add(this.addCustomerAddress);
            this.tabPage1.Controls.Add(this.addCustomerEmail);
            this.tabPage1.Controls.Add(this.addCustomerPhone);
            this.tabPage1.Controls.Add(this.addCustomerFirstName);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(806, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "הוספת לקוח";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(701, 125);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "כתובת";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(701, 154);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 49;
            this.label7.Text = "טלפון";
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(425, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "הערות";
            // 
            // addCustomerBTN
            // 
            this.addCustomerBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.addCustomerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomerBTN.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addCustomerBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addCustomerBTN.Location = new System.Drawing.Point(362, 274);
            this.addCustomerBTN.Name = "addCustomerBTN";
            this.addCustomerBTN.Size = new System.Drawing.Size(125, 40);
            this.addCustomerBTN.TabIndex = 15;
            this.addCustomerBTN.Text = "הוסף";
            this.addCustomerBTN.UseVisualStyleBackColor = false;
            this.addCustomerBTN.Click += new System.EventHandler(this.AddEmpBTN_Click);
            // 
            // addCustomerNotes
            // 
            this.addCustomerNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addCustomerNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addCustomerNotes.Location = new System.Drawing.Point(120, 66);
            this.addCustomerNotes.MaxLength = 950;
            this.addCustomerNotes.Name = "addCustomerNotes";
            this.addCustomerNotes.Size = new System.Drawing.Size(273, 79);
            this.addCustomerNotes.TabIndex = 42;
            this.addCustomerNotes.Text = "";
            // 
            // addEmpErrorLBL
            // 
            this.addEmpErrorLBL.AutoSize = true;
            this.addEmpErrorLBL.ForeColor = System.Drawing.Color.Red;
            this.addEmpErrorLBL.Location = new System.Drawing.Point(454, 317);
            this.addEmpErrorLBL.Name = "addEmpErrorLBL";
            this.addEmpErrorLBL.Size = new System.Drawing.Size(0, 17);
            this.addEmpErrorLBL.TabIndex = 38;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(217, 126);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 25);
            this.label19.TabIndex = 36;
            // 
            // addCustomerLastName
            // 
            this.addCustomerLastName.Location = new System.Drawing.Point(509, 96);
            this.addCustomerLastName.MaxLength = 20;
            this.addCustomerLastName.Name = "addCustomerLastName";
            this.addCustomerLastName.Size = new System.Drawing.Size(170, 23);
            this.addCustomerLastName.TabIndex = 12;
            this.addCustomerLastName.Leave += new System.EventHandler(this.AddCustomerLastName_Leave);
            // 
            // addCustomerAddress
            // 
            this.addCustomerAddress.Location = new System.Drawing.Point(509, 125);
            this.addCustomerAddress.MaxLength = 40;
            this.addCustomerAddress.Name = "addCustomerAddress";
            this.addCustomerAddress.Size = new System.Drawing.Size(170, 23);
            this.addCustomerAddress.TabIndex = 11;
            // 
            // addCustomerEmail
            // 
            this.addCustomerEmail.Location = new System.Drawing.Point(509, 183);
            this.addCustomerEmail.MaxLength = 40;
            this.addCustomerEmail.Multiline = true;
            this.addCustomerEmail.Name = "addCustomerEmail";
            this.addCustomerEmail.Size = new System.Drawing.Size(170, 23);
            this.addCustomerEmail.TabIndex = 9;
            this.addCustomerEmail.Leave += new System.EventHandler(this.AddCustomerEmail_Leave);
            // 
            // addCustomerPhone
            // 
            this.addCustomerPhone.Location = new System.Drawing.Point(509, 154);
            this.addCustomerPhone.Mask = "999-000-0000";
            this.addCustomerPhone.Name = "addCustomerPhone";
            this.addCustomerPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addCustomerPhone.Size = new System.Drawing.Size(170, 23);
            this.addCustomerPhone.TabIndex = 8;
            this.addCustomerPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addCustomerPhone.Leave += new System.EventHandler(this.AddCustomerPhone_Leave);
            // 
            // addCustomerFirstName
            // 
            this.addCustomerFirstName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.addCustomerFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addCustomerFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addCustomerFirstName.Location = new System.Drawing.Point(509, 67);
            this.addCustomerFirstName.MaxLength = 20;
            this.addCustomerFirstName.Name = "addCustomerFirstName";
            this.addCustomerFirstName.Size = new System.Drawing.Size(170, 23);
            this.addCustomerFirstName.TabIndex = 7;
            this.addCustomerFirstName.Leave += new System.EventHandler(this.AddCustomerFirstName_Leave);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(688, 183);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "כתובת מייל";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(701, 96);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "שם משפחה";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(717, 66);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "שם פרטי";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CustomerChoseDataGrid);
            this.tabPage2.Controls.Add(this.editComboBoxCustomerChose);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.editCustomerNotes);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.editCustomerLastName);
            this.tabPage2.Controls.Add(this.editCustomerAddress);
            this.tabPage2.Controls.Add(this.editCustomerEmail);
            this.tabPage2.Controls.Add(this.editCustomerPhone);
            this.tabPage2.Controls.Add(this.editCustomerFirstName);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.editCustomerBTN);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(22)));
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(806, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "עדכון פריטי לקוח";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CustomerChoseDataGrid
            // 
            this.CustomerChoseDataGrid.AllowUserToAddRows = false;
            this.CustomerChoseDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CustomerChoseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CustomerChoseDataGrid.Location = new System.Drawing.Point(19, 83);
            this.CustomerChoseDataGrid.Name = "CustomerChoseDataGrid";
            this.CustomerChoseDataGrid.ReadOnly = true;
            this.CustomerChoseDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CustomerChoseDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.CustomerChoseDataGrid.Size = new System.Drawing.Size(390, 218);
            this.CustomerChoseDataGrid.TabIndex = 61;
            // 
            // editComboBoxCustomerChose
            // 
            this.editComboBoxCustomerChose.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editComboBoxCustomerChose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.editComboBoxCustomerChose.FormattingEnabled = true;
            this.editComboBoxCustomerChose.Location = new System.Drawing.Point(62, 54);
            this.editComboBoxCustomerChose.Name = "editComboBoxCustomerChose";
            this.editComboBoxCustomerChose.Size = new System.Drawing.Size(41, 21);
            this.editComboBoxCustomerChose.TabIndex = 33;
            this.editComboBoxCustomerChose.Visible = false;
            this.editComboBoxCustomerChose.SelectedIndexChanged += new System.EventHandler(this.EditComboBoxEmpChose_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(752, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 60;
            this.label5.Text = "הערות";
            // 
            // editCustomerNotes
            // 
            this.editCustomerNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editCustomerNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.editCustomerNotes.Location = new System.Drawing.Point(455, 182);
            this.editCustomerNotes.MaxLength = 950;
            this.editCustomerNotes.Name = "editCustomerNotes";
            this.editCustomerNotes.Size = new System.Drawing.Size(245, 79);
            this.editCustomerNotes.TabIndex = 59;
            this.editCustomerNotes.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(425, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 58;
            // 
            // editCustomerLastName
            // 
            this.editCustomerLastName.Location = new System.Drawing.Point(530, 65);
            this.editCustomerLastName.MaxLength = 20;
            this.editCustomerLastName.Name = "editCustomerLastName";
            this.editCustomerLastName.Size = new System.Drawing.Size(170, 21);
            this.editCustomerLastName.TabIndex = 53;
            this.editCustomerLastName.Leave += new System.EventHandler(this.EditCustomerLastName_Leave);
            // 
            // editCustomerAddress
            // 
            this.editCustomerAddress.Location = new System.Drawing.Point(530, 92);
            this.editCustomerAddress.MaxLength = 40;
            this.editCustomerAddress.Name = "editCustomerAddress";
            this.editCustomerAddress.Size = new System.Drawing.Size(170, 21);
            this.editCustomerAddress.TabIndex = 52;
            // 
            // editCustomerEmail
            // 
            this.editCustomerEmail.Location = new System.Drawing.Point(530, 150);
            this.editCustomerEmail.MaxLength = 40;
            this.editCustomerEmail.Multiline = true;
            this.editCustomerEmail.Name = "editCustomerEmail";
            this.editCustomerEmail.Size = new System.Drawing.Size(170, 23);
            this.editCustomerEmail.TabIndex = 51;
            this.editCustomerEmail.Leave += new System.EventHandler(this.EditCustomerEmail_Leave);
            // 
            // editCustomerPhone
            // 
            this.editCustomerPhone.Location = new System.Drawing.Point(530, 121);
            this.editCustomerPhone.Mask = "999-000-0000";
            this.editCustomerPhone.Name = "editCustomerPhone";
            this.editCustomerPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editCustomerPhone.Size = new System.Drawing.Size(170, 21);
            this.editCustomerPhone.TabIndex = 50;
            this.editCustomerPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editCustomerPhone.Leave += new System.EventHandler(this.EditCustomerPhone_Leave);
            // 
            // editCustomerFirstName
            // 
            this.editCustomerFirstName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.editCustomerFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editCustomerFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editCustomerFirstName.Location = new System.Drawing.Point(530, 38);
            this.editCustomerFirstName.MaxLength = 20;
            this.editCustomerFirstName.Name = "editCustomerFirstName";
            this.editCustomerFirstName.Size = new System.Drawing.Size(170, 21);
            this.editCustomerFirstName.TabIndex = 49;
            this.editCustomerFirstName.Leave += new System.EventHandler(this.EditCustomerFirstName_Leave);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.Location = new System.Drawing.Point(752, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 18);
            this.label11.TabIndex = 48;
            this.label11.Text = "כתובת";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.Location = new System.Drawing.Point(721, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 18);
            this.label12.TabIndex = 47;
            this.label12.Text = "כתובת מייל";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.Location = new System.Drawing.Point(722, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 18);
            this.label13.TabIndex = 46;
            this.label13.Text = "שם משפחה";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label14.Location = new System.Drawing.Point(706, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 18);
            this.label14.TabIndex = 45;
            this.label14.Text = "טלפון";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label15.Location = new System.Drawing.Point(738, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 18);
            this.label15.TabIndex = 44;
            this.label15.Text = "שם פרטי";
            // 
            // label16
            // 
            this.label16.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label16.Location = new System.Drawing.Point(344, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 18);
            this.label16.TabIndex = 35;
            this.label16.Text = "בחר לקוח";
            // 
            // editCustomerBTN
            // 
            this.editCustomerBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.editCustomerBTN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editCustomerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCustomerBTN.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.editCustomerBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editCustomerBTN.Location = new System.Drawing.Point(482, 275);
            this.editCustomerBTN.Name = "editCustomerBTN";
            this.editCustomerBTN.Size = new System.Drawing.Size(125, 40);
            this.editCustomerBTN.TabIndex = 30;
            this.editCustomerBTN.Text = "ערוך";
            this.editCustomerBTN.UseVisualStyleBackColor = false;
            this.editCustomerBTN.Click += new System.EventHandler(this.EmpEditButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label28);
            this.tabPage3.Controls.Add(this.customerSortComboBox);
            this.tabPage3.Controls.Add(this.printCustomersBTN);
            this.tabPage3.Controls.Add(this.dataGridViewCustomers);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(806, 410);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "הצגת לקוחות";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label28.Location = new System.Drawing.Point(82, 85);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(56, 17);
            this.label28.TabIndex = 8;
            this.label28.Text = "מיין לפי:";
            // 
            // customerSortComboBox
            // 
            this.customerSortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerSortComboBox.FormattingEnabled = true;
            this.customerSortComboBox.Items.AddRange(new object[] {
            "שם פרטי ",
            "שם משפחה",
            "כתובת מייל"});
            this.customerSortComboBox.Location = new System.Drawing.Point(24, 112);
            this.customerSortComboBox.Name = "customerSortComboBox";
            this.customerSortComboBox.Size = new System.Drawing.Size(111, 21);
            this.customerSortComboBox.TabIndex = 7;
            this.customerSortComboBox.SelectedIndexChanged += new System.EventHandler(this.EmpSortComboBox_SelectedIndexChanged);
            // 
            // printCustomersBTN
            // 
            this.printCustomersBTN.BackColor = System.Drawing.Color.LightSeaGreen;
            this.printCustomersBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printCustomersBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.printCustomersBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.printCustomersBTN.Location = new System.Drawing.Point(67, 30);
            this.printCustomersBTN.Name = "printCustomersBTN";
            this.printCustomersBTN.Size = new System.Drawing.Size(65, 32);
            this.printCustomersBTN.TabIndex = 1;
            this.printCustomersBTN.Text = "הדפס";
            this.printCustomersBTN.UseVisualStyleBackColor = false;
            this.printCustomersBTN.Click += new System.EventHandler(this.PrintCustomersBTN_Click);
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(144, 15);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.Size = new System.Drawing.Size(652, 376);
            this.dataGridViewCustomers.TabIndex = 0;
            // 
            // CustomersWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 460);
            this.Controls.Add(this.tabCorttntrol1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomersWin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ניהול לקוחות";
            this.Load += new System.EventHandler(this.CustomertsWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ep)).EndInit();
            this.tabCorttntrol1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerChoseDataGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Drawing.Printing.PrintDocument printCustomerDoc;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ErrorProvider Ep;
        private System.Windows.Forms.TabControl tabCorttntrol1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox addCustomerNotes;
        private System.Windows.Forms.Label addEmpErrorLBL;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button addCustomerBTN;
        private System.Windows.Forms.TextBox addCustomerLastName;
        private System.Windows.Forms.TextBox addCustomerAddress;
        protected internal System.Windows.Forms.TextBox addCustomerEmail;
        private System.Windows.Forms.MaskedTextBox addCustomerPhone;
        private System.Windows.Forms.TextBox addCustomerFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox editCustomerNotes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox editCustomerLastName;
        private System.Windows.Forms.TextBox editCustomerAddress;
        protected internal System.Windows.Forms.TextBox editCustomerEmail;
        private System.Windows.Forms.MaskedTextBox editCustomerPhone;
        private System.Windows.Forms.TextBox editCustomerFirstName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button editCustomerBTN;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox customerSortComboBox;
        private System.Windows.Forms.Button printCustomersBTN;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.DataGridView CustomerChoseDataGrid;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox editComboBoxCustomerChose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}