using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Taxi.Models;
using Taxi.Service;

namespace Taxi.Controllers
{
    public class DocumentController : Controller
    {
        //
        // GET: /Document/
        private TaxiService taxiService;

        public DocumentController()
        {
            taxiService = new TaxiService();
        }

        public ActionResult CreateOrder()
        {
            List<Automobile> automobiles = taxiService.GetAutomobileCollection();
            return View(automobiles);
        }

    }
}
