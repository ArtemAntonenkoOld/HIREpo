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
    public class ClosestPointBinder
    {
        public async Task<List<ClosestPointModel>> BindData(string adress)
        {
           
            var client = new RestClient("https://geocode-maps.yandex.ru/1.x/?format=json&lang=uk_Ua&geocode="+adress);

            var request = new RestRequest("resource/", Method.GET);
            
            var data = await client.GetTaskAsync<GeocodeModel.RootObject>(request);

            var latitude = data.response.GeoObjectCollection.featureMember[0].GeoObject.Point.pos[0];
            var longitude = data.response.GeoObjectCollection.featureMember[0].GeoObject.Point.pos[1];
            
            RepositoryHolder holder = new RepositoryHolder();

            ClosestPointMapper mapper = new ClosestPointMapper();
            var adressRepository = holder.AdressRepository;
           List<ClosestPointModel> resultData =
                adressRepository.
                    Fetch().
                    Select(p => mapper.EntityToUI(p, latitude, longitude)).OrderBy(z => z.FakeLatitude).ThenBy(z => z.FakeLongitude).Take(20).ToList();

           
            return resultData;
        }
    }
}
