using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using ISharpConvertor.UIModels;
using ISharpConvertor.BL.BindStrategy;
using System.Web.Http;

namespace ISharpConvertor.WebUI.Controllers
{
    public class AdressController : ApiController
    {
        public IEnumerable<AdressModel> Get()
        {
            AdressListBind data = new AdressListBind();
            IEnumerable<AdressModel> result = data.BindFromEntities() as IEnumerable<AdressModel>;

            return (result);
        }
         public IEnumerable<AdressModel> Get(int id)
        {
            AdressListBindBy data = new AdressListBindBy();
            IEnumerable<AdressModel> result = data.BindFromEntitiesBy(id) as IEnumerable<AdressModel>;

            return (result);
        }
        
    }
}
