namespace CoffeeShopManagement
{
    partial class fTableManager
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
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            accountInformationToolStripMenuItem = new ToolStripMenuItem();
            personalInformationToolStripMenuItem = new ToolStripMenuItem();
            logouToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            nmFoodAmount = new NumericUpDown();
            btnAddFood = new Button();
            cbFood = new ComboBox();
            cbCategory = new ComboBox();
            flpTable = new FlowLayoutPanel();
            panel2 = new Panel();
            txbTotalPrice = new TextBox();
            cbSwitchTable = new ComboBox();
            btnDiscount = new Button();
            nmDiscount = new NumericUpDown();
            btnSwitchTable = new Button();
            btnCheck = new Button();
            panel3 = new Panel();
            lsvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodAmount).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, accountInformationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1192, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(81, 29);
            toolStripMenuItem1.Text = "Admin";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // accountInformationToolStripMenuItem
            // 
            accountInformationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { personalInformationToolStripMenuItem, logouToolStripMenuItem });
            accountInformationToolStripMenuItem.Name = "accountInformationToolStripMenuItem";
            accountInformationToolStripMenuItem.Size = new Size(192, 29);
            accountInformationToolStripMenuItem.Text = "Account Information";
            // 
            // personalInformationToolStripMenuItem
            // 
            personalInformationToolStripMenuItem.Name = "personalInformationToolStripMenuItem";
            personalInformationToolStripMenuItem.Size = new Size(279, 34);
            personalInformationToolStripMenuItem.Text = "Personal Information";
            personalInformationToolStripMenuItem.Click += personalInformationToolStripMenuItem_Click;
            // 
            // logouToolStripMenuItem
            // 
            logouToolStripMenuItem.Name = "logouToolStripMenuItem";
            logouToolStripMenuItem.Size = new Size(279, 34);
            logouToolStripMenuItem.Text = "Logout";
            logouToolStripMenuItem.Click += logouToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(nmFoodAmount);
            panel1.Controls.Add(btnAddFood);
            panel1.Controls.Add(cbFood);
            panel1.Controls.Add(cbCategory);
            panel1.Location = new Point(684, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(496, 96);
            panel1.TabIndex = 1;
            // 
            // nmFoodAmount
            // 
            nmFoodAmount.Location = new Point(322, 5);
            nmFoodAmount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmFoodAmount.Name = "nmFoodAmount";
            nmFoodAmount.Size = new Size(79, 31);
            nmFoodAmount.TabIndex = 2;
            nmFoodAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(407, 3);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(86, 90);
            btnAddFood.TabIndex = 3;
            btnAddFood.Text = "Add food";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // cbFood
            // 
            cbFood.FormattingEnabled = true;
            cbFood.Location = new Point(3, 51);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(313, 33);
            cbFood.TabIndex = 1;
            cbFood.Text = "-Food-";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(3, 3);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(313, 33);
            cbCategory.TabIndex = 0;
            cbCategory.Text = "-Category-";
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // flpTable
            // 
            flpTable.AutoScroll = true;
            flpTable.Location = new Point(12, 36);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(666, 562);
            flpTable.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(txbTotalPrice);
            panel2.Controls.Add(cbSwitchTable);
            panel2.Controls.Add(btnDiscount);
            panel2.Controls.Add(nmDiscount);
            panel2.Controls.Add(btnSwitchTable);
            panel2.Controls.Add(btnCheck);
            panel2.Location = new Point(684, 502);
            panel2.Name = "panel2";
            panel2.Size = new Size(496, 96);
            panel2.TabIndex = 2;
            // 
            // txbTotalPrice
            // 
            txbTotalPrice.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txbTotalPrice.ForeColor = Color.OrangeRed;
            txbTotalPrice.Location = new Point(231, 33);
            txbTotalPrice.Name = "txbTotalPrice";
            txbTotalPrice.ReadOnly = true;
            txbTotalPrice.Size = new Size(170, 33);
            txbTotalPrice.TabIndex = 8;
            txbTotalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // cbSwitchTable
            // 
            cbSwitchTable.FormattingEnabled = true;
            cbSwitchTable.Location = new Point(3, 60);
            cbSwitchTable.Name = "cbSwitchTable";
            cbSwitchTable.Size = new Size(108, 33);
            cbSwitchTable.TabIndex = 4;
            // 
            // btnDiscount
            // 
            btnDiscount.Location = new Point(117, 3);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(108, 45);
            btnDiscount.TabIndex = 5;
            btnDiscount.Text = "Discount";
            btnDiscount.UseVisualStyleBackColor = true;
            // 
            // nmDiscount
            // 
            nmDiscount.Location = new Point(117, 60);
            nmDiscount.Name = "nmDiscount";
            nmDiscount.Size = new Size(108, 31);
            nmDiscount.TabIndex = 4;
            nmDiscount.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSwitchTable
            // 
            btnSwitchTable.Location = new Point(3, 3);
            btnSwitchTable.Name = "btnSwitchTable";
            btnSwitchTable.Size = new Size(108, 45);
            btnSwitchTable.TabIndex = 7;
            btnSwitchTable.Text = "Switch";
            btnSwitchTable.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(407, 3);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(86, 90);
            btnCheck.TabIndex = 4;
            btnCheck.Text = "Pay";
            btnCheck.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(lsvBill);
            panel3.Location = new Point(684, 138);
            panel3.Name = "panel3";
            panel3.Size = new Size(496, 358);
            panel3.TabIndex = 3;
            // 
            // lsvBill
            // 
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvBill.GridLines = true;
            lsvBill.Location = new Point(3, 3);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(490, 352);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Food Name";
            columnHeader1.Width = 166;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Amount";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Price";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Total Price";
            columnHeader4.Width = 120;
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 610);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(flpTable);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fTableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coffee Shop Management Application";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmFoodAmount).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem accountInformationToolStripMenuItem;
        private ToolStripMenuItem personalInformationToolStripMenuItem;
        private ToolStripMenuItem logouToolStripMenuItem;
        private Panel panel1;
        private Button btnAddFood;
        private NumericUpDown nmFoodAmount;
        private ComboBox cbFood;
        private ComboBox cbCategory;
        private FlowLayoutPanel flpTable;
        private Panel panel2;
        private Panel panel3;
        private ListView lsvBill;
        private Button btnDiscount;
        private Button btnCheck;
        private NumericUpDown nmDiscount;
        private Button btnSwitchTable;
        private ComboBox cbSwitchTable;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txbTotalPrice;
    }
}