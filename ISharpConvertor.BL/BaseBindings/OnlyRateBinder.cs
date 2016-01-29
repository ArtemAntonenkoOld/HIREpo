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
    public class OnlyRateBinder
    {
        public List<OnlyRateModel> BindData()
        {
            RepositoryHolder holder = new RepositoryHolder();

            OnlyRateMapper mapper = new OnlyRateMapper();
            var rateRepository = holder.CurrencyRepository;
            List<OnlyRateModel> resultnewData =
                rateRepository.
                    Fetch().
                    Select(p => mapper.EntityToUI(p)).ToList();

            return resultnewData;
        }
    }
}
