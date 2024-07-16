namespace WinFormsBank
{
    partial class Form1
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
            MakeAccount = new Button();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            createAccount = new Button();
            Done = new Button();
            usernameTaken = new TextBox();
            login = new Button();
            delete = new Button();
            Incorrect = new TextBox();
            ready = new Button();
            checkBalance = new Button();
            deposit = new Button();
            withdraw = new Button();
            logout = new Button();
            balanceText = new TextBox();
            dones = new Button();
            depositNumber = new TextBox();
            deposits = new Button();
            Error = new TextBox();
            withdraws = new Button();
            withdrawText = new TextBox();
            deletes = new Button();
            SuspendLayout();
            // 
            // MakeAccount
            // 
            MakeAccount.BackColor = Color.DarkGoldenrod;
            MakeAccount.Location = new Point(254, 318);
            MakeAccount.Name = "MakeAccount";
            MakeAccount.Size = new Size(281, 60);
            MakeAccount.TabIndex = 0;
            MakeAccount.Text = "Make a new account";
            MakeAccount.UseVisualStyleBackColor = false;
            MakeAccount.Click += MakeAccount_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.Aquamarine;
            passwordTextBox.Location = new Point(314, 198);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(150, 31);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.Text = "password";
            passwordTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.Aquamarine;
            usernameTextBox.Location = new Point(314, 142);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(150, 31);
            usernameTextBox.TabIndex = 5;
            usernameTextBox.Text = "username";
            // 
            // createAccount
            // 
            createAccount.BackColor = SystemColors.ControlDark;
            createAccount.Location = new Point(326, 268);
            createAccount.Name = "createAccount";
            createAccount.Size = new Size(130, 43);
            createAccount.TabIndex = 6;
            createAccount.Text = "Create ";
            createAccount.UseVisualStyleBackColor = false;
            createAccount.Click += createAccount_Click;
            // 
            // Done
            // 
            Done.BackColor = Color.Coral;
            Done.Location = new Point(334, 403);
            Done.Name = "Done";
            Done.Size = new Size(111, 33);
            Done.TabIndex = 7;
            Done.Text = "Done";
            Done.UseVisualStyleBackColor = false;
            Done.Click += Done_Click;
            // 
            // usernameTaken
            // 
            usernameTaken.BackColor = Color.CornflowerBlue;
            usernameTaken.ForeColor = Color.Black;
            usernameTaken.Location = new Point(291, 53);
            usernameTaken.Margin = new Padding(4, 5, 4, 5);
            usernameTaken.Name = "usernameTaken";
            usernameTaken.ReadOnly = true;
            usernameTaken.Size = new Size(193, 31);
            usernameTaken.TabIndex = 8;
            usernameTaken.TabStop = false;
            usernameTaken.Text = "Username already taken.";
            // 
            // login
            // 
            login.Location = new Point(71, 20);
            login.Margin = new Padding(4, 5, 4, 5);
            login.Name = "login";
            login.Size = new Size(107, 38);
            login.TabIndex = 9;
            login.Text = "Log In";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // delete
            // 
            delete.Location = new Point(573, 20);
            delete.Margin = new Padding(4, 5, 4, 5);
            delete.Name = "delete";
            delete.Size = new Size(176, 38);
            delete.TabIndex = 10;
            delete.Text = "Delete an Account";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // Incorrect
            // 
            Incorrect.BackColor = Color.CornflowerBlue;
            Incorrect.ForeColor = Color.Black;
            Incorrect.Location = new Point(311, 5);
            Incorrect.Margin = new Padding(4, 5, 4, 5);
            Incorrect.Name = "Incorrect";
            Incorrect.ReadOnly = true;
            Incorrect.Size = new Size(153, 31);
            Incorrect.TabIndex = 11;
            Incorrect.TabStop = false;
            Incorrect.Text = "Incorrect, try again.";
            // 
            // ready
            // 
            ready.BackColor = SystemColors.ControlDark;
            ready.Location = new Point(326, 268);
            ready.Name = "ready";
            ready.Size = new Size(130, 43);
            ready.TabIndex = 12;
            ready.Text = "Ready";
            ready.UseVisualStyleBackColor = false;
            ready.Click += ready_Click;
            // 
            // checkBalance
            // 
            checkBalance.BackColor = Color.BlanchedAlmond;
            checkBalance.Location = new Point(59, 170);
            checkBalance.Margin = new Padding(4, 5, 4, 5);
            checkBalance.Name = "checkBalance";
            checkBalance.Size = new Size(137, 38);
            checkBalance.TabIndex = 13;
            checkBalance.Text = "Check Balance";
            checkBalance.UseVisualStyleBackColor = false;
            checkBalance.Click += checkBalance_Click;
            // 
            // deposit
            // 
            deposit.BackColor = Color.Cyan;
            deposit.Location = new Point(71, 272);
            deposit.Margin = new Padding(4, 5, 4, 5);
            deposit.Name = "deposit";
            deposit.Size = new Size(107, 38);
            deposit.TabIndex = 14;
            deposit.Text = "Deposit";
            deposit.UseVisualStyleBackColor = false;
            deposit.Click += deposit_Click;
            // 
            // withdraw
            // 
            withdraw.BackColor = Color.Olive;
            withdraw.Location = new Point(611, 170);
            withdraw.Margin = new Padding(4, 5, 4, 5);
            withdraw.Name = "withdraw";
            withdraw.Size = new Size(107, 38);
            withdraw.TabIndex = 15;
            withdraw.Text = "Withdraw";
            withdraw.UseVisualStyleBackColor = false;
            withdraw.Click += withdraw_Click;
            // 
            // logout
            // 
            logout.BackColor = Color.SandyBrown;
            logout.Location = new Point(611, 272);
            logout.Margin = new Padding(4, 5, 4, 5);
            logout.Name = "logout";
            logout.Size = new Size(107, 38);
            logout.TabIndex = 16;
            logout.Text = "Log Out";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // balanceText
            // 
            balanceText.BackColor = Color.DarkKhaki;
            balanceText.Location = new Point(314, 244);
            balanceText.Name = "balanceText";
            balanceText.ReadOnly = true;
            balanceText.Size = new Size(150, 31);
            balanceText.TabIndex = 0;
            // 
            // dones
            // 
            dones.BackColor = Color.Cornsilk;
            dones.Location = new Point(334, 374);
            dones.Name = "dones";
            dones.Size = new Size(112, 34);
            dones.TabIndex = 17;
            dones.Text = "Ready";
            dones.UseVisualStyleBackColor = false;
            dones.Click += dones_Click;
            // 
            // depositNumber
            // 
            depositNumber.Location = new Point(314, 92);
            depositNumber.Name = "depositNumber";
            depositNumber.Size = new Size(150, 31);
            depositNumber.TabIndex = 18;
            depositNumber.TabStop = false;
            depositNumber.Text = "0";
            // 
            // deposits
            // 
            deposits.BackColor = Color.Fuchsia;
            deposits.Location = new Point(334, 293);
            deposits.Name = "deposits";
            deposits.Size = new Size(112, 34);
            deposits.TabIndex = 19;
            deposits.Text = "Ready";
            deposits.UseVisualStyleBackColor = false;
            deposits.Click += deposits_Click;
            // 
            // Error
            // 
            Error.BackColor = Color.CornflowerBlue;
            Error.Location = new Point(311, 27);
            Error.Name = "Error";
            Error.ReadOnly = true;
            Error.Size = new Size(150, 31);
            Error.TabIndex = 20;
            Error.Text = "Error";
            // 
            // withdraws
            // 
            withdraws.BackColor = Color.SlateBlue;
            withdraws.Location = new Point(334, 317);
            withdraws.Name = "withdraws";
            withdraws.Size = new Size(112, 34);
            withdraws.TabIndex = 21;
            withdraws.Text = "Ready";
            withdraws.UseVisualStyleBackColor = false;
            withdraws.Click += withdraws_Click;
            // 
            // withdrawText
            // 
            withdrawText.Location = new Point(314, 116);
            withdrawText.Name = "withdrawText";
            withdrawText.Size = new Size(150, 31);
            withdrawText.TabIndex = 22;
            withdrawText.Text = "0";
            // 
            // deletes
            // 
            deletes.BackColor = SystemColors.ActiveCaption;
            deletes.Location = new Point(334, 344);
            deletes.Name = "deletes";
            deletes.Size = new Size(112, 34);
            deletes.TabIndex = 23;
            deletes.Text = "Ready";
            deletes.UseVisualStyleBackColor = false;
            deletes.Click += deletes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(deletes);
            Controls.Add(withdrawText);
            Controls.Add(withdraws);
            Controls.Add(Error);
            Controls.Add(deposits);
            Controls.Add(depositNumber);
            Controls.Add(dones);
            Controls.Add(balanceText);
            Controls.Add(logout);
            Controls.Add(withdraw);
            Controls.Add(deposit);
            Controls.Add(checkBalance);
            Controls.Add(ready);
            Controls.Add(Incorrect);
            Controls.Add(delete);
            Controls.Add(login);
            Controls.Add(usernameTaken);
            Controls.Add(Done);
            Controls.Add(createAccount);
            Controls.Add(usernameTextBox);
            Controls.Add(MakeAccount);
            Controls.Add(passwordTextBox);
            Name = "Form1";
            Text = "Form 1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MakeAccount;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private Button createAccount;
        private Button Done;
        private TextBox usernameTaken;
        private Button login;
        private Button delete;
        private TextBox Incorrect;
        private Button ready;
        private Button checkBalance;
        private Button deposit;
        private Button withdraw;
        private Button logout;
        private TextBox balanceText;
        private Button dones;
        private TextBox depositNumber;
        private Button deposits;
        private TextBox Error;
        private Button withdraws;
        private TextBox withdrawText;
        private Button deletes;
    }
}
