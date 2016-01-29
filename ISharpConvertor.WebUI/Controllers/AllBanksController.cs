using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ISharpConvertor.UIModels;
using ISharpConvertor.BL.BindStrategy;
using System.Data.Entity;


namespace ISharpConvertor.WebUI.Controllers
{
    public class AllBanksController : ApiController
    {
        public IEnumerable<BankModel> Get()
        /// <summary>
        /// 
        /// </summary>
        {
            BankListBind data = new BankListBind();
            IEnumerable<BankModel> result = data.BindFromEntities() as  IEnumerable<BankModel>;

            return (result);
        }
        public IEnumerable<BankModel> Get(int id)
        {
            BankListBindBy data = new BankListBindBy();
            IEnumerable<BankModel> result = data.BindFromEntitiesBy(id) as  IEnumerable<BankModel>;

            return (result);
        }
        /*public void Put(int id, [FromBody]string value)
        {
            BankMapper data = new BankMapper();
            IEnumerable<BankModel> result = data.BindFromUIModel() as  IEnumerable<BankModel>;

        }*/

    }
}
