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
    public class TestController : Controller
    {
        // GET: Test
        AllBanksManager service = new AllBanksManager();
        public  async Task<ActionResult> TestView(int id)
        {


            return PartialView(await service.GetBankAsyncById(id));
        
        }
        public async Task<ActionResult> TestChart(int id)
        {


            return PartialView(await service.GetBankAsyncById(id));

        }
        public ActionResult Index()
        {


            return View();

        }
    }
}