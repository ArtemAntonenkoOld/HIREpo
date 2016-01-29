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
    public class RatesByValueBinder
    {
        public List<RateByValidModel> BindData(string currency)
        {
            RepositoryHolder holder = new RepositoryHolder();

            RatesMapper mapper = new RatesMapper();
            var rateRepository = holder.CurrencyRateRepository;
            List<RateByValidModel> resultnewData =
                rateRepository.
                    FetchBy(p=>p.tbRate.cIsValid==1&&p.tbCurrency.cCurrencyLong==currency).
                    Select(p => mapper.EntityToUI(p)).
                    OrderByDescending(z => z.Rate)
                    .Reverse()
                    .ToList();
            
            return resultnewData;
        }
    }
}
