using BusinessLayer;
using ModelLayer;
using System;
using System.Net;
using System.Web.Http;

namespace ServiceLayer.Controllers
{

    public class UsersController : ApiController
    {
        UserBLL _userBLL;
        public UsersController()
        {
            _userBLL = new UserBLL();
        }

        public IHttpActionResult Post(User user)
        {
            try
            {
                _userBLL.PostUser(user);
                return Ok();
            }
            catch (InvalidOperationException)
            {
                return Content(HttpStatusCode.BadRequest, "Det lykkedes ikke at oprette en bruger");
            }
            catch (Exception)
            {
                return Content(HttpStatusCode.InternalServerError, "Noget gik galt på serveren");
            }
        }
    }
}
