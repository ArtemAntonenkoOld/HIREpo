using ISharpConvertor.Entity;
using ISharpConvertor.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISharpConvertor.BL.BaseMappers
{
    public class OnlyBankMapper
    {
        public OnlyBankModel EntityToUI(tbBank bank)
        {
            OnlyBankModel bankUI = new OnlyBankModel();
            //tbCurrency
            bankUI.Name = bank.cName;
           bankUI.Id = bank.cId;
            return bankUI;
        }
    }
}
