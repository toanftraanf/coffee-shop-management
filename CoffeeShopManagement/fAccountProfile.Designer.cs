namespace CoffeeShopManagement
{
    partial class fAccountProfile
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
            panel2 = new Panel();
            txbUsername = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            txbDisplayName = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            txbPassword = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            txbNewPassword = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            txbReEnterPassword = new TextBox();
            label5 = new Label();
            btnUpdate = new Button();
            btnExit = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txbUsername);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(606, 59);
            panel2.TabIndex = 1;
            // 
            // txbUsername
            // 
            txbUsername.Location = new Point(230, 14);
            txbUsername.Name = "txbUsername";
            txbUsername.ReadOnly = true;
            txbUsername.Size = new Size(373, 31);
            txbUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(134, 29);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // panel1
            // 
            panel1.Controls.Add(txbDisplayName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(606, 59);
            panel1.TabIndex = 2;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(230, 14);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(373, 31);
            txbDisplayName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 14);
            label2.Name = "label2";
            label2.Size = new Size(176, 29);
            label2.TabIndex = 0;
            label2.Text = "Display Name:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbPassword);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 142);
            panel3.Name = "panel3";
            panel3.Size = new Size(606, 59);
            panel3.TabIndex = 3;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(230, 14);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(373, 31);
            txbPassword.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 14);
            label3.Name = "label3";
            label3.Size = new Size(133, 29);
            label3.TabIndex = 0;
            label3.Text = "Password:";
            // 
            // panel4
            // 
            panel4.Controls.Add(txbNewPassword);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(12, 207);
            panel4.Name = "panel4";
            panel4.Size = new Size(606, 59);
            panel4.TabIndex = 4;
            // 
            // txbNewPassword
            // 
            txbNewPassword.Location = new Point(230, 14);
            txbNewPassword.Name = "txbNewPassword";
            txbNewPassword.Size = new Size(373, 31);
            txbNewPassword.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 14);
            label4.Name = "label4";
            label4.Size = new Size(188, 29);
            label4.TabIndex = 0;
            label4.Text = "New password:";
            // 
            // panel5
            // 
            panel5.Controls.Add(txbReEnterPassword);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(12, 272);
            panel5.Name = "panel5";
            panel5.Size = new Size(606, 59);
            panel5.TabIndex = 5;
            // 
            // txbReEnterPassword
            // 
            txbReEnterPassword.Location = new Point(230, 14);
            txbReEnterPassword.Name = "txbReEnterPassword";
            txbReEnterPassword.Size = new Size(373, 31);
            txbReEnterPassword.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 14);
            label5.Name = "label5";
            label5.Size = new Size(235, 29);
            label5.TabIndex = 0;
            label5.Text = "Re-enter password:";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(388, 338);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(506, 338);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // fAccountProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(630, 384);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "fAccountProfile";
            Text = "Personal Information";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txbUsername;
        private Label label1;
        private Panel panel1;
        private TextBox txbDisplayName;
        private Label label2;
        private Panel panel3;
        private TextBox txbPassword;
        private Label label3;
        private Panel panel4;
        private TextBox txbNewPassword;
        private Label label4;
        private Panel panel5;
        private TextBox txbReEnterPassword;
        private Label label5;
        private Button btnUpdate;
        private Button btnExit;
    }
}