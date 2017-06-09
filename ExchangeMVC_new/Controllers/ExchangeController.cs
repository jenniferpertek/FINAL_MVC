using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using DTO;

namespace ExchangeMVC_new.Controllers
{
    public class ExchangeController : Controller
    {
        // GET: Products
        ExchangeRESTService ser = new ExchangeRESTService();
        public ActionResult Index()
        {
            CurrencyDetailDTO p = new DTO.CurrencyDetailDTO { Category = "Currency", Name = "YEN", Rate = 0.5m };
            ser.PostExchanges(p);

            return View(ser.GetExchanges());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}