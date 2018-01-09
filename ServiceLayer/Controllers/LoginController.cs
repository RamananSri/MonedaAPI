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
        IUserBLL userBLL;

        public LoginController()
        {
            userBLL = new UserBLL();
        }

        public IHttpActionResult Post(User user)
        {
            try
            {
                userBLL.Login(user);
            }
            catch (InvalidOperationException)
            {
                return Content(HttpStatusCode.NotFound, "Brugernavn eller password passer ikke");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Content(HttpStatusCode.InternalServerError,"Server fejl");
            }

            return Ok();
           
            
            
        }
    }
}
