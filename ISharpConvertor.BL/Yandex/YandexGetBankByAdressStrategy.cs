using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISharpConvertor.DAL.Abstract;
using ISharpConvertor.DAL.Concrate;
using ISharpConvertor.UIModels;
using RestSharp;

namespace ISharpConvertor.BL.Yandex
{
    public class YandexGetBankByAdressStrategy
    {
        public  void  GetData(string city, string country)
        {
            RepositoryHolder holder = new RepositoryHolder();
            string type = "Банк";
            var client = new RestClient("https://search-maps.yandex.ru/v1/?text=" + type + ", " + city + ", " + country + "&type=biz&lang=uk_Ua&apikey=f7f27aa0-8bf2-4d7d-9e80-fdab701a58c8&results=500");

            var request = new RestRequest("resource/", Method.GET);

            var asyncHandle = client.ExecuteAsync<YandexModel.RootObject>(request, response =>
            {


                for (int i = 0; i <= response.Data.features.Count - 1; i++)
                {
                    string[] buf = response.Data.features[i].properties.CompanyMetaData.address.Split(','); //разбиваем строку на массив слов, разделитель пробел

                    Char separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];
                    String Source = response.Data.features[i].geometry.coordinates[0].Replace(',', separator);
                    Double number = Convert.ToDouble(Source);
                    String Source2 = response.Data.features[i].geometry.coordinates[1].Replace(',', separator);
                    Double number2 = Convert.ToDouble(Source2);
                    holder.AdressRepository.Insert(new Entity.tbAdress()
                    {
                        cLatitude = Source,
                        cLongitude = Source2,
                        cIdBank = 1,
                        cAdressVal = response.Data.features[i].properties.CompanyMetaData.address,
                        cCity = city,
                        cCountry = country,
                        cStreet = buf[1] + buf[2]
                    });
                    holder.SaveChanges();
                }
            });
        }
    }
}
