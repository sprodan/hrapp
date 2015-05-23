using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using HRAPP.BL.Concrete;
using hrservice.Models;

namespace hrservice.Controllers
{
    public class GroupController : Controller
    {
        //
        // GET: /Group/
        public ActionResult Group()
        {
            return View();
        }

        //
        // GET: /Group/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Group/Create
        public ActionResult Create(int _companyId)
        {
            GroupViewModel _view = new GroupViewModel()
            {
                CompanyId = _companyId
            };

            return View(_view);
        }

        //
        // POST: /Group/Create
        [HttpPost]
        public ActionResult Create(GroupViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    GroupBL.Create(viewModel);
                    return RedirectToAction("../Company/Company");
                }
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

       
        //
        // GET: /Group/Edit/5
        public ActionResult Edit(int id)
        {
            var _model = (GroupViewModel)GroupBL.Read(id);
            return View(_model);
        }

        //
        // POST: /Group/Edit/5
        [HttpPost]
        public ActionResult Edit(GroupViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    GroupBL.Update(viewModel);
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

        //
        // GET: /Group/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Group/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
