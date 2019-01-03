using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheNorthernHandyManReDone11_3_18.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SkidSteerWork()
        {
            return View();
        }
        public ActionResult SnowRemoval()
        {
            return View();
        }

        public ActionResult StormRelief()
        {
            return View();
        }

        public ActionResult LandScapeMaintenance()
        {
            return View();
        }
        public ActionResult LandScapeDesignBuild()
        {
            return View();
        }
        public ActionResult TreeRemoval()
        {
            return View();
        }
        public ActionResult Landscape_Lawncare_Index(int? carouselId)
        {
            if (carouselId == null)
            {
                carouselId = 1;
            }

            ViewBag.CarouselId = carouselId;

            return View();
        }
    }
}