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
        void PostAccount(Account account);
        void DeleteAccount(string id);
        void GetAccount(string id);
        void PutAccount(Account account);
    }
}
