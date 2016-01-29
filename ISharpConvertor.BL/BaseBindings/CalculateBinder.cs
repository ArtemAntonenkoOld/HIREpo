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
    public class CalculateBinder
    {
        public List<CalculateModel> BindData(string currency1, string currency2,string sellbuy, string bank)
        {
            RepositoryHolder holder = new RepositoryHolder();

            CalculateMapper mapper = new CalculateMapper();
            var rateRepository = holder.CurrencyRateRepository;
            List<CalculateModel> resultData =
                rateRepository.
                    FetchBy(p =>
                        p.tbBank.cName==bank&&
                        p.tbRate.cIsValid==1&&
                        p.tbRate.SellBuy==sellbuy&&(
                        p.tbCurrency.cCurrencyLong==currency1||
                        p.tbCurrency.cCurrencyLong == currency2)).
                    Select(p => mapper.EntityToUI(p)).ToList();

            return resultData;
        }
    }
}
