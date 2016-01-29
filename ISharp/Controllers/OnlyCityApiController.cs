using ISharpConvertor.BL.BaseBindings;
using ISharpConvertor.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ISharp.Controllers
{
    public class OnlyCityApiController : ApiController
    {
        //
        // GET: /OnlyCityApi/
        public List<OnlyCityModel> Get(string country)
        {
            OnlyCityBinder binder = new OnlyCityBinder();
            var res = binder.BindData(country);
            
            return res;
        }
    }
}
