using ISharpConvertor.BL.Mappers;
using ISharpConvertor.DAL.Concrate;
using ISharpConvertor.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISharpConvertor.BL.BindStrategy
{
    public class CurrencyRateListBind
    {
        public List<CurrencyRateModel> BindFromEntities()
        {
            using (RepositoryHolder scope = new RepositoryHolder())
            {
                CurrencyRateMapper mapper = new CurrencyRateMapper();

                List<CurrencyRateModel> result = mapper.EntityToModel(
                    scope.CurrencyRateRepository
                    .Fetch()
                           
                   .ToList());

                   
                return result;
            }

        }


        public void BindFromUIModel(CurrencyRateModel model)
        {
            using (RepositoryHolder scope = new RepositoryHolder())
            {
                CurrencyRateMapper mapper = new CurrencyRateMapper();
                var dbModel = mapper.ModelToEntity(model);
                scope.CurrencyRateRepository.Insert(dbModel);
                scope.SaveChanges();
            }
        }
    }
}
