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
    public class GraphBinderByDate
    {
        public List<GraphModel> BindData(DateTime startdate, DateTime enddate, string bank, string currency, string sellbuy)
        {
            RepositoryHolder holder = new RepositoryHolder();

            GraphMapper mapper = new GraphMapper();
            var rateRepository = holder.CurrencyRateRepository;
            List<GraphModel> resultData =
                rateRepository.
                    FetchBy(p => p.tbRate.cDate <= enddate &&
                        p.tbRate.cDate >= startdate && 
                        p.tbBank.cName == bank &&
                        p.tbCurrency.cCurrencyLong==currency&&
                        p.tbRate.SellBuy==sellbuy).
                    Select(p => mapper.EntityToUI(p)).ToList();

            return resultData;
        }
    }
}
