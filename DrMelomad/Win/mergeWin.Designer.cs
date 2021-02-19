namespace DrMelomad.Win
{
    partial class mergeWin
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
            this.checkBTN = new System.Windows.Forms.Button();
            this.getNamesBTN = new System.Windows.Forms.Button();
            this.pastBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.cutBTN = new System.Windows.Forms.Button();
            this.copyBTN = new System.Windows.Forms.Button();
            this.namesRTB = new System.Windows.Forms.RichTextBox();
            this.mergeBTN = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dirTB = new System.Windows.Forms.TextBox();
            this.dirChoseBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.spaceCB = new System.Windows.Forms.ComboBox();
            this.mergeNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBTN
            // 
            this.checkBTN.BackColor = System.Drawing.Color.LightSeaGreen;
            this.checkBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.checkBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBTN.Location = new System.Drawing.Point(642, 106);
            this.checkBTN.Name = "checkBTN";
            this.checkBTN.Size = new System.Drawing.Size(75, 28);
            this.checkBTN.TabIndex = 18;
            this.checkBTN.Text = "בדוק";
            this.checkBTN.UseVisualStyleBackColor = false;
            this.checkBTN.Click += new System.EventHandler(this.CheckBTN_Click);
            // 
            // getNamesBTN
            // 
            this.getNamesBTN.BackColor = System.Drawing.Color.LightSeaGreen;
            this.getNamesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getNamesBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.getNamesBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.getNamesBTN.Location = new System.Drawing.Point(519, 105);
            this.getNamesBTN.Name = "getNamesBTN";
            this.getNamesBTN.Size = new System.Drawing.Size(117, 28);
            this.getNamesBTN.TabIndex = 17;
            this.getNamesBTN.Text = "שמות מהתיקיה";
            this.getNamesBTN.UseVisualStyleBackColor = false;
            this.getNamesBTN.Click += new System.EventHandler(this.GetNamesBTN_Click);
            // 
            // pastBTN
            // 
            this.pastBTN.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pastBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pastBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.pastBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pastBTN.Location = new System.Drawing.Point(88, 106);
            this.pastBTN.Name = "pastBTN";
            this.pastBTN.Size = new System.Drawing.Size(75, 28);
            this.pastBTN.TabIndex = 16;
            this.pastBTN.Text = "הדבק";
            this.pastBTN.UseVisualStyleBackColor = false;
            this.pastBTN.Click += new System.EventHandler(this.PastBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.BackColor = System.Drawing.Color.LightSeaGreen;
            this.clearBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.clearBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearBTN.Location = new System.Drawing.Point(331, 105);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(75, 29);
            this.clearBTN.TabIndex = 14;
            this.clearBTN.Text = "נקה";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.ClearBTN_Click);
            // 
            // cutBTN
            // 
            this.cutBTN.BackColor = System.Drawing.Color.LightSeaGreen;
            this.cutBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cutBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cutBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cutBTN.Location = new System.Drawing.Point(250, 106);
            this.cutBTN.Name = "cutBTN";
            this.cutBTN.Size = new System.Drawing.Size(75, 28);
            this.cutBTN.TabIndex = 14;
            this.cutBTN.Text = "חתוך";
            this.cutBTN.UseVisualStyleBackColor = false;
            this.cutBTN.Click += new System.EventHandler(this.CutBTN_Click);
            // 
            // copyBTN
            // 
            this.copyBTN.BackColor = System.Drawing.Color.LightSeaGreen;
            this.copyBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyBTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.copyBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.copyBTN.Location = new System.Drawing.Point(169, 106);
            this.copyBTN.Name = "copyBTN";
            this.copyBTN.Size = new System.Drawing.Size(75, 28);
            this.copyBTN.TabIndex = 13;
            this.copyBTN.Text = "העתק";
            this.copyBTN.UseVisualStyleBackColor = false;
            this.copyBTN.Click += new System.EventHandler(this.CopyBTN_Click);
            // 
            // namesRTB
            // 
            this.namesRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.namesRTB.Location = new System.Drawing.Point(88, 140);
            this.namesRTB.MaxLength = 15000;
            this.namesRTB.Name = "namesRTB";
            this.namesRTB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.namesRTB.Size = new System.Drawing.Size(629, 141);
            this.namesRTB.TabIndex = 11;
            this.namesRTB.Text = "";
            this.namesRTB.TextChanged += new System.EventHandler(this.NamesRTB_TextChanged);
            this.namesRTB.Leave += new System.EventHandler(this.NamesRTB_Leave);
            // 
            // mergeBTN
            // 
            this.mergeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.mergeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mergeBTN.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.mergeBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mergeBTN.Location = new System.Drawing.Point(88, 312);
            this.mergeBTN.Name = "mergeBTN";
            this.mergeBTN.Size = new System.Drawing.Size(75, 38);
            this.mergeBTN.TabIndex = 10;
            this.mergeBTN.Text = "מזג";
            this.mergeBTN.UseVisualStyleBackColor = false;
            this.mergeBTN.Click += new System.EventHandler(this.MergeBTN_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "fileDialog";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dirTB
            // 
            this.dirTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dirTB.Location = new System.Drawing.Point(429, 363);
            this.dirTB.MaxLength = 500;
            this.dirTB.Name = "dirTB";
            this.dirTB.ReadOnly = true;
            this.dirTB.Size = new System.Drawing.Size(288, 24);
            this.dirTB.TabIndex = 19;
            this.dirTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dirChoseBTN
            // 
            this.dirChoseBTN.BackColor = System.Drawing.Color.MediumPurple;
            this.dirChoseBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dirChoseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dirChoseBTN.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.dirChoseBTN.ForeColor = System.Drawing.Color.Transparent;
            this.dirChoseBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dirChoseBTN.Location = new System.Drawing.Point(590, 312);
            this.dirChoseBTN.Name = "dirChoseBTN";
            this.dirChoseBTN.Size = new System.Drawing.Size(127, 38);
            this.dirChoseBTN.TabIndex = 12;
            this.dirChoseBTN.Text = "בחר תיקיה";
            this.dirChoseBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dirChoseBTN.UseVisualStyleBackColor = false;
            this.dirChoseBTN.Click += new System.EventHandler(this.DirChoseBTN_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(279, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "מרווח בין רכיבים";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spaceCB
            // 
            this.spaceCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spaceCB.FormattingEnabled = true;
            this.spaceCB.Items.AddRange(new object[] {
            "שורה",
            "עמוד חדש"});
            this.spaceCB.Location = new System.Drawing.Point(219, 30);
            this.spaceCB.Name = "spaceCB";
            this.spaceCB.Size = new System.Drawing.Size(60, 21);
            this.spaceCB.TabIndex = 83;
            // 
            // mergeNameTB
            // 
            this.mergeNameTB.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.mergeNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mergeNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mergeNameTB.Location = new System.Drawing.Point(427, 33);
            this.mergeNameTB.MaxLength = 40;
            this.mergeNameTB.Name = "mergeNameTB";
            this.mergeNameTB.Size = new System.Drawing.Size(170, 20);
            this.mergeNameTB.TabIndex = 85;
            this.mergeNameTB.Leave += new System.EventHandler(this.MergeNameTB_Leave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(603, 33);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 84;
            this.label2.Text = "שם קובץ המיזוג";
            // 
            // mergeWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 460);
            this.Controls.Add(this.mergeNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spaceCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBTN);
            this.Controls.Add(this.getNamesBTN);
            this.Controls.Add(this.pastBTN);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.cutBTN);
            this.Controls.Add(this.copyBTN);
            this.Controls.Add(this.dirChoseBTN);
            this.Controls.Add(this.namesRTB);
            this.Controls.Add(this.mergeBTN);
            this.Controls.Add(this.dirTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mergeWin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "mergeWin";
            this.Load += new System.EventHandler(this.MergeWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkBTN;
        private System.Windows.Forms.Button getNamesBTN;
        private System.Windows.Forms.Button pastBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Button cutBTN;
        private System.Windows.Forms.Button copyBTN;
        private System.Windows.Forms.Button dirChoseBTN;
        private System.Windows.Forms.RichTextBox namesRTB;
        private System.Windows.Forms.Button mergeBTN;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox dirTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox spaceCB;
        private System.Windows.Forms.TextBox mergeNameTB;
        private System.Windows.Forms.Label label2;
    }
}