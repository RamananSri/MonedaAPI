using DataAccessLayer.DAL_classes;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{

    public interface IAccountBLL
    {
        void GetBalance(Account account);
        void AddAccount(Account account);
        void PostBalance(int amount);
        void DeleteAccount(Account account);
        void PutAccount(Account account);
    }
}
