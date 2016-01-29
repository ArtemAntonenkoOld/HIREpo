using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ISharpConvertor.BL.BindStrategy;
using ISharpConvertor.UIModels;


namespace ISharpConvertor.WebUI.Controllers
{
    public class ValuesController : ApiController
    {
        public IEnumerable<BankModel> Get(string name)
        {
            BankListBindById data = new BankListBindById();
            IEnumerable<BankModel> result = data.BindFromEntitiesBy(name) as IEnumerable<BankModel>;

            return (result);
        }
    }
}
