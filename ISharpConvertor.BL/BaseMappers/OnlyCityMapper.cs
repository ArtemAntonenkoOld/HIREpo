using ISharpConvertor.Entity;
using ISharpConvertor.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISharpConvertor.BL.BaseMappers
{
    public class OnlyCityMapper
    {
        public OnlyCityModel EntityToUI(tbAdress city)
        {
            OnlyCityModel cityUI = new OnlyCityModel();
            //tbCurrency
            cityUI.Bank = city.tbBank.cName;
            cityUI.City = city.cCity;
            return cityUI;
        }
    }
}
