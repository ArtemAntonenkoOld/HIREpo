using ISharpConvertor.Entity;
using ISharpConvertor.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISharpConvertor.BL.BaseMappers
{
    public class GraphMapper
    {
        public GraphModel EntityToUI(tbCurrencyRate graph)
        {
            GraphModel graphUI = new GraphModel();
            //tbAddress
            graphUI.Date = graph.tbRate.cDate;
            graphUI.Bank = graph.tbBank.cName;
            graphUI.Currency = graph.tbCurrency.cCurrencyLong;
            graphUI.Rate = graph.tbRate.cRate;

            return graphUI;
        }
    }
}
