using HRAPP.BL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test2.Models;

namespace test2.Controllers
{
    public class PositionController :   Controller
    {
        // GET: Position
        public ActionResult Positions(int companyId )
        {
            return PartialView((PositionViewModel)PositionBL.ReadByCompany(companyId));
        }

        // GET: Position
        public ActionResult Create()
        {
            return View();
        }
    }
}