using DataAccessLayer.Interfaces;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DAL_classes
{
    public class UserDAL : IUserDAL
    {
        public UserDAL()
        {
        }

        public void DeleteUser(string username)
        {
            throw new NotImplementedException();
        }

        public User GetUser(string username)
        {
            try
            {
                // "Using" disposes ressource after use
                using (DomainContext ctx = new DomainContext())
                {
                    var user = ctx.users
                               .Where(u => u.Username == username)
                               .First();
                    return user;           
                }
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void PostUser(User user)
        {
            try
            {
                using(DomainContext ctx = new DomainContext())
                {
                    ctx.users.Add(user);
                    ctx.SaveChanges();
                }
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void PutUser(User user)
        {
            throw new NotImplementedException();
        }

        //public void Delete
    }
}
