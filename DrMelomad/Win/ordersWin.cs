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
    public partial class ordersWin : Form
    {
        readonly dbEntities db = new dbEntities();

        List<ProductInCart> cartList;
        List<Order> ordersditail;

        public ordersWin()
        {
            InitializeComponent();
        }

        private void SetOrderBTN_Click(object sender, EventArgs e)
        {
            if (setOrderBTN.Text == "הוסף הזמנה")
            {
                foreach (ProductInCart productIncart in cartList)
                {
                    orderTBL order = new orderTBL();
                    customersTBL customer = (customersTBL)customerComboBox.SelectedItem;
                    productTBL product = (from x in db.productTBL where x.Id == productIncart.ProductID select x).FirstOrDefault();
                    product.unitsInStock -= productIncart.Amount;
                    order.customerID = customer.Id;
                    order.productsID = productIncart.ProductID;
                    order.currentOrderPrice = productIncart.Price * productIncart.Amount;
                    order.amount = productIncart.Amount;
                    order.orderDeadline = orderDeadlineDTP.Value;
                    order.orderStartDate = DateTime.Now;
                    order.isDiliverd = false;
                    orderTBL lastToken = (from x in db.orderTBL orderby x.orderToken descending select x).FirstOrDefault();
                    if (lastToken != null)
                        order.orderToken = lastToken.orderToken + 1;
                    else
                        order.orderToken = 0;
                    db.orderTBL.Add(order);
                }
                db.SaveChanges();
                UpdateLists();
                UpdateEditOrder();
                addCartDGV.DataSource = null;
                MessageBox.Show("ההזמנה התווספה");
            }
            else
            {
                if (cartList.Count() == 0)
                {
                    MessageBox.Show("אין אפשרות לעדכן לעגלה רייקה, אך ניתן למחוק את ההזמנה");
                    return;
                }
                Order orderToEdit = (Order)editOrdersCB.SelectedItem;
                if (orderToEdit != null)
                {
                    List<orderTBL> list = (from x in db.orderTBL where x.orderToken == orderToEdit.Tocken select x).ToList();
                    foreach (orderTBL orderIncart in list)
                    {
                        productTBL product = (from pro in db.productTBL where pro.Id == orderIncart.productsID select pro).FirstOrDefault();
                        product.unitsInStock += orderIncart.amount;
                        db.orderTBL.Remove(orderIncart);
                    }

                    foreach (ProductInCart productIncart in cartList)
                    {
                        orderTBL order = new orderTBL();
                        customersTBL customer = (customersTBL)customerComboBox.SelectedItem;
                        productTBL product = (from x in db.productTBL where x.Id == productIncart.ProductID select x).FirstOrDefault();
                        product.unitsInStock -= productIncart.Amount;
                        order.customerID = customer.Id;
                        order.productsID = productIncart.ProductID;
                        order.currentOrderPrice = productIncart.Price * productIncart.Amount;
                        order.amount = productIncart.Amount;
                        order.orderDeadline = orderDeadlineDTP.Value;
                        order.orderStartDate = orderToEdit.StartDate;
                        order.orderToken = orderToEdit.Tocken;
                        order.isDiliverd = orderToEdit.IsDiliverd;
                        db.orderTBL.Add(order);
                    }
                    db.SaveChanges();
                    UpdateLists();
                    addCartDGV.DataSource = null;
                    MessageBox.Show("ההזמנה עודכנה בהצלחה");
                    tabCorttntrol1.SelectedTab = tabPage2;
                    setOrderBTN.Text = "הוסף הזמנה";
                    tabPage1.Text = "הוספת הזמנה";
                }
            }
        }

        private void OrdersWin_Load(object sender, EventArgs e)
        {
            ordersJoinedTBLTableAdapter.Fill(dbDataSet.ordersJoinedTBL);

            orderDeadlineDTP.MinDate = DateTime.Now;
            orderDeadlineDTP.Value = DateTime.Now.AddDays(7);
            serchByCB.SelectedIndex = 0;
            BackColor = (Color)Settings.Default["color"];
            Tools.ColorDataGridView(addProductDGV);
            Tools.ColorDataGridView(addCartDGV);
            Tools.ColorDataGridView(editOrdersDGV);
            Tools.ColorDataGridView(editCartDGV);

            allDatesRadioBTN.Checked = true;
            allCustomersRadioBTN.Checked = true;
            allOrdersRadioBTN.Checked = true;
            allCostRadioBTN.Checked = true;
            allPriceRadioBTN.Checked = true;
            allProfitRadioBTN.Checked = true;
            allDedlinesRadioBTN.Checked = true;

            UpdateLists();

            List<customersTBL> customersList = (from x in db.customersTBL orderby x.fullName select x).ToList();
            customerComboBox.DataSource = customersList;
            customerComboBox.DisplayMember = "fullName";
            customerComboBox.ValueMember = "Id";

            customerCB.DataSource = customersList;
            customerCB.DisplayMember = "fullName";
            customerCB.ValueMember = "Id";

            customerComboBox.SelectedIndex = 0;
            customerCB.SelectedIndex = 0;

            reportViewer1.RefreshReport();
        }

        private void UpdateLists()
        {
            List<orderTBL> orders = (from x in db.orderTBL where !x.isDiliverd orderby x.orderStartDate select x).ToList();

            ordersditail = new List<Order>();
            var orderGroups = orders.GroupBy(a => a.orderToken);
            double price = 0;

            foreach (var order in orderGroups)
            {
                Order orderditail = new Order();
                foreach (var e in order)
                {
                    orderditail.CustomerName = e.customersTBL.fullName;
                    orderditail.Deadline = e.orderDeadline;
                    orderditail.Tocken = e.orderToken;
                    price += e.currentOrderPrice;
                    orderditail.IsDiliverd = e.isDiliverd;
                    orderditail.StartDate = e.orderStartDate;
                }
                orderditail.Price = price;
                ordersditail.Add(orderditail);
                price = 0;
            }

            editOrdersCB.DataSource = null;
            editOrdersCB.DataSource = ordersditail;

            editOrdersDGV.DataSource = null;
            editOrdersDGV.DataSource = ordersditail;
            editOrdersDGV.Columns[0].HeaderText = "שם לקוח";
            editOrdersDGV.Columns[0].Width = 100;
            editOrdersDGV.Columns[1].HeaderText = "תאריך הזמנה";
            editOrdersDGV.Columns[1].Width = 200;
            editOrdersDGV.Columns[2].Visible = false;
            editOrdersDGV.Columns[3].HeaderText = "סכום";
            editOrdersDGV.Columns[3].DefaultCellStyle.Format = "N1";
            editOrdersDGV.Columns[4].Visible = false;
            editOrdersDGV.Columns[5].Visible = false;
            editOrdersDGV.Columns[6].Visible = false;

            cartList = new List<ProductInCart>();
            List<productView> productView = (from x in db.productView where x.unitsInStock != 0 orderby x.productName select x).ToList();

            addProductDGV.DataSource = null;
            addProductDGV.DataSource = productView;
            addProductDGV.Columns[0].HeaderText = "שם מוצר";
            addProductDGV.Columns[0].Width = 170;
            addProductDGV.Columns[1].Visible = false;
            addProductDGV.Columns[2].Visible = false;
            addProductDGV.Columns[3].HeaderText = "מחיר ליחידה";
            addProductDGV.Columns[3].DefaultCellStyle.Format = "N1";
            addProductDGV.Columns[4].HeaderText = "כמות במלאי";
            addProductDGV.Columns[5].HeaderText = "תמונה";
            addProductDGV.Columns[6].Visible = false;
            addProductDGV.Columns[7].Visible = false;
            addProductDGV.RowTemplate.Height = 70;

            for (int i = 0; i < addProductDGV.Columns.Count; i++)
                if (addProductDGV.Columns[i] is DataGridViewImageColumn)
                    ((DataGridViewImageColumn)addProductDGV.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;

            foreach (var column in addProductDGV.Columns)
                if (column is DataGridViewImageColumn)
                    (column as DataGridViewImageColumn).DefaultCellStyle.NullValue = Resources.defaultProductImage;
            choseProductCB.DataSource = productView;

            amountUD.Maximum = ((productView)choseProductCB.SelectedItem).unitsInStock;
            try { amountUD.Value = 1; } catch { }
        }



        private void AddToCartBTN_Click(object sender, EventArgs e)
        {
            productView p1 = (productView)choseProductCB.SelectedItem;
            if((int)amountUD.Value == 0 || p1.unitsInStock == 0)
                return;

            ProductInCart newProductInCart = new ProductInCart
            {
                ProductName = p1.productName,
                Price = p1.productPrice,
                Amount = (int)amountUD.Value,
                ProductID = p1.Id
            };

            bool isExist = false;
            foreach (ProductInCart x in cartList)
                if (x.ProductID == newProductInCart.ProductID)
                {
                    isExist = true;
                    if (!(x.Amount + newProductInCart.Amount > amountUD.Maximum))
                    {
                        x.Amount += newProductInCart.Amount;
                        x.Calc();
                    }
                    else
                    {
                        x.Amount = (int)amountUD.Maximum;
                        x.Total = x.Amount * newProductInCart.Price;
                    }
                    break;
                }
            if (!isExist)
            {
                newProductInCart.Calc();
                cartList.Add(newProductInCart);
            }

            addCartDGV.DataSource = null;
            addCartDGV.DataSource = cartList;
            addCartDGV.Columns[0].HeaderText = "שם מוצר";
            addCartDGV.Columns[0].Width = 240;
            addCartDGV.Columns[1].HeaderText = "מחיר ליחידה";
            addCartDGV.Columns[1].DefaultCellStyle.Format = "N1";
            addCartDGV.Columns[2].HeaderText = "כמות";
            addCartDGV.Columns[3].Visible = false;
            addCartDGV.Columns[4].Visible = false;

            cartProductCB.DataSource = null;
            cartProductCB.DataSource = cartList;
            double sum = 0;

            foreach (ProductInCart x in cartList)
                sum += x.Total;
            sumTB.Text = sum.ToString("0.0");
        }

        private void ChoseProductCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            amountUD.Maximum = ((productView)choseProductCB.SelectedItem).unitsInStock;
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            ProductInCart choseProduct = (ProductInCart)cartProductCB.SelectedItem;
            ProductInCart saveCart = new ProductInCart();
            foreach (ProductInCart productInCart in cartList)
                if (choseProduct != null && productInCart.ProductID == choseProduct.ProductID)
                {
                    saveCart = productInCart;
                    break;
                }
            cartList.Remove(saveCart);
            addCartDGV.DataSource = null;
            addCartDGV.DataSource = cartList;
            addCartDGV.Columns[0].HeaderText = "שם מוצר";
            addCartDGV.Columns[0].Width = 240;
            addCartDGV.Columns[1].HeaderText = "מחיר ליחידה";
            addCartDGV.Columns[1].DefaultCellStyle.Format = "N1";
            addCartDGV.Columns[2].HeaderText = "כמות";
            addCartDGV.Columns[3].Visible = false;
            addCartDGV.Columns[4].Visible = false;

            cartProductCB.DataSource = null;
            cartProductCB.DataSource = cartList;
            double sum = 0;
            foreach (ProductInCart productInCart in cartList)
                sum += productInCart.Total;
            sumTB.Text = sum.ToString("0.0");
        }


        private void EditOrderSerchBTN_Click(object sender, EventArgs e)
        {
            string searchString = editOrderSerchTB.Text.Trim();
            editOrdersDGV.DataSource = null;
            editOrdersCB.DataSource = null;
            List<Order> orders;
            switch(serchByCB.SelectedIndex)
            {
                case 0:
                    orders = ordersditail.Where(x => !x.IsDiliverd && x.CustomerName.Contains(searchString) || x.StartDate.ToString().Contains(searchString) || x.Price.ToString().Contains(searchString)).ToList();
                    break;
                case 1:
                    orders = ordersditail.Where(x => !x.IsDiliverd && x.CustomerName.Contains(searchString)).ToList();
                    break;
                case 2:
                    orders = ordersditail.Where(x => !x.IsDiliverd && x.StartDate.ToString().Contains(searchString)).ToList();
                    break;
                default:
                    orders = ordersditail.Where(x => !x.IsDiliverd && x.Price.ToString().Contains(searchString)).ToList();
                    break;
            }
            editOrdersDGV.DataSource = orders;
            editOrdersDGV.Columns[0].HeaderText = "שם לקוח";
            editOrdersDGV.Columns[0].Width = 100;
            editOrdersDGV.Columns[1].HeaderText = "תאריך הזמנה";
            editOrdersDGV.Columns[1].Width = 200;
            editOrdersDGV.Columns[2].Visible = false;
            editOrdersDGV.Columns[3].HeaderText = "סכום";
            editOrdersDGV.Columns[3].DefaultCellStyle.Format = "N1";
            editOrdersDGV.Columns[4].Visible = false;
            editOrdersDGV.Columns[5].Visible = false;
            editOrdersDGV.Columns[6].Visible = false;
      
            editOrdersCB.DataSource = orders;
        }

        private void ClearSerchBTN_Click(object sender, EventArgs e)
        {
            editOrderSerchTB.Text = "";
            editOrdersDGV.DataSource = null;
            editOrdersCB.DataSource = null;
            UpdateLists();
        }

        private void EditOrdersCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEditOrder();
        }
        private void UpdateEditOrder()
        {
            Order order = (Order)editOrdersCB.SelectedItem;
            if (order != null)
            {
                List<orderView> orders = (from x in db.orderView where x.orderToken == order.Tocken select x).ToList();
                editCartDGV.DataSource = orders;
                editCartDGV.Columns[0].Visible = false;
                editCartDGV.Columns[1].HeaderText = "שם מוצר";
                editCartDGV.Columns[1].Width = 200;
                editCartDGV.Columns[2].HeaderText = "מחיר ליחידה";
                editCartDGV.Columns[2].DefaultCellStyle.Format = "N1";
                editCartDGV.Columns[3].HeaderText = "מחיר כולל";
                editCartDGV.Columns[3].DefaultCellStyle.Format = "N1";
                editCartDGV.Columns[4].HeaderText = "כמות";
                editCartDGV.Columns[5].Visible = false;
                editCartDGV.Columns[6].Visible = false;
                editCartDGV.Columns[7].Visible = false;
                editCartDGV.Columns[8].Visible = false;

                editCartCB.DataSource = orders;
                totalTB.Text = order.Price.ToString("0.0");
                customerLBL.Text = $"שם לקוח: {order.CustomerName}";
            }
            //else
            //    editCartDGV.DataSource = null;//nottodo
        }
        private void OrderFinishedBTN_Click(object sender, EventArgs e)
        {
            Form prompt = new Form()
            {
                Width = 200,
                Height = 115,
                FormBorderStyle = FormBorderStyle.None,
                Text = "מחיר עלות",
                StartPosition = FormStartPosition.CenterScreen,
            };
            Label textLabel = new Label() { Left = 110, Top = 20, Text = "עלויות" };
            NumericUpDown numericUD = new NumericUpDown() { Left = 50, Top = 50, Width = 100, Minimum = 1, Maximum = 100000, Value = 100, DecimalPlaces = 1 };
            Button confirmationBTN = new Button() { Text = "אישור", Left = 30, Width = 60, Top = 80, DialogResult = DialogResult.OK };
            Button cancelBTN = new Button() { Text = "ביטול", Left = 100, Width = 60, Top = 80, DialogResult = DialogResult.OK };

            confirmationBTN.Click += (sender2, e2) => { prompt.Close(); };
            cancelBTN.Click += (sender2, e2) => { prompt.DialogResult = DialogResult.Cancel; prompt.Close(); };

            Panel pnlTop = new Panel() { Height = 4, Dock = DockStyle.Top, BackColor = Color.Black };
            Panel pnlBottom = new Panel() { Height = 4, Dock = DockStyle.Bottom, BackColor = Color.Black };
            Panel pnlLeft = new Panel() { Width = 4, Dock = DockStyle.Left, BackColor = Color.Black };
            Panel pnlRight = new Panel() { Width = 4, Dock = DockStyle.Right, BackColor = Color.Black };
            prompt.Controls.Add(pnlRight);
            prompt.Controls.Add(pnlTop);
            prompt.Controls.Add(pnlLeft);
            prompt.Controls.Add(pnlBottom);
            prompt.Controls.Add(numericUD);

            prompt.Controls.Add(confirmationBTN);
            prompt.Controls.Add(cancelBTN);
            prompt.Controls.Add(textLabel);
  
            if (prompt.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("שליחת ההזמנה התבטלה");
                return;
            }
          
            float allOrderCost = (float)numericUD.Value;

            Order order = (Order)editOrdersCB.SelectedItem;
            if(order != null)
            {
                List<orderTBL> list = (from x in db.orderTBL where x.orderToken == order.Tocken select x).ToList();
                foreach (orderTBL orderIncart in list)
                {
                    orderIncart.isDiliverd = true;
                    orderIncart.allOrderCost = allOrderCost;
                    orderIncart.orderSendDate = DateTime.Now;
                }
                db.SaveChanges();
                MessageBox.Show("ההזמנה נשלחה");
                UpdateLists();
                UpdateEditOrder();
            }         
        }

        private void DeleteOrderBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("האם אתה בטוח שברצונך לבטל את ההזמנה", "ביטול הזמנה",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Order order = (Order)editOrdersCB.SelectedItem;
                if (order != null)
                {
                    List<orderTBL> list = (from x in db.orderTBL where x.orderToken == order.Tocken select x).ToList();
                    foreach (orderTBL orderIncart in list)
                    {
                        productTBL product = (from pro in db.productTBL where pro.Id == orderIncart.productsID select pro).FirstOrDefault();
                        product.unitsInStock += orderIncart.amount;
                        db.orderTBL.Remove(orderIncart);
                    }
                    db.SaveChanges();
                    UpdateLists();
                    UpdateEditOrder();
                }
            }
        }

        private void allCustomersRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            customerCB.Enabled = false;
        }

        private void oneCustomerRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            customerCB.Enabled = true;
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

        private void allPriceRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            fromPriceNUD.Enabled = false;
            toPriceNUD.Enabled = false;
        }

        private void priceRangeRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            fromPriceNUD.Enabled = true;
            toPriceNUD.Enabled = true;
        }

        private void allCostRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            fromCostNUD.Enabled = false;
            toCostNUD.Enabled = false;
        }

        private void costRangeRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            fromCostNUD.Enabled = true;
            toCostNUD.Enabled = true;
        }

        private void allProfitRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            fromProfitNUD.Enabled = false;
            toProfitNUD.Enabled = false;
        }

        private void profitRangeRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            fromProfitNUD.Enabled = true;
            toProfitNUD.Enabled = true;
        }

        private void editOrderBTN_Click(object sender, EventArgs e)
        {
            Order orderToEdit = (Order)editOrdersCB.SelectedItem;
            if (orderToEdit == null)
                return;
            try
            {
                orderDeadlineDTP.Value = orderToEdit.Deadline;
            }
            catch { }

            setOrderBTN.Text = "עדכן הזמנה";
            tabPage1.Text = "עדכון הזמנה";

            customerComboBox.SelectedItem = (from x in db.customersTBL where x.fullName == orderToEdit.CustomerName select x).FirstOrDefault();
            tabCorttntrol1.SelectedTab = tabPage1;
            cartList.Clear();
            foreach (orderView order in (List<orderView>)editCartDGV.DataSource)
            {
                ProductInCart newProductInCart = new ProductInCart
                {
                    ProductName = order.productName,
                    Price = order.productPrice,
                    Amount = order.amount,
                    ProductID = order.productID
                };
                newProductInCart.Calc();
                cartList.Add(newProductInCart);
            }
            addCartDGV.DataSource = null;
            addCartDGV.DataSource = cartList;

            addCartDGV.Columns[0].HeaderText = "שם מוצר";
            addCartDGV.Columns[0].Width = 240;
            addCartDGV.Columns[1].HeaderText = "מחיר ליחידה";
            addCartDGV.Columns[1].DefaultCellStyle.Format = "N1";
            addCartDGV.Columns[2].HeaderText = "כמות";
            addCartDGV.Columns[3].Visible = false;
            addCartDGV.Columns[4].Visible = false;

            cartProductCB.DataSource = null;
            cartProductCB.DataSource = cartList;

            double sum = 0;
            foreach (ProductInCart x in cartList)
            {
                x.Calc();
                sum += x.Total;
            }
            sumTB.Text = sum.ToString("0.0");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            tabCorttntrol1.SelectedTab = tabPage4;
            string filter = "";
            if (oneCustomerRadioBTN.Checked)
                filter += " AND fullName='" + ((customersTBL)customerComboBox.SelectedItem).fullName.Replace("'","''") + "'";

            if (dateRangeRadioBTN.Checked)
                filter += " AND orderStartDate <= '" + toDTP.Value.Date + "' AND orderStartDate >= '" + fromDTP.Value.Date + "'";

            if (ordersToSendRadioBTN.Checked)
                filter += " AND isDiliverd=false";

            else if (sentRadioBTN.Checked)
                filter += " AND isDiliverd=true";

            if (notLateRadioBTN.Checked)
                filter += " AND orderDeadline >  IsNull(orderSendDate, '" + DateTime.Now + "')";

            else if (lateRadioBTN.Checked)
                filter += " AND orderDeadline <  IsNull(orderSendDate, '" + DateTime.Now + "')";

            if (priceRangeRadioBTN.Checked)
                filter += " AND profit <= '" + (float)toPriceNUD.Value + "' AND profit >= '"+(float)fromPriceNUD.Value + "'";

            if (costRangeRadioBTN.Checked)
                filter += " AND orderCost <= '" + (float)toCostNUD.Value + "' AND orderCost >= '" + (float)fromCostNUD.Value + "'";

            if (profitRangeRadioBTN.Checked)
                filter += " AND profit <= '" + (float)toProfitNUD.Value + "' AND profit >= '" + (float)fromProfitNUD.Value + "'";

            ordersJoinedTBLBindingSource.Filter = "true" + filter;
            ordersJoinedTBLTableAdapter.Fill(dbDataSet.ordersJoinedTBL);
            reportViewer1.RefreshReport();
        }
    }
}


