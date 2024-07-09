using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBank
{
    internal class Bank
    {
        int count = 0;
        private Account[] accounts = new Account[5];
        public Bank()
        {

        }
        public bool Contains(string username)
        {
            for (int i = 0; i < count; i++)
            {
                if (username == accounts[i].GetUsername())
                {
                    return true;
                }
            }
            return false;
        }
        public void Add(Account newAccount)
        {
            accounts[count] = newAccount;
            count++;
            if (count == accounts.Length)
            {
                Resize();
            }
        }
        public Account GetAccount(string username, string password)
        {
            for (int i = 0; i < count; i++)
            {
                if (accounts[i].checkLogin(username, password))
                {
                    return accounts[i];
                }
            }
            return null;
        }
        public void Resize()
        {
            Account[] newAccounts = new Account[accounts.Length * 2];
            for (int i = 0; i < accounts.Length; i++)
            {
                newAccounts[i] = accounts[i];
            }
            accounts = newAccounts;
        }
        public void DeleteAccount(string username, string password)
        {
            for (int i = 0; i < count; i++)
            {
                if (accounts[i].checkLogin(username, password))
                {
                    for (int j = i; j < count; j++)
                    {
                        accounts[j] = accounts[j + 1];
                    }
                    //return accounts[i];
                }
            }
            count--;
            //return null;
        }
    }
}
