using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISharpConvertor.UIModels;
using ISharpConvertor.DAL.Concrate;
using ISharpConvertor.BL.BaseMappers;

namespace ISharpConvertor.BL.BaseBindings
{
    public class OnlyBankBinder
    {
        public List<OnlyBankModel> BindData()
        {
            RepositoryHolder holder = new RepositoryHolder();

            OnlyBankMapper mapper = new OnlyBankMapper();
            var bankRepository = holder.BankRepository;
            List<OnlyBankModel> resultnewData =
                bankRepository.
                    Fetch().
                    Select(p => mapper.EntityToUI(p)).ToList();
            return resultnewData;
        }
      
    }

}
