using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using ISharpConvertor.UIModels;

namespace ISharpConvertor.Consol
{
    class program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://search-maps.yandex.ru/v1/?text=Банк, Дніпропетровськ, Україна&type=biz&lang=uk_Ua&apikey=f7f27aa0-8bf2-4d7d-9e80-fdab701a58c8&results=500");

            var request = new RestRequest("resource/" , Method.GET);
            /*
            client.ExecuteAsync(request, response =>
            {
                Console.WriteLine(response.Content);
            });*/
            //type=банк банкомат;

            int k=0;
            
            RepositoryHolder holder = new RepositoryHolder();
            var asyncHandle = client.ExecuteAsync<RootObject>(request, response =>
            {
                        
                        
                        for (int i = 0; i <= response.Data.features.Count-1; i++)
                        {                    
                          string[] buf = response.Data.features[i].properties.CompanyMetaData.address.Split(','); //разбиваем строку на массив слов, разделитель пробел

                            Char separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];
                            String Source = response.Data.features[i].geometry.coordinates[0].Replace(',', separator);
                            Double number = Convert.ToDouble(Source);
                            String Source2 = response.Data.features[i].geometry.coordinates[1].Replace(',', separator);
                            Double number2 = Convert.ToDouble(Source2);
                            holder.AdressRepository.Insert( new Entity.tbAdress() {
                                cLatitude = Source,
                                cLongitude = Source2,
                                cIdBank=1,
                                cAdressVal = response.Data.features[i].properties.CompanyMetaData.address,
                                cCity=buf[0],
                                cCountry="Україна",
                                cStreet=buf[1]+buf[2]});
                            holder.SaveChanges();
                        }
                    
            });
         
            Console.Read();
        }
    }
    public class Element
    {

        public string Currency { get; set; }

        public string Buy { get; set; }

        public string Sale { get; set; }

        public string BuyDelta { get; set; }

        public string SaleDelta { get; set; }
    }
    public class Author
    {
        public string name { get; set; }
        public string uri { get; set; }
    }

    public class Yandex
    {
        public string id { get; set; }
        public Author author { get; set; }
    }

    public class Sources
    {
        public Yandex yandex { get; set; }
    }

    public class Attribution
    {
        public Sources Sources { get; set; }
    }

    public class SearchRequest
    {
        public string request { get; set; }
        public int results { get; set; }
        public int skip { get; set; }
        public List<List<double>> boundedBy { get; set; }
    }

    public class Point
    {
        public string type { get; set; }
        public List<double> coordinates { get; set; }
    }

    public class SearchResponse
    {
        public int found { get; set; }
        public Point Point { get; set; }
        public List<List<double>> boundedBy { get; set; }
        public string display { get; set; }
    }

    public class ResponseMetaData
    {
        public SearchRequest SearchRequest { get; set; }
        public SearchResponse SearchResponse { get; set; }
    }

    public class Properties
    {
        public Attribution Attribution { get; set; }
        public ResponseMetaData ResponseMetaData { get; set; }
    }

    public class Category
    {
        public string name { get; set; }
        public List<List<int>> nameHighlight { get; set; }
    }

    public class Chain
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Phone
    {
        public string type { get; set; }
        public string formatted { get; set; }
        public string country { get; set; }
        public string prefix { get; set; }
        public string number { get; set; }
    }

    public class Interval
    {
        public string from { get; set; }
        public string to { get; set; }
    }

    public class Availability
    {
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public List<Interval> Intervals { get; set; }
    }

    public class Hours
    {
        public List<Availability> Availabilities { get; set; }
        public string text { get; set; }
        public int tzOffset { get; set; }
    }

    public class Geo
    {
        public string precision { get; set; }
    }

    public class Value
    {
        public string id { get; set; }
        public string value { get; set; }
    }

    public class Feature2
    {
        public string id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public List<Value> values { get; set; }
        public bool? value { get; set; }
    }

    public class CompanyMetaData
    {
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string url { get; set; }
        public List<Category> Categories { get; set; }
        public List<Chain> Chains { get; set; }
        public List<Phone> Phones { get; set; }
        public Hours Hours { get; set; }
        public Geo Geo { get; set; }
        public List<Feature2> Features { get; set; }
    }

    public class Properties2
    {
        public string id { get; set; }
        public CompanyMetaData CompanyMetaData { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public List<List<double>> boundedBy { get; set; }
        public List<string> attributions { get; set; }
    }

    public class Geometry
    {
        public string type { get; set; }
        public List<string> coordinates { get; set; }
    }

    public class Feature
    {
        public string type { get; set; }
        public Properties2 properties { get; set; }
        public Geometry geometry { get; set; }
    }

    public class RootObject
    {
        public string type { get; set; }
        public Properties properties { get; set; }
        public List<Feature> features { get; set; }
    }
    public class RootObject2
    {
        public List<BankModel> models { get; set; }
    }
    

    }


