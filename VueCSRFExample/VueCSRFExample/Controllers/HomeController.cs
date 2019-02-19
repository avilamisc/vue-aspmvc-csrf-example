using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VueCSRFExample.Attribute;

namespace VueCSRFExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return DefaultView();
        }

        protected ViewResult DefaultView()
        {
            return base.View("~/Views/example/Index.cshtml");
        }

        [HttpPost]
        [ValidateRequestToken]
        public ActionResult Submit()
        {
            String res_msg = "Received and processed";

            return Json(res_msg, JsonRequestBehavior.DenyGet);
        }
    }
}