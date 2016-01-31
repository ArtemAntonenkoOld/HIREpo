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
           /* if(bank==null){
                var res = await binder.BindData(city, country);
                return PartialView(res);
            }else{*/
                string banks = bank;
                 var res = await binder.BindDataByBank(city, country,bank);
                 return PartialView(res);
            }
            
        
        public ActionResult SearchBank()
        {
            OnlyBankBinder binder = new OnlyBankBinder();
            var res = binder.BindData();
            return PartialView(res);
        } 
        public ActionResult SearchAllBanksByCity()
        {
            return PartialView();
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
        public ActionResult _CityList(string country )
        {
            OnlyCityBinder binder = new OnlyCityBinder();
            var res = binder.BindData(country);
            return PartialView(res);
        }
        public ActionResult SearchAllBanksByBank()
        {
            OnlyBankBinder binder = new OnlyBankBinder();
            var res = binder.BindData();
            return PartialView(res);
        }
        public  ActionResult _GetAllBanksByBankMathod(string bank, string country)
        {
            AddressForBankBinder binder = new AddressForBankBinder();
            var res = binder.BindDataByBank(bank, country);
            return PartialView(res);
        }
    
        public ActionResult _GetAllBanksMathod()
        {
            AddressForBankBinder binder = new AddressForBankBinder();
            var res = binder.BindDataAll();
            return PartialView(res);
        }
        public ActionResult SearchOptimalBankByCityCurrency()
        {
            return PartialView();
        }
        public ActionResult SearchOptimalByClosestPoint()
        {
            return PartialView();
        }
        //_GetOptimalByDistanceMathod
        public async Task<ActionResult> _GetOptimalBankByClosestPoint(string search)
        {
            ClosestPointBinder binder = new ClosestPointBinder();
            var res = await binder.BindData(search);
            return PartialView(res);
        }
    
        public ActionResult Index()
        {
            return View();
        }

        
    }
}
