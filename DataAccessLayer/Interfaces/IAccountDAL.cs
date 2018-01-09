using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IAccountDAL
    {
        Account getBalance(Account account);
        void PostBalance(int amount);
        void DeleteAccount(Account account);
        void AddAccount(Account account);
        void PutAccount(Account account);
    }
}
