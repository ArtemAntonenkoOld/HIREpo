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
    public class BankListBind
    {
        public List<BankModel> BindFromEntities()
        {
            using (RepositoryHolder scope = new RepositoryHolder())
            {
                BankMapper mapper = new BankMapper();
                
                List<BankModel> result =
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


        public void BindFromUIModel(BankModel model)
        {
            using (RepositoryHolder scope = new RepositoryHolder())
            {
                BankMapper mapper = new BankMapper();
                var dbModel = mapper.ModelToEntity(model);
                scope.BankRepository.Insert(dbModel);
                scope.SaveChanges();
            }
        }
    }

    }
