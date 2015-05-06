using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRAPP.BL.Concrete;
using test2.Models;

namespace test2.Controllers
{
    public class CompanyController : Controller
    {
        public ActionResult Company()
        {
            IEnumerable<PositionViewModel> Positions = GetPositions();
            return View((CompanyViewModel)CompanyBL.Read(1));
        }

        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CompanyViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CompanyBL.Update(viewModel);
                    return View("Company");
                }
                throw new Exception();
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
                throw;
            }
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