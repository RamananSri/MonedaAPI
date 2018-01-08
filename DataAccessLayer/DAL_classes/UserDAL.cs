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
                    if(user != null)
                    {
                        return user;
                    }
                    else
                    {
                        throw new NullReferenceException();
                    }             
                }
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void PostUser(User user)
        {
            throw new NotImplementedException();
        }

        public void PutUser(User user)
        {
            throw new NotImplementedException();
        }

        //public void Delete
    }
}
