using ISharpConvertor.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISharpConvertor.Entity;

namespace ISharpConvertor.BL.Mappers
{
    public class CurrencyMapper : IListMapper<Entity.tbCurrency, CurrencyModel>
    {
        public List<CurrencyModel> EntityToModel(List<tbCurrency> model)
        {

            List<CurrencyModel> result = new List<CurrencyModel>();
            foreach (var item in model)
            {
                CurrencyModel p = new CurrencyModel()
                {
                    cId = item.cId,
                    cCurrencyLong =item.cCurrencyLong,
                    cCurrencyShort=item.cCurrencyShort
                    // BankModel=mapper2.EntityToModel(item.tbBank)
                };
                result.Add(p);
            }
            return result;
        }
        public List<tbCurrency> ModelToEntity(List<CurrencyModel> model)
        {
            
            List<tbCurrency> result = new List<tbCurrency>();
            foreach (var item in model)
            {
                tbCurrency p = new tbCurrency()
                {
                    cId = item.cId,
                    cCurrencyShort=item.cCurrencyShort,
                    cCurrencyLong=item.cCurrencyLong
                    
                };
                result.Add(p);
            }
            return result;
        }
        public CurrencyModel EntityToModel(tbCurrency model)
        {


            CurrencyModel p = new CurrencyModel()
            {
                cId = model.cId,
                cCurrencyLong=model.cCurrencyLong,
                cCurrencyShort=model.cCurrencyShort
                
            };

            return p;

        }
        public tbCurrency ModelToEntity(CurrencyModel model)
        {


            tbCurrency prod = new tbCurrency()
            {
                cId = model.cId,
                cCurrencyLong = model.cCurrencyLong,
                cCurrencyShort=model.cCurrencyShort
            };

            return prod;

        }
        public List<tbCurrency> EntityToModel(List<CurrencyModel> model)
        {
            throw new NotImplementedException();
        }
    }
}
