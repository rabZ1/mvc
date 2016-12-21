using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication3.Models;

namespace MvcApplication3.Controllers
{
    public class CustomersController : Controller
    {
        private northwindEntities db = new northwindEntities();

        //
        // GET: /Customers/

        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }

    }
}
