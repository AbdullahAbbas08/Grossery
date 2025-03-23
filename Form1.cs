using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Grossery
{
    public partial class Form1 : Form
    {
        private MarketEntities db;              // Your EF context
        private float _posTotal = 0f;
        private BindingSource _posBindingSource;
        private List<PosItem> _posItems;
        private List<Product> Products;

        public Form1()
        {
            // Set culture to Arabic (Saudi Arabia), for instance
            CultureInfo arCulture = new CultureInfo("ar-SA");
            Thread.CurrentThread.CurrentCulture = arCulture;
            Thread.CurrentThread.CurrentUICulture = arCulture;

            InitializeComponent();
            // Set DGV to begin edit on Enter (helps with scanners):
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;

            // Create the EF context
            db = new MarketEntities();
            Products = db.Products.ToList();
            // Create local POS list and BindingSource (optional for data-binding)
            _posItems = new List<PosItem>();
            _posBindingSource = new BindingSource { DataSource = _posItems };

            // In this example, we’re manually controlling the DataGridView rows,
            // so we won't do: dataGridView1.DataSource = _posBindingSource;

            // Hook up needed events
            this.Load += Form1_Load;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.RowsAdded += dataGridView1_RowsAdded;

            // Ensure the form captures KeyDown before child controls.
            this.KeyPreview = true;

            // Attach an event handler for KeyDown
            this.KeyDown += Form1_KeyDown;

            //textBox3.KeyDown += textBox3_KeyDown;
            //textBox2.KeyDown += textBox2_KeyDown;

            //textBox2.KeyPress += AllowOnlyDecimalInput;
            //textBox3.KeyPress += AllowOnlyDecimalInput;
            dataGridView1.CellBeginEdit += dataGridView1_CellBeginEdit;




        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Column1")
            {
                var barcodeCell = dataGridView1.Rows[e.RowIndex].Cells["barcode"];
                string barcode = barcodeCell?.Value?.ToString();

                if (!string.IsNullOrWhiteSpace(barcode) && Products.Any(p => p.Parcode == barcode))
                {
                    e.Cancel = true; // Prevent edit if barcode is found
                }
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                dataGridView1.Rows.Clear();
                lblTotal2.Text = "";
                //textBox2.Text = "";
                manualAddedAmount = 0;
                manualSubtractedAmount = 0;
                dataGridView1.Rows.Add();
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells["barcode"];
                dataGridView1.BeginEdit(true);
                e.Handled = true;
            }
        }


        //private void Form1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Space)
        //    {
        //        // Clear the DataGridView
        //        dataGridView1.Rows.Clear();

        //        // Reset total
        //        lblTotal2.Text = "0";

        //        // Add one fresh row
        //        dataGridView1.Rows.Add();

        //        // Set focus to the first cell in 'barcode' column
        //        if (dataGridView1.Rows.Count > 0)
        //        {
        //            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells["barcode"];
        //            dataGridView1.BeginEdit(true);
        //        }

        //        // Mark key event as handled
        //        e.Handled = true;
        //    }
        //}


        private void Form1_Load(object sender, EventArgs e)
        {
            // Add an initial blank row
            dataGridView1.Rows.Add();

            // Focus the first row's barcode cell so scanning can begin
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells["barcode"];
            dataGridView1.BeginEdit(true);
        }

        /// <summary>
        /// Handle user finishing edit in any cell. 
        /// If 'barcode' was edited, do DB lookup; 
        /// If 'qtn' or 'price' changed, recalc total.
        /// </summary>
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Valid row/col?
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var col = dataGridView1.Columns[e.ColumnIndex];
            var row = dataGridView1.Rows[e.RowIndex];

            // If user just edited 'barcode'
            if (col.Name.Equals("barcode", StringComparison.OrdinalIgnoreCase))
            {
                string typedBarcode = Convert.ToString(row.Cells["barcode"].Value)?.Trim() ?? "";

                if (!string.IsNullOrEmpty(typedBarcode))
                {
                    var product = Products.FirstOrDefault(p => p.Parcode == typedBarcode);
                    if (product != null)
                    {
                        // Fill product info
                        row.Cells["Name"].Value = product.Name;
                        row.Cells["qtn"].Value = 1;
                        row.Cells["price"].Value = product.Price;
                        row.Cells["Column1"].Value = product.Price;

                        // Recalculate totals
                        RecalculateRowTotal(e.RowIndex);

                        // Optionally lock manual editing
                        row.Cells["Column1"].ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("Barcode not found!");
                        row.Cells["Name"].Value = null;
                        row.Cells["qtn"].Value = null;
                        row.Cells["price"].Value = null;
                        row.Cells["Column1"].Value = 0;  // safer than null
                        row.Cells["Column1"].ReadOnly = false;
                    }

                    // Add new row if at bottom and product found
                    if (product != null && e.RowIndex == dataGridView1.Rows.Count - 1)
                    {
                        dataGridView1.Rows.Add();
                    }

                    // Focus next row’s barcode cell
                    int nextRow = e.RowIndex + 1;
                    if (nextRow < dataGridView1.Rows.Count)
                    {
                        this.BeginInvoke(new Action(() =>
                        {
                            dataGridView1.CurrentCell = dataGridView1.Rows[nextRow].Cells["barcode"];
                            dataGridView1.BeginEdit(true);
                        }));
                    }
                }
            }
            else if (col.Name.Equals("qtn", StringComparison.OrdinalIgnoreCase) ||
                     col.Name.Equals("price", StringComparison.OrdinalIgnoreCase))
            {
                RecalculateRowTotal(e.RowIndex);
            }
            else if (col.Name == "Column1")
            {
                // Allow manual total input only when barcode is not valid
                string barcode = row.Cells["barcode"].Value?.ToString()?.Trim();
                if (string.IsNullOrWhiteSpace(barcode) || !Products.Any(p => p.Parcode == barcode))
                {
                    row.Cells["Column1"].ReadOnly = false;
                    UpdateGrandTotal();
                }
                else
                {
                    // Prevent accidental overwrite
                    row.Cells["Column1"].Value = row.Cells["price"].Value;
                }
            }
        }


        /// <summary>
        /// Whenever a new row is added, set the 'index' cell to row number (1-based).
        /// </summary>
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //for (int i = e.RowIndex; i < e.RowIndex + e.RowCount; i++)
            //{
            //    dataGridView1["index", i].Value = (i + 1).ToString();
            //}

            ReIndexRows();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void ReIndexRows()
        {
            int displayIndex = 1;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                // If you want to include the blank “new row,” leave as-is.
                // If you do *not* want the new row to have an index, skip the last row:
                // if (!dataGridView1.Rows[i].IsNewRow) 
                // {
                //     dataGridView1["index", i].Value = displayIndex.ToString();
                //     displayIndex++;
                // }

                // Otherwise, simply always index:
                dataGridView1["index", i].Value = displayIndex.ToString();
                displayIndex++;
            }
        }

        private void AllowOnlyDecimalInput(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string currentText = textBox.Text;

            // Get current culture's decimal separator
            string decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            // If user presses '.' but current culture uses ',' — allow it and replace with ','
            if (e.KeyChar == '.' && decimalSeparator != ".")
            {
                e.KeyChar = Convert.ToChar(decimalSeparator); // Replace '.' with ','
            }

            // Allow control keys (e.g. Backspace)
            if (char.IsControl(e.KeyChar))
                return;

            // Allow digits
            if (char.IsDigit(e.KeyChar))
                return;

            // Allow one decimal separator only
            if (e.KeyChar.ToString() == decimalSeparator && !currentText.Contains(decimalSeparator))
                return;

            // Block all other input
            e.Handled = true;
        }




        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            // If there’s a valid current row
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                // Remove it
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

                // Update totals if needed
                UpdateGrandTotal();
            }
            else
            {
                MessageBox.Show("لا يوجد صف محدد أو لا يمكن حذفه!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /// <summary>
        /// Recalculate total for a single row and update the grand total.
        /// </summary>
        private void RecalculateRowTotal(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= dataGridView1.Rows.Count) return;

            var row = dataGridView1.Rows[rowIndex];
            if (row.IsNewRow) return;  // skip new row

            // Parse quantity
            int qty = 0;
            if (row.Cells["qtn"].Value != null)
            {
                int.TryParse(row.Cells["qtn"].Value.ToString(), out qty);
            }

            // Parse price
            decimal priceVal = 0;
            if (row.Cells["price"].Value != null)
            {
                decimal.TryParse(row.Cells["price"].Value.ToString(), out priceVal);
            }

            // total = price * qty
            decimal lineTotal = priceVal * qty;
            row.Cells["Column1"].Value = lineTotal;

            // Update the grand total
            UpdateGrandTotal();
        }

        private decimal manualAddedAmount = 0;
        private decimal manualSubtractedAmount = 0;


        //private void AddToTotal()
        //{
        //    if (decimal.TryParse(textBox3.Text, out decimal addAmount))
        //    {
        //        manualAddedAmount += addAmount;
        //        textBox3.Text = "";
        //        UpdateGrandTotal();
        //    }
        //}
        //private void AddToTotal()
        //{
        //    if (decimal.TryParse(lblTotal2.Text, out decimal currentTotal) &&
        //        decimal.TryParse(textBox3.Text, out decimal addAmount))
        //    {
        //        decimal newTotal = currentTotal + addAmount;
        //        lblTotal2.Text = newTotal.ToString();
        //        textBox3.Text = "";
        //    }
        //}

        private void UpdateGrandTotal()
        {
            decimal sum = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["Column1"].Value != null &&
                    decimal.TryParse(row.Cells["Column1"].Value.ToString(), out decimal lineTotal))
                {
                    sum += lineTotal;
                }
            }

            // Add manual additions and subtract manual deductions
            sum += manualAddedAmount;
            sum -= manualSubtractedAmount;

            lblTotal2.Text = sum.ToString();
        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                if (columnName == "colRemove" || columnName == "colRemoveStart")
                {
                    if (!dataGridView1.Rows[e.RowIndex].IsNewRow)
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                        ReIndexRows();
                        UpdateGrandTotal();
                    }
                }
            }
        }





        //private void SubtractFromTotal()
        //{
        //    if (decimal.TryParse(textBox2.Text, out decimal subtractAmount))
        //    {
        //        manualSubtractedAmount += subtractAmount;
        //        textBox2.Text = "";
        //        UpdateGrandTotal();
        //    }
        //}



        //private void label3_Click(object sender, EventArgs e)
        //{
        //    AddToTotal();
        //}

        //private void label6_Click(object sender, EventArgs e)
        //{
        //    SubtractFromTotal();
        //}

        //private void textBox3_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        AddToTotal();
        //        e.Handled = true;
        //        e.SuppressKeyPress = true; // prevent ding sound
        //    }
        //}

        //private void textBox2_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        SubtractFromTotal();
        //        e.Handled = true;
        //        e.SuppressKeyPress = true;
        //    }
        //}


        //private void label3_Click(object sender, EventArgs e)
        //{
        //    if (decimal.TryParse(lblTotal2.Text, out decimal currentTotal) &&
        //        decimal.TryParse(textBox3.Text, out decimal addAmount))
        //    {
        //        decimal newTotal = currentTotal + addAmount;
        //        lblTotal2.Text = newTotal.ToString();
        //        textBox3.Text = "";
        //    }
        //    else
        //    {
        //        //MessageBox.Show("تأكد من إدخال رقم صالح في المبلغ للإضافة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        //private void label6_Click(object sender, EventArgs e)
        //{
        //    if (decimal.TryParse(lblTotal2.Text, out decimal currentTotal) &&
        //        decimal.TryParse(textBox2.Text, out decimal subtractAmount))
        //    {
        //        decimal newTotal = currentTotal - subtractAmount;
        //        lblTotal2.Text = newTotal.ToString();
        //        textBox2.Text = "";
        //    }
        //    else
        //    {
        //        //MessageBox.Show("تأكد من إدخال رقم صالح في المبلغ للخصم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

    }

    /// <summary>
    /// Example POS item model if you want to do advanced binding.
    /// </summary>
    public class PosItem
    {
        public string Barcode { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public float ItemTotal { get; set; }
    }
}
