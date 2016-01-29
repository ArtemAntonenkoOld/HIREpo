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
    public class AdressListBindBy
    {
        public List<AdressModel> BindFromEntitiesBy(int id)
        {

            using (RepositoryHolder scope = new RepositoryHolder())
            {
                AdressMapper mapper = new AdressMapper();
                //CurrencyRateMapper mapper2 = new CurrencyRateMapper();   
                List<AdressModel> result = mapper.EntityToModel(
                    scope.AdressRepository
                    .FetchBy(p => p.cIdBank == id)
                   .ToList());
                return result;
            }

        }


        public void BindFromUIModel(AdressModel model)
        {
            using (RepositoryHolder scope = new RepositoryHolder())
            {
                AdressMapper mapper = new AdressMapper();
                var dbModel = mapper.ModelToEntity(model);
                scope.AdressRepository.Insert(dbModel);
                scope.SaveChanges();
            }
        }
    }

}
