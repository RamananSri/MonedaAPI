using BusinessLayer;
using BusinessLayer.Interfaces;
using ModelLayer;
using System;
using System.Net;
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
                return Ok();
            }
            catch (InvalidOperationException)
            {
                return Content(HttpStatusCode.NotFound, "Brugernavn eller password passer ikke");
            }
            catch (Exception)
            {
                return Content(HttpStatusCode.InternalServerError,"Server fejl");
            }    
        }
    }
}
