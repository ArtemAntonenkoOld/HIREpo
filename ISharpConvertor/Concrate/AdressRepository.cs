using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISharpConvertor.DAL.Abstract;


namespace ISharpConvertor.DAL.Concrate
{
    public class AdressRepository:GenericRepository<Entity.tbAdress>,IAdressRepository

    {
         public AdressRepository(Entity.ISharpConvertorEntities context)
            : base(context)
        {

        }
    }
}
