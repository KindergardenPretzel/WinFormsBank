using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Security.Policy;
using System.Security.Principal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsBank
{
    public partial class Form1 : Form
    {
        Bank bank;
        Account current;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Error.Visible = false;
            deposits.Visible = false;
            deposit.Visible = false;
            depositNumber.Visible = false;
            login.Visible = false;
            delete.Visible = false;
            usernameTextBox.Visible = false;
            passwordTextBox.Visible = false;
            createAccount.Visible = false;
            MakeAccount.Visible = true;
            usernameTaken.Visible = false;
            Incorrect.Visible = false;
            Done.Visible = false;
            ready.Visible = false;
            checkBalance.Visible = false;
            bank = new Bank();
            balanceText.Visible = false;
            dones.Visible = false;
        }

        private void MakeAccount_Click(object sender, EventArgs e)
        {

            usernameTextBox.Visible = true;
            passwordTextBox.Visible = true;
            createAccount.Visible = true;
            usernameTextBox.Text = "username";
            passwordTextBox.Text = "password";
            //usernameTextBox.Text 
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            usernameTaken.Visible = true;
            MakeAccount.Visible = false;
            Done.Visible = false;
            if (bank.Contains(usernameTextBox.Text))
            {
                usernameTextBox.ReadOnly = false;
                passwordTextBox.ReadOnly = false;
                return;
            }
            MakeAccount.Visible = true;
            usernameTaken.Visible = false;
            Done.Visible = true;
            Account account = new Account(usernameTextBox.Text, passwordTextBox.Text, 0);
            bank.Add(account);
            usernameTextBox.Visible = false;
            passwordTextBox.Visible = false;
            createAccount.Visible = false;
            Done.Visible = true;
        }

        private void Done_Click(object sender, EventArgs e)
        {
            usernameTextBox.Visible = false;
            passwordTextBox.Visible = false;
            createAccount.Visible = false;
            MakeAccount.Visible = false;
            Done.Visible = false;
            login.Visible = true;
            delete.Visible = true;
        }

        private void login_Click(object sender, EventArgs e)
        {
            login.Visible = false;
            delete.Visible = false;
            usernameTextBox.Visible = true;
            passwordTextBox.Visible = true;
            usernameTextBox.ReadOnly = false;
            passwordTextBox.ReadOnly = false;
            ready.Visible = true;
        }

        private void ready_Click(object sender, EventArgs e)
        {
            if (!bank.Contains(usernameTextBox.Text))
            {
                Incorrect.Visible = true;
                usernameTextBox.ReadOnly = false;
                passwordTextBox.ReadOnly = false;
                return;
            }
            Incorrect.Visible = false;
            usernameTextBox.Visible = false;
            passwordTextBox.Visible = false;
            ready.Visible = false;
            checkBalance.Visible = true;
            deposit.Visible = true;
            current = bank.GetAccount(usernameTextBox.Text, passwordTextBox.Text);
        }

        private void checkBalance_Click(object sender, EventArgs e)
        {

            balanceText.Visible = true;
            balanceText.Text = current.checkBalance().ToString();
            dones.Visible = true;
        }

        private void dones_Click(object sender, EventArgs e)
        {
            dones.Visible = false;
            balanceText.Visible = false;
            checkBalance.Visible = true;

        }

        private void deposit_Click(object sender, EventArgs e)
        {

            deposits.Visible = true;
            depositNumber.Visible = true;
            balanceText.Visible = true;
            balanceText.Text = current.checkBalance().ToString();
            
            
        }

        private void deposits_Click(object sender, EventArgs e)
        {
            float balance = current.checkBalance();
            float deposit_float = float.Parse(depositNumber.Text);
            if (current.deposit(deposit_float))
            {
                balance = current.checkBalance();
                balanceText.Text = balance.ToString();
            }
            else
            {
                Error.Visible = true;
                return;
            }
            deposits.Visible = false;
            depositNumber.Visible = false;
            balanceText.Visible = false;
        }
    }
}
