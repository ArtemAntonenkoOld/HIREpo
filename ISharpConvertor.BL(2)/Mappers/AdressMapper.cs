using ISharpConvertor.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISharpConvertor.Entity;

namespace ISharpConvertor.BL.Mappers
{
    public class AdressMapper : IBaseMapper<Entity.tbAdress, AdressModel>
    {
        public AdressModel EntityToModel(tbAdress model)
        {
            AdressModel p = new AdressModel()
            {
                cId = model.cId,
                cAdressVal = model.cAdressVal,
                cCity = model.cCity,
                cCountry = model.cCountry,
                cLatitude = model.cLatitude,
                cIdBank = model.cIdBank,
                cLongitude = model.cLongitude,
                cStreet = model.cStreet
            };
            return p;
        }

        public tbAdress ModelToEntity(AdressModel model)
        {


            tbAdress prod = new tbAdress()
            {
                cId = model.cId,
                cAdressVal = model.cAdressVal,
                cCity = model.cCity,
                cCountry = model.cCountry,
                cLatitude = model.cLatitude,
                cIdBank = model.cIdBank,
                cLongitude = model.cLongitude,
                cStreet = model.cStreet
            };

            return prod;

        }
    }
}
