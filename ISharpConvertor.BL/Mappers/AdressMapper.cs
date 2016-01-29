using ISharpConvertor.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISharpConvertor.Entity;

namespace ISharpConvertor.BL.Mappers
{
    public class AdressMapper : IListMapper<Entity.tbAdress, AdressModel>
    {
        public List<AdressModel> EntityToModel(List<tbAdress> model)
        {
            AdressMapper mapper = new AdressMapper();
            BankMapper mapper2 = new BankMapper();
            List<AdressModel> result = new List<AdressModel>();
            foreach (var item in model)
            {
                AdressModel p = new AdressModel()
                {
                    cId = item.cId,
                    cAdressVal = item.cAdressVal,
                    cCity = item.cCity,
                    cCountry = item.cCountry,
                    cLatitude = item.cLatitude,
                    cIdBank = item.cIdBank,
                    cLongitude = item.cLongitude,
                    cStreet = item.cStreet,
                   // BankModel=mapper2.EntityToModel(item.tbBank)
                };
                result.Add(p);
            }
            return result;
        }
        public List<tbAdress> ModelToEntity(List<AdressModel> model)
        {
            BankMapper mapper2 = new BankMapper();

            AdressMapper mapper = new AdressMapper();

            List<tbAdress> result = new List<tbAdress>();
            foreach (var item in model)
            {
                tbAdress p = new tbAdress()
                {
                    cId = item.cId,
                    cAdressVal = item.cAdressVal,
                    cCity = item.cCity,
                    cCountry = item.cCountry,
                    cLatitude = item.cLatitude,
                    cIdBank = item.cIdBank,
                    cLongitude = item.cLongitude,
                    //tbBank=mapper2.EntityToModel(item.BankModel),
                    cStreet = item.cStreet

                };
                result.Add(p);
            }
            return result;
        }
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
        public List<tbAdress> EntityToModel(List<AdressModel> model)
        {
            throw new NotImplementedException();
        }
    }
}
