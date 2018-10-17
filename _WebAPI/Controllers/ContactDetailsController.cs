namespace _WebAPI.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ContactDetailsController : Controller
    {
        private const string control = "api/[controller]";
        private const string user = "/{userName}";
        [Route(control)]
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [Route(control+user)]
        [HttpGet]
        public JsonResult Get(string userName)
        {
            return Json(new _Library.Customer.Customer(){FirstName = "firstName", Surname ="lastName", UserName=userName, Email=$"{userName}@email.com"});
        }
    }
}