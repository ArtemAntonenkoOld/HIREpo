using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISharpConvertor.DAL.Abstract;
using System.Threading.Tasks;

namespace ISharpConvertor.DAL.Concrate
{
    public class RateRepository : GenericRepository<Entity.tbRate>, IRateRepository
    {
        public RateRepository(Entity.ISharpConvertorEntities context)
            : base(context)
        {

        }
    }
}
