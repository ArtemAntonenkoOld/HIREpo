using ISharpConvertor.BL.BaseMappers;
using ISharpConvertor.DAL.Concrate;
using ISharpConvertor.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISharpConvertor.BL.BaseBindings
{
    public class BankByCityCountryBinder
    {
        public List<BankByCityCountryModel> BindData(string country, string city)
        {
            RepositoryHolder holder = new RepositoryHolder();

            BankByCityCountryMapper mapper = new BankByCityCountryMapper();
            var bankRepository = holder.AdressRepository;
            List<BankByCityCountryModel> resultnewData =
                bankRepository.
                    FetchBy(p => p.cCountry == country && p.cCity == city)
                    .Select(p => mapper.EntityToUI(p))
                    .Distinct()
                    .OrderByDescending(z =>z.Rating )
                    .Reverse()
                    .ToList() ;
            return resultnewData;
        }
    }
}
