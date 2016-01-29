using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISharpConvertor.Entity;
using ISharpConvertor.UIModels;
using ISharpConvertor.DAL.Concrate;
using System.Data.Entity;
using ISharpConvertor.WebUI.Managers;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using ISharpConvertor.BL.BaseBindings;

namespace ISharpConvertor.WebUI.Controllers
{
    public class FunctionsController : Controller
    {
        // GET: Functions
        AllBanksManager service = new AllBanksManager();

        public async Task<ActionResult> GetBankByCityMathod(string city,string country)
        {
            AddressForBankBinder binder = new AddressForBankBinder(); 
            var res = await binder.BindData(city, country);
            return View(res);
        }
        public async Task<ActionResult> Currency()
        {
            return View("Currency", await service.GetAllBankAsync());
        }
        public async Task<ActionResult> Popular()
        {
            return View("Popular",await service.GetAllBankAsync());
        }
        public async Task<ActionResult> Bank()
        {
            return View("Bank", await service.GetAllAdress());
        }
        public async Task<ActionResult> Optimal()
        {
            return View("Optimal", await service.GetAllAdress());
        }
        public async Task<ActionResult> _Chart(int id)
        {
            return PartialView(await service.GetBankAsyncById(id));
        }
        public ActionResult Graph()
        {
            return View("Graph");
        }
        public async Task<ActionResult> _Search(string city, string country)
        {
            return PartialView(await service.GetBankAsyncByCity(city,country));
        }
        public ActionResult SearchCity()
        {
            return View("SearchCity");
        }
    }
}