using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheNorthernHandyManReDone11_3_18.Controllers
{
    public class SnowRemovalAlbumController : Controller
    {
        // GET: SnowRemoval
        public ActionResult MainAlbumPage()
        {
            return View();
        }
        public ActionResult Commercial()
        {
            return View();
        }
        public ActionResult Residential()
        {
            return View();
        }
        
    }
}