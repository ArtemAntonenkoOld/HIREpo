using ISharpConvertor.Entity;
using ISharpConvertor.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISharpConvertor.BL.BaseMappers
{
    public class RatesMapper
    {
        public RateByValidModel EntityToUI(tbCurrencyRate rate)
        {
            RateByValidModel rateUI = new RateByValidModel();
            //tbCurrency
            rateUI.Currency = rate.tbCurrency.cCurrencyLong.ToString();
            //tbRate
            rateUI.Valid = rate.tbRate.cIsValid;
            rateUI.Rate = rate.tbRate.cRate;
            rateUI.Date = rate.tbRate.cDate;
            rateUI.Name = rate.tbBank.cName;
            rateUI.Rating = rate.tbBank.cRating;
            rateUI.IdBank = rate.tbBank.cId;
            return rateUI;
        }
    }
}
