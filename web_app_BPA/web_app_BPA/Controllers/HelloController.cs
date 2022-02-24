using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_app_BPA.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }


        public String Welcome(String name, int id=1) => HttpUtility.HtmlEncode("Hello " + name + " id " + id);
    }
}