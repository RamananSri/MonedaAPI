using DataAccessLayer.Interfaces;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DAL_classes
{
    public class AccountDAL : IAccountDAL
    {
        public AccountDAL()
        {

        }

        public void DeleteAccount(string id)
        {
            //
        }

        public void GetAccount(string id)
        {
            throw new NotImplementedException();
        }

        public void PostAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public void PutAccount(Account account)
        {
            throw new NotImplementedException();
        }
    }
}
