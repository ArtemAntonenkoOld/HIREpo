using ISharpConvertor.Entity;
using ISharpConvertor.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISharpConvertor.BL.BaseMappers
{
    public class AddressMaper
    {
        public AddressModelForBanks EntityToUI(tbAdress address)
        {
            AddressModelForBanks addressUI = new AddressModelForBanks();
            //tbAddress
            addressUI.Address = address.cAdressVal;
            addressUI.Latitude = address.cLatitude;
            addressUI.Longitude = address.cLongitude;
            //tbBank
            addressUI.Name = address.tbBank.cName;
            
            return addressUI;
        }
    }
}
