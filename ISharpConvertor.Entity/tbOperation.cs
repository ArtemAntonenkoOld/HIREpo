//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISharpConvertor.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbOperation
    {
        public tbOperation()
        {
            this.tbOperationDetails = new HashSet<tbOperationDetails>();
            this.tbOperationComins = new HashSet<tbOperationComins>();
        }
    
        public int cId { get; set; }
        public int cOperationType { get; set; }
        public int cIsFinished { get; set; }
    
        public virtual ICollection<tbOperationDetails> tbOperationDetails { get; set; }
        public virtual ICollection<tbOperationComins> tbOperationComins { get; set; }
    }
}