using ISharpConvertor.Entity;
using ISharpConvertor.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISharpConvertor.BL.BaseMappers
{
    public class CalculateMapper
    {
        public CalculateModel EntityToUI(tbCurrencyRate rate)
        {
            CalculateModel rateUI = new CalculateModel();
            //tbCurrency
            rateUI.Currency = rate.tbCurrency.cCurrencyLong;
            rateUI.Name = rate.tbBank.cName;
            rateUI.Rate = rate.tbRate.cRate;
            //rate curr

            return rateUI;
        }
    }
}
