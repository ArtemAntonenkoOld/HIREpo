using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISharpConvertor.BL.BaseBindings;

namespace ISharpConvertor.WebUINew.Controllers
{
    public class RateController : Controller
    {
        //
        // GET: /Rate/
        public ActionResult _GetRates(string currency)
        {
            RatesByValueBinder binder = new RatesByValueBinder();
            var res = binder.BindData(currency);
            return PartialView(res);
        }
        public ActionResult Rates()
        {
            OnlyRateBinder binder = new OnlyRateBinder();
            var res = binder.BindData();
            return View(res);
        }
        public ActionResult Index()
        {
            return View();
        }

    }
}
