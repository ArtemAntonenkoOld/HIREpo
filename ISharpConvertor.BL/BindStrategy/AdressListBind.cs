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
    public class AdressListBind
    {
        public List<AdressModel> BindFromEntities()
        {
            using (RepositoryHolder scope = new RepositoryHolder())
            {
                AdressMapper mapper = new AdressMapper();
                
                List<AdressModel> result =  //mapper.EntityToModel(
                    scope.AdressRepository
                    .Fetch()
                    .Select
                        (
                            p => 
                                mapper.EntityToModel(p)
                        )
                   .ToList();
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
