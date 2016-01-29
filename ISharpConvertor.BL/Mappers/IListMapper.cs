using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISharpConvertor.BL.Mappers
{
    public interface IListMapper<TEntity, TUIModel> : IBaseMapper<TEntity, TUIModel>
    {

        //List<TUIModel> ModelToEntity(List<TEntity> model);
        List<TEntity> EntityToModel(List<TUIModel> model);
    }

}
