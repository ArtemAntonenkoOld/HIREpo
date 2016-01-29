using ISharpConvertor.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISharpConvertor.Entity;

namespace ISharpConvertor.BL.Mappers
{
    public class BankMapper : IBaseMapper<Entity.tbBank, BankModel>
    {
        public BankModel EntityToModel(tbBank model)
        {
            BankModel p = new BankModel()
            {
                cId = model.cId,
                cName = model.cName,
                cRating = model.cRating
            };
            return p;
        }

        public BankModel ModelToEntity(BankModel model)
        {


            tbBank bank = new tbBank()
            {
                cId = model.cId,
                cName = model.cName,
                cRating = model.cRating
            };

            return bank;

        }
    }
}
