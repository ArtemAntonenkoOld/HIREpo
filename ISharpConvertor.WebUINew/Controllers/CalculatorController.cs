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
        public ActionResult _CalculateMethod(double rate, string currency1,string currency2,string bank)
        {
            CalculateBinder binder = new CalculateBinder();
            var res = binder.BindData(currency1,bank);
            double a = res.FirstOrDefault().Rate;

            double result = a * rate;
             ViewBag.Head=result;
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
