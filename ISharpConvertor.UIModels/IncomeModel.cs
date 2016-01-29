namespace ISharpConvertor.UIModels
{
    using System;
    using System.Collections.Generic;
    
    public  class IncomeModel
    {
        public int cId { get; set; }
        public System.DateTime cTime { get; set; }
        public decimal cSume { get; set; }
        public string cCurrency { get; set; }
        public int cIdUser { get; set; }
    
    }
}
