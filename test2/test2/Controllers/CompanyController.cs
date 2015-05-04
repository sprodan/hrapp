using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test2.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Company()
        {
            return View();
        }

        public ActionResult AddPosition()
        {
            return View();
        }

        public ActionResult AddCommand()
        {
            return View();
        }

        public ActionResult AddPerson()
        {
            return View();
        }

        public ActionResult Position()
        {
            return View();
        }

        public ActionResult Command()
        {
            return View();
        }
    }
}