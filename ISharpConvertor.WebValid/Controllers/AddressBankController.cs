using ISharpConvertor.BL.BaseBindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISharpConvertor.WebValid.Controllers
{
    public class AddressBankController : Controller
    {
        //
        // GET: /AddressBank/
        public ActionResult GetBankByCityMathod(string city, string country)
        {
            AddressForBankBinder binder = new AddressForBankBinder();
            var res = binder.BindData(city, country);
            return View(res);
        }
        public ActionResult Index()
        {
            return View();
        }

    }
}
