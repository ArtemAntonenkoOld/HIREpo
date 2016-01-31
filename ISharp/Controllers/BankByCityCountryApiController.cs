using ISharpConvertor.BL.BaseBindings;
using ISharpConvertor.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
namespace ISharp.Controllers
{
    public class BankByCityCountryApiController : ApiController
    {
        public List<BankByCityCountryModel> Get(string country,string city )
        {
            BankByCityCountryBinder binder = new BankByCityCountryBinder();
            var res = binder.BindData(country,city);

            return res;

        }
    }
}
