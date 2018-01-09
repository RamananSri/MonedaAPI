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

        public void DeleteAccount(int id)
        {
            throw new NotImplementedException();
        }

        public void GetAccount(int id)
        {
            throw new NotImplementedException();
        }

        public void PostAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public void PutAccount(int id)
        {
            throw new NotImplementedException();
        }
    }
}
