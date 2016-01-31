using ISharpConvertor.Entity;
using ISharpConvertor.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISharpConvertor.BL.BaseMappers
{
    class BankByCityCountryMapper
    {
        public BankByCityCountryModel EntityToUI(tbAdress address)
        {
            BankByCityCountryModel addressUI = new BankByCityCountryModel();
            //tbCurrency
            addressUI.Name = address.tbBank.cName;
            addressUI.Rating = address.tbBank.cRating;
            //rate curr

            return addressUI;
        }
    }
}
