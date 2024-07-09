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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // MakeAccount
            // 
            MakeAccount.BackColor = Color.DarkGoldenrod;
            MakeAccount.Location = new Point(178, 191);
            MakeAccount.Margin = new Padding(2);
            MakeAccount.Name = "MakeAccount";
            MakeAccount.Size = new Size(197, 36);
            MakeAccount.TabIndex = 0;
            MakeAccount.Text = "Make a new account";
            MakeAccount.UseVisualStyleBackColor = false;
            MakeAccount.Click += MakeAccount_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.Aquamarine;
            passwordTextBox.Location = new Point(220, 119);
            passwordTextBox.Margin = new Padding(2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(106, 23);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.Text = "password";
            passwordTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.Aquamarine;
            usernameTextBox.Location = new Point(220, 85);
            usernameTextBox.Margin = new Padding(2);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(106, 23);
            usernameTextBox.TabIndex = 5;
            usernameTextBox.Text = "username";
            // 
            // createAccount
            // 
            createAccount.BackColor = SystemColors.ControlDark;
            createAccount.Location = new Point(228, 161);
            createAccount.Margin = new Padding(2);
            createAccount.Name = "createAccount";
            createAccount.Size = new Size(91, 26);
            createAccount.TabIndex = 6;
            createAccount.Text = "Create ";
            createAccount.UseVisualStyleBackColor = false;
            createAccount.Click += createAccount_Click;
            // 
            // Done
            // 
            Done.BackColor = Color.Coral;
            Done.Location = new Point(234, 242);
            Done.Margin = new Padding(2);
            Done.Name = "Done";
            Done.Size = new Size(78, 20);
            Done.TabIndex = 7;
            Done.Text = "Done";
            Done.UseVisualStyleBackColor = false;
            Done.Click += Done_Click;
            // 
            // usernameTaken
            // 
            usernameTaken.BackColor = Color.CornflowerBlue;
            usernameTaken.ForeColor = Color.Black;
            usernameTaken.Location = new Point(204, 32);
            usernameTaken.Name = "usernameTaken";
            usernameTaken.ReadOnly = true;
            usernameTaken.Size = new Size(136, 23);
            usernameTaken.TabIndex = 8;
            usernameTaken.TabStop = false;
            usernameTaken.Text = "Username already taken.";
            // 
            // button1
            // 
            button1.Location = new Point(46, 70);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(46, 138);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(424, 70);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(usernameTaken);
            Controls.Add(Done);
            Controls.Add(createAccount);
            Controls.Add(usernameTextBox);
            Controls.Add(MakeAccount);
            Controls.Add(passwordTextBox);
            Margin = new Padding(2);
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
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
