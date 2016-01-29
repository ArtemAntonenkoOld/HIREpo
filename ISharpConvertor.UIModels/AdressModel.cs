using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISharpConvertor.UIModels
{
    public class AdressModel
    {
        public int cId { get; set; }
        public string cAdressVal { get; set; }
        public int cIdBank { get; set; }
        public string cStreet { get; set; }
        public string cCity { get; set; }
        public string cCountry { get; set; }
        public string cLongitude { get; set; }
        public string cLatitude { get; set; }
        public List<BankModel> BankModel { get; set; }
    }
}
