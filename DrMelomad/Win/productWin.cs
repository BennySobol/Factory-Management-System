using DrMelomad.Database;
using DrMelomad.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;

using System.Windows.Forms;

namespace DrMelomad.Win
{
    public partial class PrintCategoryBTN : Form
    {
        readonly dbEntities db = new dbEntities();


        private productTBL choseProduct;
        private productCategoryTBL choseCategory;
        private byte[] addImgBytes;
        private byte[] editImgBytes;

        public PrintCategoryBTN()
        {
            InitializeComponent();
        }

        private void ProductWin_Load(object sender, EventArgs e)
        {
            BackColor = (Color)Settings.Default["color"];
            Tools.ColorDataGridView(productDataGridView);
            Tools.ColorDataGridView(categoryDataGrid);
            Tools.ColorDataGridView(categoryChoseDataGrid);
            UpdateLists();

            addProductPictureBox.Image = new Bitmap(Resources.defaultProductImage);
            try
            {
                editProductComboBoxChose.SelectedIndex = 0;
                editCategoryComboBox.SelectedIndex = 0;
                editComboBoxCategory.SelectedIndex = 0;
            }
            catch { }
            productSortComboBox.SelectedIndex = 0;
        }

        private void AddProductBTN_Click(object sender, EventArgs e)
        {
            if (!Tools.CheckName(addProductName, Ep) || !Tools.CheckNum(addPriceUD, Ep) || !Tools.CheckNum(addAmountUD, Ep) || !Tools.CheckNum(addPriceUD, Ep))
            {
                MessageBox.Show("ישנה שגיאה");
                return;
            }
            productTBL product = new productTBL
            {
                unitsInStock = (int)addAmountUD.Value,
                productPrice = (double)Math.Round(addPriceUD.Value, 1),
                productName = addProductName.Text.Trim(),
                nots = addProductNotes.Text.Trim(),
                addDate = DateTime.Now,
                isActive = addAmountUD.Value != 0,
                img = addImgBytes
            };
            if (addProductCategoryComboBox.SelectedItem != null)
                product.categoryID = ((productCategoryTBL)addProductCategoryComboBox.SelectedItem).Id;

            db.productTBL.Add(product);
            db.SaveChanges();
            UpdateLists();
            MessageBox.Show("המוצר התווסף בהצלחה");
            addProductName.Text = "";
            addProductNotes.Text = "";
            addPriceUD.Value = 0;
            addAmountUD.Value = 0;
            addProductPictureBox.Image = new Bitmap(Resources.defaultProductImage);
            addProductImageDirLBL.Text = "";
        }

        private void AddProductChoseImageBTN_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                addProductImageDirLBL.Text = openFileDialog1.FileName;
                Image myImg = Image.FromFile(addProductImageDirLBL.Text);
                Bitmap bt1 = (Bitmap)myImg;
                myImg = Tools.ResizeImage(bt1, addProductPictureBox.Width, addProductPictureBox.Height);

