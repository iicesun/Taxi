using System.Collections.Generic;
using System.Web.Mvc;
using Taxi.Helpers;
using Taxi.Models;
using Taxi.Service;

namespace Taxi.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private readonly ITaxiService _service;

        public HomeController()
        {
            _service = ServiceLocator.ServiceLocatorPropertes.GetService<ITaxiService>();
        }

        public ActionResult Main()
        {
            List<Automobile> automobile = _service.GetAutomobileCollection();
            return View(automobile);
        }

        //[HttpPost] //Ограничивает доступ только через HTTTP метод POST
        public ActionResult Orders(int id)
        {
            List<Order> orders = _service.GetOrdersAutomobile(new Automobile { Id = id });
            return View(orders); 
        }
    }
}
