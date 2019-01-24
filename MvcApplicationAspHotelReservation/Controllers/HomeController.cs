using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplicationAspHotelReservation.Models;

namespace MvcApplicationAspHotelReservation.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private HotelsDBEntities _entities = new HotelsDBEntities();

        public ActionResult Index()
        {
            return View(_entities.Hotels.ToList());
        }
    }
}
