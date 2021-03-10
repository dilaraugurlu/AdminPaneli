using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Oee_AdminTemplate2.Controllers
{
    public class SensorlerController : Controller
    {
        // GET: Sensorler
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TumSensorler()
        {
            return View();
        }

        public ActionResult SensoruDuzenle()
        {
            return View();
        }
    }
}