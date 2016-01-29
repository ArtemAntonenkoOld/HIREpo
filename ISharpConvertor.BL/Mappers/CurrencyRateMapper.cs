using ISharpConvertor.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISharpConvertor.Entity;
using ISharpConvertor.BL.Mappers;
using ISharpConvertor.BL.BindStrategy;

namespace ISharpConvertor.BL.Mappers
{
    public class CurrencyRateMapper : IListMapper<Entity.tbCurrencyRate, CurrencyRateModel>
    {


        public List<CurrencyRateModel> EntityToModel(List<tbCurrencyRate> model)
        {
            CurrencyMapper mapper = new CurrencyMapper();
            RateMapper mapper2 = new RateMapper();
            List<CurrencyRateModel> result = new List<CurrencyRateModel>();
            foreach (var item in model)
            {
                CurrencyRateModel p = new CurrencyRateModel()
                {

                    cId = item.cId,
                    
                  //  RateModel = mapper2.EntityToModel(item.tbRate),
                 //   CurrencyModel = mapper.EntityToModel(item.tbCurrency)
                    // CurrencyRateModel= model.tbCurrencyRate1
                };
                result.Add(p);
            }
            return result;
        }
        public CurrencyRateModel EntityToModel(tbCurrencyRate model)
        {


            CurrencyRateModel prod = new CurrencyRateModel()
            {
                cId = model.cId,
              
                //tbCurrencyRate1=model.CurrencyRateModel
            };

            return prod;

        }
        public tbCurrencyRate ModelToEntity(CurrencyRateModel model)
        {


            tbCurrencyRate prod = new tbCurrencyRate()
            {
                cId = model.cId,
                //cName = model.cName,
                //cRating = model.cRating,
                //tbCurrencyRate1=model.CurrencyRateModel

            };

            return prod;

        }
        public List<tbCurrencyRate> ModelToEntity(List<CurrencyModel> model)
        {
            RateMapper mapper = new RateMapper();
            CurrencyMapper mapper2 = new CurrencyMapper();
            List<tbCurrencyRate> result = new List<tbCurrencyRate>();
            foreach (var item in model)
            {
                tbCurrencyRate p = new tbCurrencyRate()
                {

                    cId = item.cId,
                    //tbRate = mapper.ModelToEntity(item.RateModel),
                   // tbCurrency = mapper2.ModelToEntity(item.Currency)
                    // CurrencyRateModel= model.tbCurrencyRate1
                };
                result.Add(p);
            }
            return result;
        }
        public List<tbCurrencyRate> EntityToModel(List<CurrencyRateModel> model)
        {
            throw new NotImplementedException();
        }
    }
}
