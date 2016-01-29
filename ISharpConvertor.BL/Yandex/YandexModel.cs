using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISharpConvertor.BL.Yandex
{
    class YandexModel
    {
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
            public List<string> coordinates { get; set; }
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
    }
}
