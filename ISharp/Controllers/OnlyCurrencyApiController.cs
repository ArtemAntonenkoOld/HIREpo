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
    public class OnlyCurrencyApiController : ApiController
    {
        public List<OnlyRateModel> Get()
        {
            OnlyRateBinder binder = new OnlyRateBinder();
            var res = binder.BindData();

            return res;
        }
    }
}
