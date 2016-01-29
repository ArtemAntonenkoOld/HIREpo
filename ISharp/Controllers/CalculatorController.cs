using ISharpConvertor.BL.BaseBindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISharpConvertor.WebUINew.Controllers
{
    public class CalculatorController : Controller
    {
        //
        // GET: /Calculator/
        public ActionResult _CalculateMethod(double rate, string currency1,string currency2,string bank,string sellbuy)
        {
            CalculateBinder binder = new CalculateBinder();
            var res = binder.BindData(currency1,currency2,sellbuy,bank).ToArray();
            if (res[0].Currency == currency1)
            {
                var rate1 = res[0].Rate ;
                var rate2 = res[1].Rate;
                var x = (rate * rate1) /rate2;
                ViewBag.Head = x;
            }
            else
            {
                var rate1 = res[1].Rate;
                var rate2 = res[0].Rate;
                var x = (rate * rate1) / rate2;
                ViewBag.Head = x;
            }     
            
            
            return PartialView(res);
           
        }
        public ActionResult Calculate()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

    }
}
