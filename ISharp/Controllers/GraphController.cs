using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISharpConvertor.BL.BaseBindings;

namespace ISharpConvertor.WebUINew.Controllers
{
    public class GraphController : Controller
    {
        //
        // GET: /Graph/
        public ActionResult _GetGraph(DateTime startdate, DateTime enddate, string bank,string currency,string sellbuy)
        {
            GraphBinderByDate binder = new GraphBinderByDate();
            var res = binder.BindData(startdate, enddate, bank, currency, sellbuy);
            return PartialView(res);
        }
        public ActionResult _CurrencyList()
        {
            OnlyRateBinder binder = new OnlyRateBinder();
            var res = binder.BindData();
            return PartialView(res);
        }
        public ActionResult _BankList()
        {
            OnlyBankBinder binder = new OnlyBankBinder();
            var res = binder.BindData();
            return PartialView(res);
        }
        public ActionResult Graph()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

    }
}
