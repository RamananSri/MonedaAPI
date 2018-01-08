using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IUserDAL
    {
        User GetUser(string username);
        void PostUser(User user);
        void DeleteUser(string username);
        void PutUser(User user);
    }
}
