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
    public class BankMapper : IListMapper<Entity.tbBank, BankModel>
    {


        public List<BankModel> EntityToModel(List<tbBank> model)
        {
            CurrencyRateMapper mapper = new CurrencyRateMapper();
            AdressMapper mapper2 = new AdressMapper();
            
            List<BankModel> result = new List<BankModel>();
            foreach (var item in model)
            {
                BankModel p = new BankModel()
                {

                    cId = item.cId,
                    cName = item.cName,
                    cRating = item.cRating,
                    CurrencyRateModel = mapper.EntityToModel(item.tbCurrencyRate1.ToList()),
                    AdressModel = mapper2.EntityToModel(item.tbAdress.ToList())
                    // CurrencyRateModel= model.tbCurrencyRate1
                };
                result.Add(p);
            }
            return result;
        }
       public BankModel EntityToModel(tbBank model)
        {


            BankModel prod = new BankModel()
            {
                cId = model.cId,
                cName = model.cName,
                cRating = model.cRating,
                //tbCurrencyRate1=model.CurrencyRateModel
            };

            return prod;

        }       
        public tbBank ModelToEntity(BankModel model)
        {


            tbBank prod = new tbBank()
            {
                cId = model.cId,
                cName = model.cName,
                cRating = model.cRating,
                //tbCurrencyRate1=model.CurrencyRateModel

            };

            return prod;

        }
        public List<tbBank> ModelToEntity(List<BankModel> model)
        {
            //  CurrencyRateMapper mapper = new CurrencyRateMapper();
            AdressMapper mapper2 = new AdressMapper();
            List<tbBank> result = new List<tbBank>();
            foreach (var item in model)
            {
                tbBank p = new tbBank()
                {

                    cId = item.cId,
                    cName = item.cName,
                    cRating = item.cRating,
                    //   CurrencyRateModel = mapper.EntityToModel(model.tbCurrencyRate1),
                    
                    tbAdress = mapper2.ModelToEntity(item.AdressModel)
                    // CurrencyRateModel= model.tbCurrencyRate1
                };
                result.Add(p);
            }
            return result;
        }

        public List<tbBank> EntityToModel(List<BankModel> model)
        {
            throw new NotImplementedException();
        }
    }
}
