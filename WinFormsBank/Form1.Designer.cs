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
            button3 = new Button();
            button4 = new Button();
            balanceText = new TextBox();
            dones = new Button();
            depositNumber = new TextBox();
            deposits = new Button();
            Error = new TextBox();
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
            // button3
            // 
            button3.Location = new Point(611, 170);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(107, 38);
            button3.TabIndex = 15;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(611, 272);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(107, 38);
            button4.TabIndex = 16;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(Error);
            Controls.Add(deposits);
            Controls.Add(depositNumber);
            Controls.Add(dones);
            Controls.Add(balanceText);
            Controls.Add(button4);
            Controls.Add(button3);
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
        private Button button3;
        private Button button4;
        private TextBox balanceText;
        private Button dones;
        private TextBox depositNumber;
        private Button deposits;
        private TextBox Error;
    }
}
