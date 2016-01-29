using ISharpConvertor.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISharpConvertor.Entity;

namespace ISharpConvertor.BL.Mappers
{
    public class RateMapper : IListMapper<Entity.tbRate, RateModel>
    {
        public List<RateModel> EntityToModel(List<tbRate> model)
        {

            List<RateModel> result = new List<RateModel>();
            foreach (var item in model)
            {
                RateModel p = new RateModel()
                {
                    cId = item.cId,
                    cRate=item.cRate,
                    cDate =item.cDate
                    // BankModel=mapper2.EntityToModel(item.tbBank)
                };
                result.Add(p);
            }
            return result;
        }

        public List<tbRate> ModelToEntity(List<RateModel> model)
        {

            List<tbRate> result = new List<tbRate>();
            foreach (var item in model)
            {
                tbRate p = new tbRate()
                {
                    cId = item.cId,
                    cRate = item.cRate,
                    cDate = item.cDate

                };
                result.Add(p);
            }
            return result;
        }
        public RateModel EntityToModel(tbRate model)
        {


            RateModel p = new RateModel()
            {
                cId = model.cId,
                cDate=model.cDate,
                cRate=model.cRate

            };

            return p;

        }
        public tbRate ModelToEntity(RateModel model)
        {


            tbRate prod = new tbRate()
            {
                cId = model.cId,
                cRate = model.cRate,
                cDate = model.cDate
            };

            return prod;

        }
        public List<tbRate> EntityToModel(List<RateModel> model)
        {
            throw new NotImplementedException();
        }
    }
}
