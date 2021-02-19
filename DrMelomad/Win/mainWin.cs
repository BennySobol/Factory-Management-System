using DrMelomad.Properties;
using DrMelomad.Win;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrMelomad
{
    public partial class MainWin : Form
    {
        private bool isOpen = true;
        public bool MouseDownFlag;
        public int movX;
        public int movY;

        public MainWin()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuPanel.Size = new Size(180, 600);
            formPanel.Size = new Size (1100, 560);
            menuPanel.BringToFront();
            formPanel.SendToBack();
            pointer.Location = new Point(- 20 , -20);
            expBTN.Image = new Bitmap(Resources.pie_chart, new Size((int)(expBTN.Height / 1.2), (int)(expBTN.Height / 1.2)));
            ordBTN.Image = new Bitmap(Resources.box, new Size((int)(expBTN.Height / 1.2), (int)(expBTN.Height / 1.2)));
            cusBTN.Image = new Bitmap(Resources.user, new Size((int)(expBTN.Height / 1.2), (int)(expBTN.Height / 1.2)));
            stoBTN.Image = new Bitmap(Resources.clock, new Size((int)(expBTN.Height / 1.1), (int)(expBTN.Height / 1.1)));
            supBTN.Image = new Bitmap(Resources.user_1, new Size((int)(expBTN.Height / 1.2), (int)(expBTN.Height / 1.2)));
            proBTN.Image = new Bitmap(Resources.soap, new Size((int)(expBTN.Height / 1.2), (int)(expBTN.Height / 1.2)));
            empBTN.Image = new Bitmap(Resources.user_2, new Size((int)(expBTN.Height / 1.2), (int)(expBTN.Height / 1.2)));
            setBTN.Image = new Bitmap(Resources.settings, new Size((int)(expBTN.Height / 1.2), (int)(expBTN.Height / 1.2)));
            mergeBTN.Image = new Bitmap(Resources.merge, new Size((int)(expBTN.Height / 1.2), (int)(expBTN.Height / 1.2)));

        }

        private void EmpBTN_Click(object sender, EventArgs e)
        {
            if (headerLBL.Text != empBTN.Text)
            {
                empBTN.Enabled = false;
                headerLBL.Text = empBTN.Text;
                Highlight(empBTN);
                pointer.Location = new Point(empBTN.Location.X - 15, empBTN.Location.Y);
                EmpWin emp = new EmpWin { TopLevel = false, AutoScroll = true };
                formPanel.Controls.Clear();
                formPanel.Controls.Add(emp);
                emp.FormBorderStyle = FormBorderStyle.None;
                emp.Show();
                empBTN.Enabled = true;
            }
        }

        private void SupBTN_Click(object sender, EventArgs e)
        {
            if (headerLBL.Text != supBTN.Text)
            {
                supBTN.Enabled = false;
                headerLBL.Text = supBTN.Text;
                Highlight(supBTN);
                pointer.Location = new Point(supBTN.Location.X - 15, supBTN.Location.Y);
                supplierWin supplier = new supplierWin{ TopLevel = false, AutoScroll = true };
                formPanel.Controls.Clear();
                formPanel.Controls.Add(supplier);
                supplier.FormBorderStyle = FormBorderStyle.None;
                supplier.Show();
                supBTN.Enabled = true;
            }

        }

        private void SetBTN_Click(object sender, EventArgs e)
        {
            if (headerLBL.Text != setBTN.Text)
            {
                setBTN.Enabled = false;
                headerLBL.Text = setBTN.Text;
                Highlight(setBTN);
                pointer.Location = new Point(setBTN.Location.X - 15, setBTN.Location.Y);
                ConfigurationWin configurationr = new ConfigurationWin{ TopLevel = false, AutoScroll = true };

                formPanel.Controls.Clear();
                formPanel.Controls.Add(configurationr);
                configurationr.FormBorderStyle = FormBorderStyle.None;
                configurationr.Show();
                setBTN.Enabled = true;
            }
        }

        private void ProBTN_Click(object sender, EventArgs e)
        {
            if (headerLBL.Text != proBTN.Text)
            {
                proBTN.Enabled = false;
                headerLBL.Text = proBTN.Text;
                Highlight(proBTN);
                pointer.Location = new Point(proBTN.Location.X - 15, proBTN.Location.Y);
                PrintCategoryBTN items = new PrintCategoryBTN{ TopLevel = false, AutoScroll = true };
                formPanel.Controls.Clear();
                formPanel.Controls.Add(items);
                items.FormBorderStyle = FormBorderStyle.None;
                items.Show();
                proBTN.Enabled = true;
            }
        }

        private void StoBTN_Click(object sender, EventArgs e)
        {
            if (headerLBL.Text != stoBTN.Text)
            {
                stoBTN.Enabled = false;
                headerLBL.Text = stoBTN.Text;
                Highlight(stoBTN);
                pointer.Location = new Point(stoBTN.Location.X - 15, stoBTN.Location.Y);
                WorkTimeWin storage = new WorkTimeWin { TopLevel = false, AutoScroll = true };
                formPanel.Controls.Clear();
                formPanel.Controls.Add(storage);
                storage.FormBorderStyle = FormBorderStyle.None;
                storage.Show();
                stoBTN.Enabled = true;
            }
        }

        private void ExpBTN_Click(object sender, EventArgs e)
        {
            if (headerLBL.Text != expBTN.Text)
            {
                expBTN.Enabled = false;
                headerLBL.Text = expBTN.Text;
                Highlight(expBTN);
                pointer.Location = new Point(expBTN.Location.X - 15, expBTN.Location.Y);
                ChartsWin export = new ChartsWin{ TopLevel = false, AutoScroll = true };
                formPanel.Controls.Clear();
                formPanel.Controls.Add(export);
                export.FormBorderStyle = FormBorderStyle.None;
                export.Show();
                expBTN.Enabled = true;
            }
        }

        private void OrdBTN_Click(object sender, EventArgs e)
        {
            if (headerLBL.Text != ordBTN.Text)
            {
                ordBTN.Enabled = false;
                headerLBL.Text = ordBTN.Text;
                Highlight(ordBTN);
                pointer.Location = new Point(ordBTN.Location.X - 15, ordBTN.Location.Y);
                ordersWin orders = new ordersWin{ TopLevel = false, AutoScroll = true };
                formPanel.Controls.Clear();
                formPanel.Controls.Add(orders);
                orders.FormBorderStyle = FormBorderStyle.None;
                orders.Show();
                ordBTN.Enabled = true;
            }
        }

        private void CusBTN_Click(object sender, EventArgs e)
        {
            if (headerLBL.Text != cusBTN.Text)
            {
                cusBTN.Enabled = false;
                headerLBL.Text = cusBTN.Text;
                Highlight(cusBTN);
                pointer.Location = new Point(cusBTN.Location.X - 15, cusBTN.Location.Y);
                CustomersWin customers = new CustomersWin{ TopLevel = false, AutoScroll = true };
                formPanel.Controls.Clear();
                formPanel.Controls.Add(customers);
                customers.FormBorderStyle = FormBorderStyle.None;
                customers.Show();
                cusBTN.Enabled = true;
            }
        }

        private void mergeBTN_Click(object sender, EventArgs e)
        {
            if (headerLBL.Text != mergeBTN.Text)
            {
                mergeBTN.Enabled = false;
                headerLBL.Text = mergeBTN.Text;
                Highlight(mergeBTN);
                pointer.Location = new Point(mergeBTN.Location.X - 15, mergeBTN.Location.Y);
                mergeWin merge = new mergeWin { TopLevel = false, AutoScroll = true };
                formPanel.Controls.Clear();
                formPanel.Controls.Add(merge);
                merge.FormBorderStyle = FormBorderStyle.None;
                merge.Show();
                mergeBTN.Enabled = true;
            }
        }

        private void MinimizBTN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowBTN_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Highlight(Button sender)
        {
            foreach(Control btn in menuPanel.Controls)
                if(btn.Name != pointer.Name && btn.Name != showBTN.Name)
                    btn.BackColor = Color.FromArgb(192, 255, 192);
            sender.BackColor = Color.FromArgb(60, 179, 113);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            if (isOpen)
            {     
                menuPanel.Height -= int.Parse(Settings.Default["dropMenuSpeed"].ToString());
                if (menuPanel.Size.Height <= 40)
                {
                    menuPanel.Size = new Size(180, 40);
                    showBTN.Text = "=";
                    timer.Stop();
                    isOpen = false;
                }
            }
            else
            {
                showBTN.Text = "x";
                menuPanel.Height += int.Parse(Settings.Default["dropMenuSpeed"].ToString());
                if(menuPanel.Size.Height >= 600)
                {
                    timer.Stop();
                    isOpen = true;
                }
            }
        }


        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDownFlag = false;
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            movX = e.X + menuPanel.Width;
            movY = e.Y;
            MouseDownFlag = true;
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDownFlag)
                SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);   
        }

        private void MenuPanel_Leave(object sender, EventArgs e)
        {
            isOpen = true;
            timer.Start();
        }

        private void HeaderLBL_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDownFlag = false;
        }
   
        private void HeaderLBL_MouseDown(object sender, MouseEventArgs e)
        {
            movX = e.X + 839;
            movY = e.Y;
            MouseDownFlag = true;
        }

        private void HeaderLBL_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDownFlag)
                SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }
    }
}
