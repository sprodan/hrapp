using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test2.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Test()
        {
            var model = new Models.TestViewModel();
            return View(model);
        }
    }
}