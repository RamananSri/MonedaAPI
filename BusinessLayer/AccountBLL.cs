using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using DataAccessLayer.DAL_classes;
using DataAccessLayer.Interfaces;
using ModelLayer;

namespace BusinessLayer
{
    public class AccountBLL : IAccountBLL
    {
        IAccountDAL db;
        public AccountBLL()
        {
            db = new AccountDAL();
        }

        public void AddAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public void DeleteAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public void GetBalance(Account account)
        {
            throw new NotImplementedException();
        }

        public void PostBalance(int amount)
        {
            throw new NotImplementedException();
        }

        public void PutAccount(Account account)
        {
            throw new NotImplementedException();
        }
    }
}
