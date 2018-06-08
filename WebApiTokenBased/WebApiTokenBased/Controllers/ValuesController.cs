using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiTokenBased.Services;

namespace WebApiTokenBased.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        [HttpGet]
        [Route("api/Users/{id}")]
        public IHttpActionResult GetUser(int id)
        {
            var userService = new UserService();
            var userList = userService.GetUserList();
            var user = userList.FirstOrDefault(x => x.Id == id);
            return Ok(user);
        }
    }
}
