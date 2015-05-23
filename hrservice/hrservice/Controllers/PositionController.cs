using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hrservice.Controllers
{
    public class PositionController :   Controller
    {
        // GET: Position
        public ActionResult Position()
        {
            return View();
        }

        // GET: Position
        public ActionResult Create()
        {
            return View();
        }
    }
}