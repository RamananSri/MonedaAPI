using BusinessLayer;
using BusinessLayer.Interfaces;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiceLayer.Controllers
{
    public class LoginController : ApiController
    {
        IUserBLL db;

        public LoginController()
        {
            db = new UserBLL();
        }

        public IHttpActionResult Post(User user)
        { 
            try
            {
                db.Login(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return NotFound();
            }

            return Ok();
        }
    }
}
