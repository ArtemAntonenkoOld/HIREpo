using ISharpConvertor.Entity;
using ISharpConvertor.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISharpConvertor.BL.BaseMappers
{
    public class OnlyRateMapper
    {
        public OnlyRateModel EntityToUI(tbCurrency rate)
        {
            OnlyRateModel rateUI = new OnlyRateModel();
            //tbCurrency
            rateUI.Currency = rate.cCurrencyLong;
            
            return rateUI;
        }
    }
}
