using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRAPP.BL.Concrete;
using hrservice.Models;

namespace hrservice.Controllers
{
    public class CompanyController : Controller
    {
        public ActionResult Company()
        {
            return View((CompanyViewModel)CompanyBL.Read(1));
        }

        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
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

        

        
    }
}