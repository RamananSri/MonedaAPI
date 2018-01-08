using BusinessLayer.Interfaces;
using DataAccessLayer.DAL_classes;
using DataAccessLayer.Interfaces;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UserBLL : IUserBLL
    {
        IUserDAL db;

        // TODO: IoC constructor injection

        //public UserBLL(IUserDAL db)
        //{
        //    this.db = db;
        //}

        public UserBLL()
        {
            db = new UserDAL();
        }

        public void DeleteUser(string username)
        {
            throw new NotImplementedException();
        }

        public void Login(User user)
        {
            //TODO: Simple login (hash/salt check) + bedre try catch

            User u;

            try
            {
                u = db.GetUser(user.Username);
            }
            catch (Exception)
            {
                throw;
            }
            
            if (u.Password != user.Password)
            {
                //TODO: Exception der svarer til statuscode??
                throw new Exception();
            }

            return;
        }

        public void PostUser(User user)
        {
            throw new NotImplementedException();
        }

        public void PutUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
