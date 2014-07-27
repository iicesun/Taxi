using System.Collections.Generic;
using System.Web.Mvc;
using Taxi.Models;
using Taxi.Service;

namespace Taxi.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private TaxiService service;

        public HomeController()
        {
            service = new TaxiService();
        }

        public ActionResult Main()
        {
            List<Automobile> automobile = service.GetAutomobileCollection();
            return View(automobile);
        }

        //[HttpPost] //Ограничивает доступ только через HTTTP метод POST
        public ActionResult Orders(int id)
        {
            List<Order> orders = service.GetOrdersAutomobile(new Automobile { Id = id });
            return View(orders); //View("Orders");
        }
    }
}
