using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBank
{
    internal class Account
    {
        private string Username;
        private string Password;
        private float Balance;

        public Account(string username, string password, float balance)
        {
            Username = username;
            Password = password;
            Balance = balance;
        }
        public bool checkLogin(string username, string password)
        {
            if (username == Username && password == Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public float checkBalance()
        {
            return Balance;
        }

        public bool deposit(float amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return true;
            }
            return false;
        }
        public bool withdraw(float amount)
        {
            if (Balance >= amount && amount >= 0)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
        public string GetUsername()
        {
            return Username;
        }
    }
}
