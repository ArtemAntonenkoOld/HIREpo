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
        public class RateListBind
        {
            public List<RateModel> BindFromEntities()
            {
                using (RepositoryHolder scope = new RepositoryHolder())
                {
                    RateMapper mapper = new RateMapper();

                    List<RateModel> result = mapper.EntityToModel(
                        scope.RateRepository
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


