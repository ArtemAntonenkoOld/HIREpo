using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISharpConvertor.Entity;
using ISharpConvertor.UIModels;
using ISharpConvertor.BL.BindStrategy;
using ISharpConvertor.BL.Mappers;
using ISharpConvertor.DAL.Concrate;
using System.Data.Entity;
using ISharpConvertor.WebUI.Managers;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;


namespace ISharpConvertor.WebUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        ISharpConvertorEntities db = new ISharpConvertorEntities();
        public ActionResult Index()
        {
            return View();
        }
        AllBanksManager service = new AllBanksManager();
        
        public async Task<ActionResult> Bank(int id)
        {
            return View("Bank", await service.GetBankAsyncById(id));
        }
        public async Task<ActionResult> _MapById(int id)
        {
            return PartialView( await service.GetAdressAsyncById(id));
        }
    }
}