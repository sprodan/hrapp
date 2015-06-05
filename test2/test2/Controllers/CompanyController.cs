using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRAPP.BL.Concrete;
using test2.Models;
using Microsoft.AspNet.Identity;

namespace test2.Controllers
{
    public class CompanyController : Controller
    {
        public ActionResult Company()
        {
            try
            {
                int id = UserBL.ReadAll().First(u => u.Name == User.Identity.GetUserName()).Id;
                return View((CompanyViewModel)CompanyBL.Read(Convert.ToInt32(id)));
            }
            catch (Exception)
            {
                return View((CompanyViewModel)CompanyBL.Read(Convert.ToInt32(-1)));
                throw;
            }
            
            
        }

        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public bool Edit(CompanyViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int id = UserBL.ReadAll().First(u => u.Name == User.Identity.GetUserName()).Id;
                    var oldModel = (CompanyViewModel)CompanyBL.Read(Convert.ToInt32(id));
                    oldModel.Name = viewModel.Name;
                    oldModel.Address = viewModel.Address;
                    oldModel.Mail = viewModel.Mail;
                    CompanyBL.Update(oldModel);
                    return true;
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