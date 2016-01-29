using ISharpConvertor.Entity;
using ISharpConvertor.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISharpConvertor.BL.BaseMappers
{
    public class ClosestPointMapper
    {
        public ClosestPointModel EntityToUI(tbAdress adress)
        {
            ClosestPointModel adressUI = new ClosestPointModel();
            //tbCurrency
            adressUI.Adress = adress.cAdressVal;
            adressUI.Latitude = Convert.ToDouble(adress.cLatitude);
            adressUI.Longitude = Convert.ToDouble(adress.cLongitude);
            adressUI.Name = adress.tbBank.cName;
            //rate curr
            
            return adressUI;
        }
    }
}
