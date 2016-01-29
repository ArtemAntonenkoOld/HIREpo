using ISharpConvertor.BL.Mappers;
using ISharpConvertor.DAL.Concrate;
using ISharpConvertor.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISharpConvertor.BL.Yandex;
namespace ISharpConvertor.BL.BindStrategy
{
    public class GetBankByCity
    {
        public List<AdressModel> BindFromEntities(string city, string country)
        {
            using (RepositoryHolder scope = new RepositoryHolder())
            {
                AdressMapper mapper = new AdressMapper();

                List<AdressModel> result = mapper.EntityToModel(
                    scope.AdressRepository
                    .FetchBy(p =>p.cCity==city)

                   .ToList());
                /*
                if (result == null)
                {
                    return GetData(city, country);
                }
                else
                {
                    return result;
                }*/
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
