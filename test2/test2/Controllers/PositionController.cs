using HRAPP.BL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using test2.Models;

namespace test2.Controllers
{
    public class PositionController :   Controller
    {
        // GET: Position
        public ActionResult Position(int companyId)
        {
            return View(PositionBL.ReadByCompany(companyId));
        }

        // GET: Position
        public ActionResult Create()
        {
            return View(new PositionViewModel());
        }

        //
        // POST: /Group/Create
        [HttpPost]
        public ActionResult Create(PositionViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var id = UserBL.ReadAll().First(u => u.Name == User.Identity.GetUserName()).Id;
                    viewModel.CompanyId = CompanyBL.Read(id).Id;

                    PositionBL.Create(viewModel);
                    return RedirectToAction("../Company/Company");
                }
                return View(new PositionViewModel());
            }
            catch
            {
                return View(new PositionViewModel());
            }
        }



        // GET: /Position/Edit/5
        public ActionResult Edit(int id)
        {
            var _model = (PositionViewModel)PositionBL.Read(id);
            return View(_model);
        }

        //
        // POST: /Position/Edit/5
        [HttpPost]
        public ActionResult Edit(PositionViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    PositionBL.Update(viewModel);
                    return RedirectToAction("../Company/Company");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
                throw;
            }
        }
    }
}