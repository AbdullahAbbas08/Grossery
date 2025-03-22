using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Grossery
{
    partial class Form1
    {
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        // In Form1.Designer.cs

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            index = new DataGridViewTextBoxColumn();
            barcode = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            qtn = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            colRemove = new DataGridViewButtonColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            lblTotal2 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            tabPage2 = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            textBox1 = new TextBox();
            label2 = new Label();
            tableLayoutPanel16 = new TableLayoutPanel();
            tableLayoutPanel17 = new TableLayoutPanel();
            textBox7 = new TextBox();
            label8 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel17.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Cursor = Cursors.Hand;
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeftLayout = true;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1209, 775);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1201, 737);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 93.57045F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.42954874F));
            tableLayoutPanel1.Size = new Size(1195, 731);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.Padding = new Padding(2);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.Padding = new Padding(2);
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { index, barcode, Name, qtn, price, Column1, colRemove });
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = SystemColors.Window;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle16.Padding = new Padding(10);
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle16;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = SystemColors.Control;
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle17.Padding = new Padding(2);
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = Color.Black;
            dataGridViewCellStyle18.Padding = new Padding(10);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle18;
            dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.RowTemplate.DefaultCellStyle.Padding = new Padding(5);
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Size = new Size(1189, 678);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // index
            // 
            dataGridViewCellStyle12.Padding = new Padding(5);
            index.DefaultCellStyle = dataGridViewCellStyle12;
            index.HeaderText = "م";
            index.Name = "index";
            index.ReadOnly = true;
            index.Resizable = DataGridViewTriState.False;
            index.Width = 52;
            // 
            // barcode
            // 
            barcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            barcode.FillWeight = 120F;
            barcode.HeaderText = "رقم";
            barcode.Name = "barcode";
            // 
            // Name
            // 
            Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.Padding = new Padding(5);
            Name.DefaultCellStyle = dataGridViewCellStyle13;
            Name.FillWeight = 120F;
            Name.HeaderText = "الاسم";
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // qtn
            // 
            qtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = Color.YellowGreen;
            dataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle14.Padding = new Padding(1);
            dataGridViewCellStyle14.SelectionBackColor = Color.Black;
            dataGridViewCellStyle14.SelectionForeColor = Color.FromArgb(224, 224, 224);
            qtn.DefaultCellStyle = dataGridViewCellStyle14;
            qtn.FillWeight = 120F;
            qtn.HeaderText = "كام واحد";
            qtn.Name = "qtn";
            // 
            // price
            // 
            price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            price.FillWeight = 120F;
            price.HeaderText = "السعر";
            price.Name = "price";
            price.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 120F;
            Column1.HeaderText = "الاجمالى";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // colRemove
            // 
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = Color.Silver;
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = Color.Red;
            dataGridViewCellStyle15.Padding = new Padding(2);
            colRemove.DefaultCellStyle = dataGridViewCellStyle15;
            colRemove.HeaderText = "";
            colRemove.Name = "colRemove";
            colRemove.Text = "✖";
            colRemove.UseColumnTextForButtonValue = true;
            colRemove.Width = 46;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.447154F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.7642269F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.0731716F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.5772362F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.1382122F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 201F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 248F));
            tableLayoutPanel2.Controls.Add(textBox3, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(label4, 5, 0);
            tableLayoutPanel2.Controls.Add(lblTotal2, 6, 0);
            tableLayoutPanel2.Controls.Add(label6, 2, 0);
            tableLayoutPanel2.Controls.Add(textBox2, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 687);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1189, 41);
            tableLayoutPanel2.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Green;
            textBox3.Dock = DockStyle.Top;
            textBox3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(907, 10);
            textBox3.Margin = new Padding(0, 10, 0, 0);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(168, 39);
            textBox3.TabIndex = 10;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Green;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1078, 0);
            label3.Name = "label3";
            label3.Size = new Size(108, 41);
            label3.TabIndex = 0;
            label3.Text = "ضيف";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Blue;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(253, 0);
            label4.Name = "label4";
            label4.Size = new Size(195, 41);
            label4.TabIndex = 6;
            label4.Text = "الحساب";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotal2
            // 
            lblTotal2.AutoSize = true;
            lblTotal2.BackColor = Color.Navy;
            lblTotal2.Dock = DockStyle.Fill;
            lblTotal2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal2.ForeColor = Color.White;
            lblTotal2.Location = new Point(3, 0);
            lblTotal2.Name = "lblTotal2";
            lblTotal2.Size = new Size(244, 41);
            lblTotal2.TabIndex = 7;
            lblTotal2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Maroon;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(784, 0);
            label6.Name = "label6";
            label6.Size = new Size(120, 41);
            label6.TabIndex = 9;
            label6.Text = "شيل";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Maroon;
            textBox2.Dock = DockStyle.Top;
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(607, 10);
            textBox2.Margin = new Padding(0, 10, 0, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 39);
            textBox2.TabIndex = 5;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1201, 737);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 100);
            label1.TabIndex = 23;
            label1.Text = "الحساب";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.9383564F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.0616455F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 354F));
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel5.Controls.Add(label2, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(1, 94);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 0, 0);
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(3, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1, 88);
            textBox1.TabIndex = 22;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(1, 94);
            label2.TabIndex = 23;
            label2.Text = "الحساب";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel16
            // 
            tableLayoutPanel16.ColumnCount = 3;
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.9383564F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.0616455F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 354F));
            tableLayoutPanel16.Dock = DockStyle.Fill;
            tableLayoutPanel16.Location = new Point(0, 0);
            tableLayoutPanel16.Name = "tableLayoutPanel16";
            tableLayoutPanel16.RowCount = 1;
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel16.Size = new Size(200, 100);
            tableLayoutPanel16.TabIndex = 0;
            // 
            // tableLayoutPanel17
            // 
            tableLayoutPanel17.ColumnCount = 2;
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel17.Controls.Add(textBox7, 1, 0);
            tableLayoutPanel17.Controls.Add(label8, 0, 0);
            tableLayoutPanel17.Dock = DockStyle.Fill;
            tableLayoutPanel17.Location = new Point(3, 3);
            tableLayoutPanel17.Name = "tableLayoutPanel17";
            tableLayoutPanel17.RowCount = 1;
            tableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel17.Size = new Size(1, 94);
            tableLayoutPanel17.TabIndex = 1;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(192, 0, 0);
            textBox7.Dock = DockStyle.Fill;
            textBox7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox7.ForeColor = SystemColors.Window;
            textBox7.Location = new Point(3, 3);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(1, 88);
            textBox7.TabIndex = 22;
            textBox7.Text = "0";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(1, 94);
            label8.TabIndex = 23;
            label8.Text = "الحساب";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            ClientSize = new Size(1209, 775);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "برنامج بيع المنتجات بالباركود";
            WindowState = FormWindowState.Maximized;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel17.ResumeLayout(false);
            tableLayoutPanel17.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn index;
        private DataGridViewTextBoxColumn barcode;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn qtn;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewButtonColumn colRemove;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox textBox1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel16;
        private TableLayoutPanel tableLayoutPanel17;
        private TextBox textBox7;
        private Label label8;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label lblTotal2;
        private TextBox textBox3;
        private Label label6;
    }
}
