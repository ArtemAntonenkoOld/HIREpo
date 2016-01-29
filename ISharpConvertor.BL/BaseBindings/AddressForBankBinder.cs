using ISharpConvertor.BL.BaseMappers;
using ISharpConvertor.DAL.Concrate;
using ISharpConvertor.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using ISharpConvertor.BL.Yandex;

namespace ISharpConvertor.BL.BaseBindings
{
    public class AddressForBankBinder
    {

        public async Task<List<AddressModelForBanks>> BindData(string city, string country)
        {
            RepositoryHolder holder = new RepositoryHolder();

            AddressMaper mapper = new AddressMaper();
            var addressRepository = holder.AdressRepository;
            List<AddressModelForBanks> resultData =
                addressRepository.
                    FetchBy(p => p.cCity == city && p.cCountry == country).
                    Select(p => mapper.EntityToUI(p)).ToList();
            /*
            if (resultData == null || resultData.Count == 0)
            {
                string type = "Банк";
                var client = new RestClient("https://search-maps.yandex.ru/v1/?text=" + type + ", " + city + ", " + country + "&type=biz&lang=uk_Ua&apikey=f7f27aa0-8bf2-4d7d-9e80-fdab701a58c8&results=500");

                var request = new RestRequest("resource/", Method.GET);


                var data = await client.GetTaskAsync<YandexModel.RootObject>(request);

                for (int i = 0; i <= data.features.Count - 1; i++)
                {
                    string[] buf = data.features[i].properties.CompanyMetaData.address.Split(','); //разбиваем строку на массив слов, разделитель пробел

                    Char separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];
                    String Source = data.features[i].geometry.coordinates[0].Replace(',', separator);

                    String Source2 = data.features[i].geometry.coordinates[1].Replace(',', separator);

                    holder.AdressRepository.Insert(new Entity.tbAdress()
                    {
                        cLatitude = Source,
                        cLongitude = Source2,
                        cIdBank = 1,
                        cAdressVal = data.features[i].properties.CompanyMetaData.address,
                        cCity = city,
                        cCountry = country,
                        cStreet = buf[1] + buf[2]
                    });
                    holder.SaveChanges();
                }

               
                List<AddressModelForBanks> resultData2 =
               addressRepository.
                   FetchBy(p => p.cCity == city && p.cCountry == country).
                   Select(p => mapper.EntityToUI(p)).ToList();
                return resultData2;
            }else
            {*/
                return resultData;
          //  }
        }
        public async Task<List<AddressModelForBanks>> BindDataByBank(string city, string country, string bank)
        {
            RepositoryHolder holder = new RepositoryHolder();

            AddressMaper mapper = new AddressMaper();
            var addressRepository = holder.AdressRepository;
            List<AddressModelForBanks> resultData =
                addressRepository.
                    FetchBy(p => p.cCity == city && p.cCountry == country && p.tbBank.cName==bank).
                    Select(p => mapper.EntityToUI(p)).ToList();



            /*
            if (resultData == null || resultData.Count == 0)
            {
                string type = bank;
                var client = new RestClient("https://search-maps.yandex.ru/v1/?text=" + type + ", " + city + ", " + country + "&type=biz&lang=uk_Ua&apikey=f7f27aa0-8bf2-4d7d-9e80-fdab701a58c8&results=500");

                var request = new RestRequest("resource/", Method.GET);


                var data = await client.GetTaskAsync<YandexModel.RootObject>(request);

                for (int i = 0; i <= data.features.Count - 1; i++)
                {
                    string[] buf = data.features[i].properties.CompanyMetaData.address.Split(','); //разбиваем строку на массив слов, разделитель пробел

                    Char separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];
                    String Source = data.features[i].geometry.coordinates[0].Replace(',', separator);

                    String Source2 = data.features[i].geometry.coordinates[1].Replace(',', separator);

                    holder.AdressRepository.Insert(new Entity.tbAdress()
                    {
                        cLatitude = Source,
                        cLongitude = Source2,
                        cIdBank = 1,
                        cAdressVal = data.features[i].properties.CompanyMetaData.address,
                        cCity = city,
                        cCountry = country,
                        cStreet = buf[1] + buf[2]
                    });
                    holder.SaveChanges();
                }

                List<AddressModelForBanks> resultData2 =
               addressRepository.
                   FetchBy(p => p.cCity == city && p.cCountry == country).
                   Select(p => mapper.EntityToUI(p)).ToList();
                return resultData2;
            }else
            {*/
                return resultData;
           // }
        }
        public  List<AddressModelForBanks> BindDataAll()
        {
            RepositoryHolder holder = new RepositoryHolder();

            AddressMaper mapper = new AddressMaper();
            var addressRepository = holder.AdressRepository;
            List<AddressModelForBanks> resultData =
                addressRepository.
                    Fetch().
                    Select(p => mapper.EntityToUI(p)).ToList();
            
            return resultData;
            
        }
        public List<AddressModelForBanks> BindDataByBank(string bank, string country)
        {
            RepositoryHolder holder = new RepositoryHolder();

            AddressMaper mapper = new AddressMaper();
            var addressRepository = holder.AdressRepository;
            List<AddressModelForBanks> resultData =
                addressRepository.
                    FetchBy(p => p.tbBank.cName == bank && p.cCountry == country).
                    Select(p => mapper.EntityToUI(p)).ToList();
           
                return resultData;
       
        }
   
    }
}
