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
        public ClosestPointModel EntityToUI(tbAdress adress, double latitude, double longitude)
        {
            ClosestPointModel adressUI = new ClosestPointModel();
            //tbCurrency
            adressUI.Address = adress.cAdressVal;
            
            adressUI.Longitude = adress.cLongitude;
            adressUI.Latitude = adress.cLatitude;
            adressUI.Name = adress.tbBank.cName;
            adressUI.FakeLatitude = Math.Abs( Convert.ToDouble(adress.cLatitude) - latitude);
            adressUI.FakeLongitude = Math.Abs(Convert.ToDouble(adress.cLongitude) - longitude);
            //rate curr
            
            return adressUI;
        }
    }
}
