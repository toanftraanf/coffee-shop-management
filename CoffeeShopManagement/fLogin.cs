using CoffeeShopManagement.DAO;

namespace CoffeeShopManagement
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string password = txbPassword.Text;
            if (login(username, password))
            {
                fTableManager f = new fTableManager();
                this.Hide();
                f.ShowDialog();
            } else
            {
                MessageBox.Show("Incorrect username or password!");
            }

        }

        bool login(string username, string password)
        {
            return AccountDAO.Instance.login(username, password);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to close the application?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}