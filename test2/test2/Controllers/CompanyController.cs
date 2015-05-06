using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test2.Models;

namespace test2.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Company()
        {
            IEnumerable<PositionViewModel> Positions = GetPositions();
            return View();
        }

        private IEnumerable<PositionViewModel> GetPositions()
        {
            return new List<PositionViewModel>
            {
                new PositionViewModel {Name = ".Net", UsersCount = 50},
                new PositionViewModel {Name = "Java", UsersCount = 2}
            };
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