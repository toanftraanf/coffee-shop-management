namespace CoffeeShopManagement
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnExit = new Button();
            btnLogin = new Button();
            panel3 = new Panel();
            txbPassword = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            txbUsername = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 187);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(395, 142);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(124, 34);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(146, 142);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(243, 34);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txbPassword);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(3, 68);
            panel3.Name = "panel3";
            panel3.Size = new Size(519, 59);
            panel3.TabIndex = 2;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(143, 14);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(373, 31);
            txbPassword.TabIndex = 2;
            txbPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 14);
            label2.Name = "label2";
            label2.Size = new Size(133, 29);
            label2.TabIndex = 0;
            label2.Text = "Password:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbUsername);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(519, 59);
            panel2.TabIndex = 0;
            // 
            // txbUsername
            // 
            txbUsername.Location = new Point(143, 14);
            txbUsername.Name = "txbUsername";
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
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 225);
            Controls.Add(panel1);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += fLogin_FormClosing;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private TextBox txbPassword;
        private Label label2;
        private Panel panel2;
        private TextBox txbUsername;
        private Label label1;
        private Button btnExit;
        private Button btnLogin;
    }
}