                MemoryStream ms = new MemoryStream();
                myImg.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                addImgBytes = ms.ToArray();
                addProductPictureBox.Image = myImg;
            }
        }

        private void EditProductChoseImageBTN_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                editProductImageDirLBL.Text = openFileDialog1.FileName;
                Image myImg = Image.FromFile(editProductImageDirLBL.Text);
                Bitmap bt1 = (Bitmap)myImg;
                myImg = Tools.ResizeImage(bt1, editProductPictureBox.Width, editProductPictureBox.Height);

                MemoryStream ms = new MemoryStream();
                myImg.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                editImgBytes = ms.ToArray();
                editProductPictureBox.Image = myImg;
            }
        }

        private void UpdateLists()
        {
            List<productTBL> productList = (from product in db.productTBL orderby product.productName select product).ToList();
            List<productCategoryTBL> categoryLST = (from category in db.productCategoryTBL orderby category.categoryName select category).ToList();
            List<productView> productViewsSortLST;
            switch (productSortComboBox.SelectedIndex)
            {
                case 0:
                    productViewsSortLST = (from pro in db.productView orderby pro.productName select pro).ToList();
                    break;
                case 1:
                    productViewsSortLST = (from pro in db.productView orderby pro.categoryName select pro).ToList();
                    break;
                default:
                    productViewsSortLST = (from pro in db.productView orderby pro.unitsInStock select pro).ToList();
                    break;
            }
            if (productIsActiveCheckBox.Checked)
            {
                productViewsSortLST = (from pro in productViewsSortLST where pro.isActive select pro).ToList();
            }

            editComboBoxCategory.DataSource = categoryLST;
            editComboBoxCategory.DisplayMember = "categoryName";
            editComboBoxCategory.ValueMember = "Id";

            categoryChoseDataGrid.DataSource = categoryLST;
            categoryChoseDataGrid.Columns[0].Visible = false;
            categoryChoseDataGrid.Columns[1].HeaderText = "קטגוריה";
            categoryChoseDataGrid.Columns[1].Width = 275;
            categoryChoseDataGrid.Columns[2].Visible = false;
            categoryChoseDataGrid.Columns[3].Visible = false;
            categoryChoseDataGrid.Columns[4].Visible = false;

            editCategoryComboBox.DataSource = categoryLST;
            editCategoryComboBox.DisplayMember = "categoryName";
            editCategoryComboBox.ValueMember = "Id";

            productDataGridView.DataSource = productViewsSortLST;
            productDataGridView.Columns[0].HeaderText = "שם מוצר";
            productDataGridView.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            productDataGridView.Columns[0].Width = 170;
            productDataGridView.Columns[1].HeaderText = "קטגוריה";
            productDataGridView.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            productDataGridView.Columns[1].Width = 180;
            productDataGridView.Columns[2].HeaderText = "הערות";
            productDataGridView.Columns[2].Width = 200;
            productDataGridView.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            productDataGridView.Columns[3].HeaderText = "מחיר";
            productDataGridView.Columns[3].DefaultCellStyle.Format = "N1";
            productDataGridView.Columns[3].Width = 65;
            productDataGridView.Columns[4].HeaderText = "כמות במלאי";
            productDataGridView.Columns[4].Width = 85;
            productDataGridView.Columns[5].HeaderText = "תמונה";
            productDataGridView.Columns[6].Visible = false;
            productDataGridView.Columns[7].Visible = false;
            productDataGridView.RowTemplate.Height = 100;

            for (int i = 0; i < productDataGridView.Columns.Count; i++)
                if (productDataGridView.Columns[i] is DataGridViewImageColumn)
                    ((DataGridViewImageColumn)productDataGridView.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;

            foreach (var column in productDataGridView.Columns)
                if (column is DataGridViewImageColumn)
                    (column as DataGridViewImageColumn).DefaultCellStyle.NullValue = Resources.defaultProductImage;

            categoryDataGrid.DataSource = categoryLST;
            categoryDataGrid.Columns[0].Visible = false;
            categoryDataGrid.Columns[1].HeaderText = "קטגוריה";
            categoryDataGrid.Columns[1].Width = 275;
            categoryDataGrid.Columns[2].HeaderText = "תאיור";
            productDataGridView.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            categoryDataGrid.Columns[2].Width = 350;
            categoryDataGrid.Columns[3].Visible = false;
            categoryDataGrid.Columns[4].Visible = false;

            editProductComboBoxChose.DataSource = productList;
            editProductComboBoxChose.DisplayMember = "productName";
            editProductComboBoxChose.ValueMember = "Id";

            addProductCategoryComboBox.DataSource = categoryLST;
            addProductCategoryComboBox.DisplayMember = "categoryName";
            addProductCategoryComboBox.ValueMember = "Id";
        }


        private void AddCategoryBTN_Click(object sender, EventArgs e)
        {
            if (!Tools.CheckName(addCategoryName, Ep))
            {
                MessageBox.Show("ישנה שגיאה");
                return;
            }
            productCategoryTBL category = new productCategoryTBL
            {
                description = addCategoryDescription.Text.Trim(),
                categoryName = addCategoryName.Text.Trim()
            };

            db.productCategoryTBL.Add(category);
            db.SaveChanges();
            UpdateLists();
            MessageBox.Show("הקטגוריה התווספה בהצלחה");
            addCategoryDescription.Text = "";
            addCategoryName.Text = "";
        }

        private void EditCategoryBTN_Click(object sender, EventArgs e)
        {
            if (!Tools.CheckName(editCategoryName, Ep))
            {
                MessageBox.Show("ישנה שגיאה");
                return;
            }

            choseCategory.description = editCategoryDescription.Text.Trim();
            choseCategory.categoryName = editCategoryName.Text.Trim();
            db.SaveChanges();
            UpdateLists();
            MessageBox.Show("הקטגוריה עודכנה בהצלחה");
        }

        private void EditProductComboBoxChose_SelectedIndexChanged(object sender, EventArgs e)
        {
            choseProduct = (productTBL)editProductComboBoxChose.SelectedItem;
            if (choseProduct.img == null)
                editProductPictureBox.Image = new Bitmap(Resources.defaultProductImage);
            else
                using (MemoryStream mStrem = new MemoryStream(choseProduct.img))
                    editProductPictureBox.Image = Image.FromStream(mStrem);

            editAmountUD.Value = choseProduct.unitsInStock;
            editPriceUD.Value = (decimal)choseProduct.productPrice;
            editProductName.Text = choseProduct.productName.Trim();
            editProductNotes.Text = choseProduct.nots;
            editProductCheckBoxIsActive.Checked = choseProduct.isActive;
            editCategoryComboBox.SelectedItem = choseProduct.productCategoryTBL;
        }

        private void EditComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            choseCategory = (productCategoryTBL)editComboBoxCategory.SelectedItem;
            editCategoryName.Text = choseCategory.categoryName;
            editCategoryDescription.Text = choseCategory.description;
        }

        private void ProductEditButton_Click(object sender, EventArgs e)
        {
            if (!Tools.CheckName(editProductName, Ep) || !Tools.CheckNum(editAmountUD, Ep) || !Tools.CheckNum(editPriceUD, Ep) || !Tools.CheckNum(editPriceUD, Ep) || !Tools.CheckNum(editAmountUD, Ep))
            {
                MessageBox.Show("ישנה שגיאה");
                return;
            }
            if (editImgBytes != null && editProductImageDirLBL.Text != "")
                choseProduct.img = editImgBytes;
            choseProduct.isActive = editProductCheckBoxIsActive.Checked;
            choseProduct.productName = editProductName.Text.Trim();
            choseProduct.nots = editProductNotes.Text.Trim();
            choseProduct.unitsInStock = (int)editAmountUD.Value;
            choseProduct.productPrice = (double)Math.Round(editPriceUD.Value, 1);
            if (editCategoryComboBox.SelectedItem != null)
                choseProduct.categoryID = ((productCategoryTBL)editCategoryComboBox.SelectedItem).Id;
            db.SaveChanges();
            UpdateLists();
            MessageBox.Show("פרטי המוצר עודכנו בהצלחה");
            editProductImageDirLBL.Text = "";
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLists();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLists();
        }

        private void CategoryPrintBTN_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printCateroryDoc;
            printPreviewDialog1.ShowDialog();
        }

        private void PrintProductBTN_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printProductDoc;
            printPreviewDialog1.ShowDialog();
        }
        private void PrintProductDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            productDataGridView.Columns[0].Width = 270;
            productDataGridView.Columns[2].Visible = false;
            MyReports.DrawDataGridView(this.Font, e, "דוח מוצרים", productDataGridView);
            productDataGridView.Columns[0].Width = 170;
            productDataGridView.Columns[2].Visible = true;
        }

        private void PrintCateroryDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            MyReports.DrawDataGridView(this.Font, e, "דוח קטגוריות מוצרים", categoryDataGrid);
        }

        private void AddProductName_Leave(object sender, EventArgs e)
        {
            Tools.CheckName(addProductName, Ep);
        }

        private void AddAmountUD_Leave(object sender, EventArgs e)
        {
            Tools.CheckNum(addAmountUD, Ep);
        }

        private void AddPriceUD_Leave(object sender, EventArgs e)
        {
            Tools.CheckNum(addPriceUD, Ep);
        }

        private void EditProductName_Leave(object sender, EventArgs e)
        {
            Tools.CheckName(editProductName, Ep);
        }

        private void EditAmountUD_Leave(object sender, EventArgs e)
        {
            Tools.CheckNum(editAmountUD, Ep);
        }

        private void EditPriceUD_Leave(object sender, EventArgs e)
        {
            Tools.CheckNum(editPriceUD, Ep);
        }

        private void AddCategoryName_Leave(object sender, EventArgs e)
        {
            Tools.CheckName(addCategoryName, Ep);
        }

        private void EditCategoryName_Leave(object sender, EventArgs e)
        {
            Tools.CheckName(editCategoryName, Ep);
        }
        

        private void ShoppingCartUpdateBTN_Click(object sender, EventArgs e)
        {
            GoogleSheetsHelper gsh = new GoogleSheetsHelper();
            List<productView> productList = (from product in db.productView orderby product.productName where (product.isActive && product.unitsInStock != 0) select product).ToList();

            List<GoogleSheetRow> rows = new List<GoogleSheetRow>();
             
            foreach (productView product in productList)
            {
                var row = new GoogleSheetRow();

                var cell1 = new GoogleSheetCell() { CellValue = product.Id.ToString() };
                var cell2 = new GoogleSheetCell() { CellValue = product.productName };
                var cell3 = new GoogleSheetCell() { CellValue = product.categoryName };
                var cell4 = new GoogleSheetCell() { CellValue = product.nots };
                var cell5 = new GoogleSheetCell() { CellValue = (product.img != null) ? Convert.ToBase64String(Tools.ResizeMax50Kbytes(product.img)) : "" }; //size limit is 50k
                var cell6 = new GoogleSheetCell() { CellValue = product.productPrice.ToString() };
                var cell7 = new GoogleSheetCell() { CellValue = product.unitsInStock.ToString() };

                row.Cells.AddRange(new List<GoogleSheetCell>() { cell1, cell2, cell3, cell4, cell5, cell6, cell7 });
                rows.Add(row);
            }

            var row2 = new GoogleSheetRow();

            gsh.AddCells(new GoogleSheetParameters() { SheetName = "shopping cart", RangeColumnStart = 1, RangeRowStart = 2 }, rows);
            MessageBox.Show("המוצרים בעגלת הקניות עודקנו בהצלחה");
        }
    }
}

