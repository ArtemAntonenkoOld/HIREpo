using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ISharpConvertor.UIModels;
using ISharpConvertor.BL.BindStrategy;

namespace ISharpConvertor.WebUI.Controllers
{
    public class GetBankByCityController : ApiController
    {
        public List<AdressModel> Get(string city, string country)
        {
            GetBankByCity data = new GetBankByCity();
            List<AdressModel> result = data.BindFromEntities(city, country);

            return (result);
        }
    }
}
