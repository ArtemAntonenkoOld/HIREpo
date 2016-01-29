using ISharpConvertor.BL.BaseBindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ISharpConvertor.WebUINew.Controllers
{
    public class AddressBankController : Controller
    {
        //
        // GET: /AddressBank/
        public async Task<ActionResult> _GetBankByCityMathod(string city, string country, string bank)
        {
            AddressForBankBinder binder = new AddressForBankBinder();
           // if(bank==null){
                var res = await binder.BindData(city, country);
                return PartialView(res);
           /* }else{
                string banks = bank;
                 var res = await binder.BindDataByBank(city, country,banks);
                 return PartialView(res);
            }*/
            
        }
        public ActionResult SearchBank()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

    }
}
