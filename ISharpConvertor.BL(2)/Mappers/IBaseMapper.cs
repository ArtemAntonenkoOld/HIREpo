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
        TUIModel EntityToModel(TEntity model);

    }
}
