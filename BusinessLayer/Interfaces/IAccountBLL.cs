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
        void PostAccount(Account account);
        void GetAccount(int id);
        void DeleteAccount(int id);
        void PutAccount(int id);
        // TODO lav updatebalance?
        //void updateBalance();
    }
}
