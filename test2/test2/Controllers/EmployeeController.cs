using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRAPP.BL.Concrete;
using Microsoft.AspNet.Identity;
using test2.Models;

namespace test2.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Create()
        {
            var id = UserBL.ReadAll().First(u => u.Name == User.Identity.GetUserName()).Id;
            
            ViewBag.Positions = PositionBL.ReadByCompany(CompanyBL.Read(id).Id);
            ViewBag.Groups = GroupBL.ReadByCompany(CompanyBL.Read(id).Id);
            return View(new EmployeeViewModel());
        }

        // POST: /Employee/Create
        [HttpPost]
        public ActionResult Create(EmployeeViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmployeeBL.Create(viewModel);
                    return RedirectToAction("../Company/Company");
                }
                return View(new EmployeeViewModel());
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Employee()
        {

            return View();
        }
    }
}