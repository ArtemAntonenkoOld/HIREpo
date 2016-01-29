
namespace ISharpConvertor.UIModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class RateModel
    {
       
        public int cId { get; set; }
        public Nullable<decimal> cRate { get; set; }
        public System.DateTime cDate { get; set; }
        public int cIsValid { get; set; }
   
            }
}
