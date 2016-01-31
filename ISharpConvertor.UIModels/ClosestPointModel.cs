using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISharpConvertor.UIModels
{
    public class ClosestPointModel
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Rate {get;set;}
        public string Currency { get; set; }
        public double FakeLongitude { get; set; }
        public double FakeLatitude { get; set; }
    }
}
