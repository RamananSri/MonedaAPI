using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IUserBLL
    {
        void Login(User user);

        void PostUser(User user);
        void DeleteUser(string username);
        void PutUser(User user);
    }
}
