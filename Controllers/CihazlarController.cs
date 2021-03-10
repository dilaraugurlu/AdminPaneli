using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Oee_AdminTemplate2.Controllers
{
    public class CihazlarController : Controller
    {
        // GET: Cihazlar
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TumCihazlar()
        {
            return View();
        }

        public ActionResult CihazOlustur()
        {
            return View();
        }

        public ActionResult CihazDuzenle()
        {
            return View();
        }
    }
}