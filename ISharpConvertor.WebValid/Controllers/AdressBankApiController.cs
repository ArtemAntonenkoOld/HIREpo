using ISharpConvertor.BL.BaseBindings;
using ISharpConvertor.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ISharpConvertor.WebValid.Controllers
{
    public class AdressController : ApiController
    {

        public IEnumerable<AddressModelForBanks> Get(string city, string country)
        {
            AddressForBankBinder binder = new AddressForBankBinder();
            var res = binder.BindData(city, country);
            return res;
        }

    }
}
