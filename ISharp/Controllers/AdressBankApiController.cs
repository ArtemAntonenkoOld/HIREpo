using ISharpConvertor.BL.BaseBindings;
using ISharpConvertor.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ISharpConvertor.WebUINew.Controllers
{
    public class AdressController : ApiController
    {
        
        public async Task<List<AddressModelForBanks>> Get(string city, string country){
            AddressForBankBinder binder = new AddressForBankBinder();
            var res = await binder.BindData(city, country);

            return res;
        }

        
    }
}
