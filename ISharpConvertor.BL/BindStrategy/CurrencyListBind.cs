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
    public class CurrencyListBind
        {
            public List<CurrencyModel> BindFromEntities()
            {
                using (RepositoryHolder scope = new RepositoryHolder())
                {
                    CurrencyMapper mapper = new CurrencyMapper();

                    List<CurrencyModel> result = mapper.EntityToModel(
                        scope.CurrencyRepository
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


