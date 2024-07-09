using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Security.Policy;
using System.Security.Principal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsBank
{
    public partial class Form1 : Form
    {
        Bank bank;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usernameTextBox.Visible = false;
            passwordTextBox.Visible = false;
            createAccount.Visible = false;
            MakeAccount.Visible = true;
            usernameTaken.Visible = true;
            usernameTaken.Visible = false;
            Done.Visible = false;
            bank = new Bank();
        }

        private void MakeAccount_Click(object sender, EventArgs e)
        {

            usernameTextBox.Visible = true;
            passwordTextBox.Visible = true;
            createAccount.Visible = true;
            Done.Visible = true;
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
        }

        private void Done_Click(object sender, EventArgs e)
        {
            usernameTextBox.Visible = false;
            passwordTextBox.Visible = false;
            createAccount.Visible = false;
            MakeAccount.Visible = false;
            Done.Visible = false;
        }
    }
}