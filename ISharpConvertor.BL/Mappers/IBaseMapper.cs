using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISharpConvertor.BL.Mappers
{
    public interface IBaseMapper<TEntity, TUIModel>
    {
       TEntity ModelToEntity(TUIModel model);

      // List<TEntity> ModelToEntity(List<TUIModel> model);
    // List<TUIModel> EntityToModel(List<TEntity> model);
       TUIModel EntityToModel(TEntity model);

    }
}
