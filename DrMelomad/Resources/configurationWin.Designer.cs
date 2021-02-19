namespace DrMelomad.Win
{
    partial class ConfigurationWin
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
            this.dropMenuSpeedCB = new System.Windows.Forms.ComboBox();
            this.saveBTN = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorChoseBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clearBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dropMenuSpeedCB
            // 
            this.dropMenuSpeedCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropMenuSpeedCB.FormattingEnabled = true;
            this.dropMenuSpeedCB.Items.AddRange(new object[] {
            "ללא",
            "מהיר",
            "בינוני",
            "איטי"});
            this.dropMenuSpeedCB.Location = new System.Drawing.Point(206, 118);
            this.dropMenuSpeedCB.Name = "dropMenuSpeedCB";
            this.dropMenuSpeedCB.Size = new System.Drawing.Size(121, 21);
            this.dropMenuSpeedCB.TabIndex = 0;
            // 
            // saveBTN
            // 
            this.saveBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.saveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBTN.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.saveBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveBTN.Location = new System.Drawing.Point(626, 333);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(125, 40);
            this.saveBTN.TabIndex = 1;
            this.saveBTN.Text = "שמור שנויים";
            this.saveBTN.UseVisualStyleBackColor = false;
            this.saveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // colorChoseBTN
            // 
            this.colorChoseBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.colorChoseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorChoseBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.colorChoseBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.colorChoseBTN.Location = new System.Drawing.Point(63, 161);
            this.colorChoseBTN.Name = "colorChoseBTN";
            this.colorChoseBTN.Size = new System.Drawing.Size(125, 40);
            this.colorChoseBTN.TabIndex = 2;
            this.colorChoseBTN.Text = "בחר צבע רקע";
            this.colorChoseBTN.UseVisualStyleBackColor = false;
            this.colorChoseBTN.Click += new System.EventHandler(this.colorChoseBTN_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(60, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "מהירות סרגל התפריט";
            // 
            // clearBTN
            // 
            this.clearBTN.BackColor = System.Drawing.Color.Tomato;
            this.clearBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBTN.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clearBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearBTN.Location = new System.Drawing.Point(448, 333);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(125, 40);
            this.clearBTN.TabIndex = 4;
            this.clearBTN.Text = "אפס הגדרות";
            this.clearBTN.UseVisualStyleBackColor = false;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // ConfigurationWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 460);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorChoseBTN);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.dropMenuSpeedCB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfigurationWin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "configurationWin";
            this.Load += new System.EventHandler(this.ConfigurationWin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox dropMenuSpeedCB;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorChoseBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearBTN;
    }
}