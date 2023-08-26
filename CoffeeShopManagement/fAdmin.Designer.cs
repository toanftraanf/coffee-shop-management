namespace CoffeeShopManagement
{
    partial class fAdmin
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
            tcAdmin = new TabControl();
            tpBill = new TabPage();
            panel2 = new Panel();
            dtgvBill = new DataGridView();
            panel1 = new Panel();
            btnViewBill = new Button();
            dtpkToDate = new DateTimePicker();
            dtpkFromDate = new DateTimePicker();
            tpFood = new TabPage();
            panel6 = new Panel();
            panel10 = new Panel();
            nmFoodPrice = new NumericUpDown();
            label4 = new Label();
            panel9 = new Panel();
            cbFoodCategory = new ComboBox();
            label3 = new Label();
            panel8 = new Panel();
            txbFoodName = new TextBox();
            label2 = new Label();
            panel7 = new Panel();
            txbFoodId = new TextBox();
            label1 = new Label();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            btnShowFood = new Button();
            btnDeleteFood = new Button();
            btnEditFood = new Button();
            btnAddFood = new Button();
            panel3 = new Panel();
            btnSearchFood = new Button();
            txbSearchFood = new TextBox();
            tpFoodCategory = new TabPage();
            tpTable = new TabPage();
            tpAccount = new TabPage();
            panel11 = new Panel();
            panel14 = new Panel();
            txbCategoryName = new TextBox();
            label7 = new Label();
            panel15 = new Panel();
            label8 = new Label();
            panel16 = new Panel();
            dtgvCategory = new DataGridView();
            panel17 = new Panel();
            btnShowCategory = new Button();
            btnDeleteCategory = new Button();
            btnEditCategory = new Button();
            btnAddCategory = new Button();
            panel19 = new Panel();
            panel21 = new Panel();
            this.cbTableStatus = new ComboBox();
            label10 = new Label();
            panel22 = new Panel();
            this.txbTableName = new TextBox();
            label11 = new Label();
            panel23 = new Panel();
            txbTableId = new TextBox();
            label12 = new Label();
            panel24 = new Panel();
            this.dtgvTable = new DataGridView();
            panel25 = new Panel();
            btnShowTable = new Button();
            btnDeleteTable = new Button();
            btnEditTable = new Button();
            btnAddTable = new Button();
            panel27 = new Panel();
            panel29 = new Panel();
            cbAccountType = new ComboBox();
            label14 = new Label();
            panel30 = new Panel();
            txbDisplayName = new TextBox();
            label15 = new Label();
            panel31 = new Panel();
            txbUsername = new TextBox();
            label16 = new Label();
            panel32 = new Panel();
            dtgvAccount = new DataGridView();
            panel33 = new Panel();
            btnShowAccount = new Button();
            btnDeleteAccount = new Button();
            this.btnEditAccount = new Button();
            btnAddAccount = new Button();
            txbCategoryId = new TextBox();
            btnResetPassword = new Button();
            tcAdmin.SuspendLayout();
            tpBill.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).BeginInit();
            panel1.SuspendLayout();
            tpFood.SuspendLayout();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            tpFoodCategory.SuspendLayout();
            tpTable.SuspendLayout();
            tpAccount.SuspendLayout();
            panel11.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).BeginInit();
            panel17.SuspendLayout();
            panel19.SuspendLayout();
            panel21.SuspendLayout();
            panel22.SuspendLayout();
            panel23.SuspendLayout();
            panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dtgvTable).BeginInit();
            panel25.SuspendLayout();
            panel27.SuspendLayout();
            panel29.SuspendLayout();
            panel30.SuspendLayout();
            panel31.SuspendLayout();
            panel32.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            panel33.SuspendLayout();
            SuspendLayout();
            // 
            // tcAdmin
            // 
            tcAdmin.Controls.Add(tpBill);
            tcAdmin.Controls.Add(tpFood);
            tcAdmin.Controls.Add(tpFoodCategory);
            tcAdmin.Controls.Add(tpTable);
            tcAdmin.Controls.Add(tpAccount);
            tcAdmin.Location = new Point(12, 12);
            tcAdmin.Name = "tcAdmin";
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new Size(1029, 644);
            tcAdmin.TabIndex = 0;
            // 
            // tpBill
            // 
            tpBill.Controls.Add(panel2);
            tpBill.Controls.Add(panel1);
            tpBill.Location = new Point(4, 34);
            tpBill.Name = "tpBill";
            tpBill.Padding = new Padding(3);
            tpBill.Size = new Size(1021, 606);
            tpBill.TabIndex = 0;
            tpBill.Text = "Bill";
            tpBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtgvBill);
            panel2.Location = new Point(6, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 550);
            panel2.TabIndex = 1;
            // 
            // dtgvBill
            // 
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Location = new Point(3, 3);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.RowHeadersWidth = 62;
            dtgvBill.RowTemplate.Height = 33;
            dtgvBill.Size = new Size(1003, 544);
            dtgvBill.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnViewBill);
            panel1.Controls.Add(dtpkToDate);
            panel1.Controls.Add(dtpkFromDate);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 38);
            panel1.TabIndex = 0;
            // 
            // btnViewBill
            // 
            btnViewBill.Location = new Point(451, 2);
            btnViewBill.Name = "btnViewBill";
            btnViewBill.Size = new Size(112, 34);
            btnViewBill.TabIndex = 2;
            btnViewBill.Text = "Search";
            btnViewBill.UseVisualStyleBackColor = true;
            // 
            // dtpkToDate
            // 
            dtpkToDate.Location = new Point(706, 4);
            dtpkToDate.Name = "dtpkToDate";
            dtpkToDate.Size = new Size(300, 31);
            dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            dtpkFromDate.Location = new Point(3, 3);
            dtpkFromDate.Name = "dtpkFromDate";
            dtpkFromDate.Size = new Size(300, 31);
            dtpkFromDate.TabIndex = 0;
            // 
            // tpFood
            // 
            tpFood.Controls.Add(panel6);
            tpFood.Controls.Add(panel5);
            tpFood.Controls.Add(panel4);
            tpFood.Controls.Add(panel3);
            tpFood.Location = new Point(4, 34);
            tpFood.Name = "tpFood";
            tpFood.Padding = new Padding(3);
            tpFood.Size = new Size(1021, 606);
            tpFood.TabIndex = 1;
            tpFood.Text = "Food";
            tpFood.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel10);
            panel6.Controls.Add(panel9);
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(569, 55);
            panel6.Name = "panel6";
            panel6.Size = new Size(446, 545);
            panel6.TabIndex = 4;
            // 
            // panel10
            // 
            panel10.Controls.Add(nmFoodPrice);
            panel10.Controls.Add(label4);
            panel10.Location = new Point(3, 198);
            panel10.Name = "panel10";
            panel10.Size = new Size(440, 59);
            panel10.TabIndex = 4;
            // 
            // nmFoodPrice
            // 
            nmFoodPrice.Location = new Point(143, 14);
            nmFoodPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nmFoodPrice.Name = "nmFoodPrice";
            nmFoodPrice.Size = new Size(294, 31);
            nmFoodPrice.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 14);
            label4.Name = "label4";
            label4.Size = new Size(78, 29);
            label4.TabIndex = 0;
            label4.Text = "Price:";
            // 
            // panel9
            // 
            panel9.Controls.Add(cbFoodCategory);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(3, 133);
            panel9.Name = "panel9";
            panel9.Size = new Size(440, 59);
            panel9.TabIndex = 4;
            // 
            // cbFoodCategory
            // 
            cbFoodCategory.FormattingEnabled = true;
            cbFoodCategory.Location = new Point(143, 10);
            cbFoodCategory.Name = "cbFoodCategory";
            cbFoodCategory.Size = new Size(294, 33);
            cbFoodCategory.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 14);
            label3.Name = "label3";
            label3.Size = new Size(123, 29);
            label3.TabIndex = 0;
            label3.Text = "Category:";
            // 
            // panel8
            // 
            panel8.Controls.Add(txbFoodName);
            panel8.Controls.Add(label2);
            panel8.Location = new Point(3, 68);
            panel8.Name = "panel8";
            panel8.Size = new Size(440, 59);
            panel8.TabIndex = 3;
            // 
            // txbFoodName
            // 
            txbFoodName.Location = new Point(143, 14);
            txbFoodName.Name = "txbFoodName";
            txbFoodName.Size = new Size(294, 31);
            txbFoodName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 14);
            label2.Name = "label2";
            label2.Size = new Size(84, 29);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // panel7
            // 
            panel7.Controls.Add(txbFoodId);
            panel7.Controls.Add(label1);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(440, 59);
            panel7.TabIndex = 2;
            // 
            // txbFoodId
            // 
            txbFoodId.Location = new Point(143, 14);
            txbFoodId.Name = "txbFoodId";
            txbFoodId.ReadOnly = true;
            txbFoodId.Size = new Size(294, 31);
            txbFoodId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(44, 29);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // panel5
            // 
            panel5.Controls.Add(dataGridView1);
            panel5.Location = new Point(6, 55);
            panel5.Name = "panel5";
            panel5.Size = new Size(557, 545);
            panel5.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(551, 539);
            dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnShowFood);
            panel4.Controls.Add(btnDeleteFood);
            panel4.Controls.Add(btnEditFood);
            panel4.Controls.Add(btnAddFood);
            panel4.Location = new Point(6, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(557, 43);
            panel4.TabIndex = 2;
            // 
            // btnShowFood
            // 
            btnShowFood.Location = new Point(442, 4);
            btnShowFood.Name = "btnShowFood";
            btnShowFood.Size = new Size(112, 34);
            btnShowFood.TabIndex = 4;
            btnShowFood.Text = "Show";
            btnShowFood.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Location = new Point(299, 4);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(112, 34);
            btnDeleteFood.TabIndex = 3;
            btnDeleteFood.Text = "Delete";
            btnDeleteFood.UseVisualStyleBackColor = true;
            // 
            // btnEditFood
            // 
            btnEditFood.Location = new Point(154, 4);
            btnEditFood.Name = "btnEditFood";
            btnEditFood.Size = new Size(112, 34);
            btnEditFood.TabIndex = 2;
            btnEditFood.Text = "Edit";
            btnEditFood.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(3, 4);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(112, 34);
            btnAddFood.TabIndex = 1;
            btnAddFood.Text = "Add";
            btnAddFood.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSearchFood);
            panel3.Controls.Add(txbSearchFood);
            panel3.Location = new Point(569, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(446, 43);
            panel3.TabIndex = 0;
            // 
            // btnSearchFood
            // 
            btnSearchFood.Location = new Point(331, 3);
            btnSearchFood.Name = "btnSearchFood";
            btnSearchFood.Size = new Size(112, 34);
            btnSearchFood.TabIndex = 1;
            btnSearchFood.Text = "Search";
            btnSearchFood.UseVisualStyleBackColor = true;
            // 
            // txbSearchFood
            // 
            txbSearchFood.Location = new Point(3, 5);
            txbSearchFood.Name = "txbSearchFood";
            txbSearchFood.Size = new Size(322, 31);
            txbSearchFood.TabIndex = 0;
            // 
            // tpFoodCategory
            // 
            tpFoodCategory.Controls.Add(panel11);
            tpFoodCategory.Controls.Add(panel16);
            tpFoodCategory.Controls.Add(panel17);
            tpFoodCategory.Location = new Point(4, 34);
            tpFoodCategory.Name = "tpFoodCategory";
            tpFoodCategory.Padding = new Padding(3);
            tpFoodCategory.Size = new Size(1021, 606);
            tpFoodCategory.TabIndex = 2;
            tpFoodCategory.Text = "Category";
            tpFoodCategory.UseVisualStyleBackColor = true;
            // 
            // tpTable
            // 
            tpTable.Controls.Add(panel19);
            tpTable.Controls.Add(panel24);
            tpTable.Controls.Add(panel25);
            tpTable.Location = new Point(4, 34);
            tpTable.Name = "tpTable";
            tpTable.Padding = new Padding(3);
            tpTable.Size = new Size(1021, 606);
            tpTable.TabIndex = 3;
            tpTable.Text = "Table";
            tpTable.UseVisualStyleBackColor = true;
            // 
            // tpAccount
            // 
            tpAccount.Controls.Add(panel27);
            tpAccount.Controls.Add(panel32);
            tpAccount.Controls.Add(panel33);
            tpAccount.Location = new Point(4, 34);
            tpAccount.Name = "tpAccount";
            tpAccount.Padding = new Padding(3);
            tpAccount.Size = new Size(1021, 606);
            tpAccount.TabIndex = 4;
            tpAccount.Text = "Account";
            tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            panel11.Controls.Add(panel14);
            panel11.Controls.Add(panel15);
            panel11.Location = new Point(569, 55);
            panel11.Name = "panel11";
            panel11.Size = new Size(446, 545);
            panel11.TabIndex = 8;
            // 
            // panel14
            // 
            panel14.Controls.Add(txbCategoryName);
            panel14.Controls.Add(label7);
            panel14.Location = new Point(3, 68);
            panel14.Name = "panel14";
            panel14.Size = new Size(440, 59);
            panel14.TabIndex = 3;
            // 
            // txbCategoryName
            // 
            txbCategoryName.Location = new Point(143, 14);
            txbCategoryName.Name = "txbCategoryName";
            txbCategoryName.Size = new Size(294, 31);
            txbCategoryName.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 14);
            label7.Name = "label7";
            label7.Size = new Size(84, 29);
            label7.TabIndex = 0;
            label7.Text = "Name:";
            // 
            // panel15
            // 
            panel15.Controls.Add(txbCategoryId);
            panel15.Controls.Add(label8);
            panel15.Location = new Point(3, 3);
            panel15.Name = "panel15";
            panel15.Size = new Size(440, 59);
            panel15.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 14);
            label8.Name = "label8";
            label8.Size = new Size(44, 29);
            label8.TabIndex = 0;
            label8.Text = "ID:";
            // 
            // panel16
            // 
            panel16.Controls.Add(dtgvCategory);
            panel16.Location = new Point(6, 55);
            panel16.Name = "panel16";
            panel16.Size = new Size(557, 545);
            panel16.TabIndex = 7;
            // 
            // dtgvCategory
            // 
            dtgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCategory.Location = new Point(3, 3);
            dtgvCategory.Name = "dtgvCategory";
            dtgvCategory.RowHeadersWidth = 62;
            dtgvCategory.RowTemplate.Height = 33;
            dtgvCategory.Size = new Size(551, 539);
            dtgvCategory.TabIndex = 0;
            // 
            // panel17
            // 
            panel17.Controls.Add(btnShowCategory);
            panel17.Controls.Add(btnDeleteCategory);
            panel17.Controls.Add(btnEditCategory);
            panel17.Controls.Add(btnAddCategory);
            panel17.Location = new Point(6, 6);
            panel17.Name = "panel17";
            panel17.Size = new Size(557, 43);
            panel17.TabIndex = 6;
            // 
            // btnShowCategory
            // 
            btnShowCategory.Location = new Point(442, 4);
            btnShowCategory.Name = "btnShowCategory";
            btnShowCategory.Size = new Size(112, 34);
            btnShowCategory.TabIndex = 4;
            btnShowCategory.Text = "Show";
            btnShowCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(299, 4);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(112, 34);
            btnDeleteCategory.TabIndex = 3;
            btnDeleteCategory.Text = "Delete";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnEditCategory
            // 
            btnEditCategory.Location = new Point(154, 4);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(112, 34);
            btnEditCategory.TabIndex = 2;
            btnEditCategory.Text = "Edit";
            btnEditCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(3, 4);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(112, 34);
            btnAddCategory.TabIndex = 1;
            btnAddCategory.Text = "Add";
            btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // panel19
            // 
            panel19.Controls.Add(panel21);
            panel19.Controls.Add(panel22);
            panel19.Controls.Add(panel23);
            panel19.Location = new Point(569, 55);
            panel19.Name = "panel19";
            panel19.Size = new Size(446, 545);
            panel19.TabIndex = 8;
            // 
            // panel21
            // 
            panel21.Controls.Add(this.cbTableStatus);
            panel21.Controls.Add(label10);
            panel21.Location = new Point(3, 133);
            panel21.Name = "panel21";
            panel21.Size = new Size(440, 59);
            panel21.TabIndex = 4;
            // 
            // cbTableStatus
            // 
            this.cbTableStatus.FormattingEnabled = true;
            this.cbTableStatus.Location = new Point(195, 10);
            this.cbTableStatus.Name = "cbTableStatus";
            this.cbTableStatus.Size = new Size(242, 33);
            this.cbTableStatus.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(3, 14);
            label10.Name = "label10";
            label10.Size = new Size(93, 29);
            label10.TabIndex = 0;
            label10.Text = "Status:";
            // 
            // panel22
            // 
            panel22.Controls.Add(this.txbTableName);
            panel22.Controls.Add(label11);
            panel22.Location = new Point(3, 68);
            panel22.Name = "panel22";
            panel22.Size = new Size(440, 59);
            panel22.TabIndex = 3;
            // 
            // txbTableName
            // 
            this.txbTableName.Location = new Point(195, 14);
            this.txbTableName.Name = "txbTableName";
            this.txbTableName.Size = new Size(242, 31);
            this.txbTableName.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(3, 14);
            label11.Name = "label11";
            label11.Size = new Size(84, 29);
            label11.TabIndex = 0;
            label11.Text = "Name:";
            // 
            // panel23
            // 
            panel23.Controls.Add(txbTableId);
            panel23.Controls.Add(label12);
            panel23.Location = new Point(3, 3);
            panel23.Name = "panel23";
            panel23.Size = new Size(440, 59);
            panel23.TabIndex = 2;
            // 
            // txbTableId
            // 
            txbTableId.Location = new Point(195, 14);
            txbTableId.Name = "txbTableId";
            txbTableId.ReadOnly = true;
            txbTableId.Size = new Size(242, 31);
            txbTableId.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(3, 14);
            label12.Name = "label12";
            label12.Size = new Size(44, 29);
            label12.TabIndex = 0;
            label12.Text = "ID:";
            // 
            // panel24
            // 
            panel24.Controls.Add(this.dtgvTable);
            panel24.Location = new Point(6, 55);
            panel24.Name = "panel24";
            panel24.Size = new Size(557, 545);
            panel24.TabIndex = 7;
            // 
            // dtgvTable
            // 
            this.dtgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTable.Location = new Point(3, 3);
            this.dtgvTable.Name = "dtgvTable";
            this.dtgvTable.RowHeadersWidth = 62;
            this.dtgvTable.RowTemplate.Height = 33;
            this.dtgvTable.Size = new Size(551, 539);
            this.dtgvTable.TabIndex = 0;
            // 
            // panel25
            // 
            panel25.Controls.Add(btnShowTable);
            panel25.Controls.Add(btnDeleteTable);
            panel25.Controls.Add(btnEditTable);
            panel25.Controls.Add(btnAddTable);
            panel25.Location = new Point(6, 6);
            panel25.Name = "panel25";
            panel25.Size = new Size(557, 43);
            panel25.TabIndex = 6;
            // 
            // btnShowTable
            // 
            btnShowTable.Location = new Point(442, 4);
            btnShowTable.Name = "btnShowTable";
            btnShowTable.Size = new Size(112, 34);
            btnShowTable.TabIndex = 4;
            btnShowTable.Text = "Show";
            btnShowTable.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(299, 4);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(112, 34);
            btnDeleteTable.TabIndex = 3;
            btnDeleteTable.Text = "Delete";
            btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // btnEditTable
            // 
            btnEditTable.Location = new Point(154, 4);
            btnEditTable.Name = "btnEditTable";
            btnEditTable.Size = new Size(112, 34);
            btnEditTable.TabIndex = 2;
            btnEditTable.Text = "Edit";
            btnEditTable.UseVisualStyleBackColor = true;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(3, 4);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(112, 34);
            btnAddTable.TabIndex = 1;
            btnAddTable.Text = "Add";
            btnAddTable.UseVisualStyleBackColor = true;
            // 
            // panel27
            // 
            panel27.Controls.Add(btnResetPassword);
            panel27.Controls.Add(panel29);
            panel27.Controls.Add(panel30);
            panel27.Controls.Add(panel31);
            panel27.Location = new Point(569, 55);
            panel27.Name = "panel27";
            panel27.Size = new Size(446, 545);
            panel27.TabIndex = 8;
            // 
            // panel29
            // 
            panel29.Controls.Add(cbAccountType);
            panel29.Controls.Add(label14);
            panel29.Location = new Point(3, 133);
            panel29.Name = "panel29";
            panel29.Size = new Size(440, 59);
            panel29.TabIndex = 4;
            // 
            // cbAccountType
            // 
            cbAccountType.FormattingEnabled = true;
            cbAccountType.Location = new Point(195, 10);
            cbAccountType.Name = "cbAccountType";
            cbAccountType.Size = new Size(242, 33);
            cbAccountType.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(3, 14);
            label14.Name = "label14";
            label14.Size = new Size(74, 29);
            label14.TabIndex = 0;
            label14.Text = "Type:";
            // 
            // panel30
            // 
            panel30.Controls.Add(txbDisplayName);
            panel30.Controls.Add(label15);
            panel30.Location = new Point(3, 68);
            panel30.Name = "panel30";
            panel30.Size = new Size(440, 59);
            panel30.TabIndex = 3;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(195, 14);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(242, 31);
            txbDisplayName.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(3, 14);
            label15.Name = "label15";
            label15.Size = new Size(174, 29);
            label15.TabIndex = 0;
            label15.Text = "Display name:";
            // 
            // panel31
            // 
            panel31.Controls.Add(txbUsername);
            panel31.Controls.Add(label16);
            panel31.Location = new Point(3, 3);
            panel31.Name = "panel31";
            panel31.Size = new Size(440, 59);
            panel31.TabIndex = 2;
            // 
            // txbUsername
            // 
            txbUsername.Location = new Point(195, 14);
            txbUsername.Name = "txbUsername";
            txbUsername.ReadOnly = true;
            txbUsername.Size = new Size(242, 31);
            txbUsername.TabIndex = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(3, 14);
            label16.Name = "label16";
            label16.Size = new Size(134, 29);
            label16.TabIndex = 0;
            label16.Text = "Username:";
            // 
            // panel32
            // 
            panel32.Controls.Add(dtgvAccount);
            panel32.Location = new Point(6, 55);
            panel32.Name = "panel32";
            panel32.Size = new Size(557, 545);
            panel32.TabIndex = 7;
            // 
            // dtgvAccount
            // 
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(3, 3);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersWidth = 62;
            dtgvAccount.RowTemplate.Height = 33;
            dtgvAccount.Size = new Size(551, 539);
            dtgvAccount.TabIndex = 0;
            // 
            // panel33
            // 
            panel33.Controls.Add(btnShowAccount);
            panel33.Controls.Add(btnDeleteAccount);
            panel33.Controls.Add(this.btnEditAccount);
            panel33.Controls.Add(btnAddAccount);
            panel33.Location = new Point(6, 6);
            panel33.Name = "panel33";
            panel33.Size = new Size(557, 43);
            panel33.TabIndex = 6;
            // 
            // btnShowAccount
            // 
            btnShowAccount.Location = new Point(442, 4);
            btnShowAccount.Name = "btnShowAccount";
            btnShowAccount.Size = new Size(112, 34);
            btnShowAccount.TabIndex = 4;
            btnShowAccount.Text = "Show";
            btnShowAccount.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(299, 4);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(112, 34);
            btnDeleteAccount.TabIndex = 3;
            btnDeleteAccount.Text = "Delete";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new Point(154, 4);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new Size(112, 34);
            this.btnEditAccount.TabIndex = 2;
            this.btnEditAccount.Text = "Edit";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(3, 4);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(112, 34);
            btnAddAccount.TabIndex = 1;
            btnAddAccount.Text = "Add";
            btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // txbCategoryId
            // 
            txbCategoryId.Location = new Point(143, 14);
            txbCategoryId.Name = "txbCategoryId";
            txbCategoryId.ReadOnly = true;
            txbCategoryId.Size = new Size(294, 31);
            txbCategoryId.TabIndex = 2;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(344, 198);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(99, 66);
            btnResetPassword.TabIndex = 5;
            btnResetPassword.Text = "Reset Password";
            btnResetPassword.UseVisualStyleBackColor = true;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 668);
            Controls.Add(tcAdmin);
            Name = "fAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            tcAdmin.ResumeLayout(false);
            tpBill.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvBill).EndInit();
            panel1.ResumeLayout(false);
            tpFood.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tpFoodCategory.ResumeLayout(false);
            tpTable.ResumeLayout(false);
            tpAccount.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).EndInit();
            panel17.ResumeLayout(false);
            panel19.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            panel23.ResumeLayout(false);
            panel23.PerformLayout();
            panel24.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.dtgvTable).EndInit();
            panel25.ResumeLayout(false);
            panel27.ResumeLayout(false);
            panel29.ResumeLayout(false);
            panel29.PerformLayout();
            panel30.ResumeLayout(false);
            panel30.PerformLayout();
            panel31.ResumeLayout(false);
            panel31.PerformLayout();
            panel32.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            panel33.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcAdmin;
        private TabPage tpBill;
        private TabPage tpFood;
        private TabPage tpFoodCategory;
        private TabPage tpTable;
        private TabPage tpAccount;
        private Panel panel1;
        private Button btnViewBill;
        private DateTimePicker dtpkToDate;
        private DateTimePicker dtpkFromDate;
        private Panel panel2;
        private DataGridView dtgvBill;
        private Panel panel3;
        private Panel panel6;
        private Panel panel5;
        private DataGridView dataGridView1;
        private Panel panel4;
        private Button btnShowFood;
        private Button btnDeleteFood;
        private Button btnEditFood;
        private Button btnAddFood;
        private Button btnSearchFood;
        private TextBox txbSearchFood;
        private Panel panel7;
        private TextBox txbFoodId;
        private Label label1;
        private Panel panel8;
        private TextBox txbFoodName;
        private Label label2;
        private Panel panel9;
        private ComboBox cbFoodCategory;
        private Label label3;
        private Panel panel10;
        private NumericUpDown nmFoodPrice;
        private Label label4;
        private Panel panel11;
        private Panel panel12;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private Panel panel13;
        private ComboBox comboBox1;
        private Label label6;
        private Panel panel14;
        private TextBox txbCategoryName;
        private Label label7;
        private Panel panel15;
        private Label label8;
        private Panel panel16;
        private DataGridView dtgvCategory;
        private Panel panel17;
        private Button btnShowCategory;
        private Button btnDeleteCategory;
        private Button btnEditCategory;
        private Button btnAddCategory;
        private Panel panel19;
        private Panel panel20;
        private NumericUpDown numericUpDown2;
        private Label label9;
        private Panel panel21;
        private ComboBox cbTableStatus;
        private ComboBox comboBox2;
        private Label label10;
        private Panel panel22;
        private TextBox txbTableName;
        private TextBox textBox4;
        private Label label11;
        private Panel panel23;
        private TextBox txbTableId;
        private Label label12;
        private Panel panel24;
        private DataGridView dtgvTable;
        private DataGridView dataGridView3;
        private Panel panel25;
        private Button btnShowTable;
        private Button btnDeleteTable;
        private Button btnEditTable;
        private Button btnAddTable;
        private Panel panel27;
        private Panel panel28;
        private NumericUpDown numericUpDown3;
        private Label label13;
        private Panel panel29;
        private ComboBox cbAccountType;
        private Label label14;
        private Panel panel30;
        private TextBox txbDisplayName;
        private Label label15;
        private Panel panel31;
        private TextBox txbUsername;
        private Label label16;
        private Panel panel32;
        private DataGridView dtgvAccount;
        private Panel panel33;
        private Button btnShowAccount;
        private Button btnDeleteAccount;
        private Button btnEditAccount;
        private Button button13;
        private Button btnAddAccount;
        private Panel panel34;
        private Button button15;
        private TextBox textBox9;
        private TextBox txbCategoryId;
        private Button btnResetPassword;
    }
}