using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISharpConvertor.UIModels
{
    public class CurrencyRateModel
    {
        public int cId { get; set; }
        public int cIdRate { get; set; }
        public int cIdCurrency { get; set; }
        public int cIdBank { get; set; }

        public List<CurrencyModel> CurrencyModel { get; set; }
        public List<RateModel> RateModel { get; set; }
    }
}
