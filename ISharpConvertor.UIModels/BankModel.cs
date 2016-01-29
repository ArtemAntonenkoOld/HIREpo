using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISharpConvertor.UIModels
{
    public class BankModel
    {
        //public BankModel()
        //{
            //this.AdressModel = new HashSet<AdressModel>();
            //this.CominsModel = new HashSet<CominsModel>();
            //this.CurrencyRateModel = new HashSet<CurrencyRateModel>();
        //}

        public int cId { get; set; }
        public string cName { get; set; }
        public int cRating { get; set; }

        public List<AdressModel> AdressModel { get; set; }
        //public List<AdressModel> CominsModel { get; set; }
        public List<CurrencyRateModel> CurrencyRateModel { get; set; }
    }
}
