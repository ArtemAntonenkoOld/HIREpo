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
    
    public partial class tbUser
    {
        public tbUser()
        {
            this.tbComins = new HashSet<tbComins>();
            this.tbExpodenture = new HashSet<tbExpodenture>();
            this.tbFromWho = new HashSet<tbFromWho>();
            this.tbIncome = new HashSet<tbIncome>();
            this.tbUserComin = new HashSet<tbUserComin>();
        }
    
        public int cId { get; set; }
        public string cName { get; set; }
    
        public virtual ICollection<tbComins> tbComins { get; set; }
        public virtual ICollection<tbExpodenture> tbExpodenture { get; set; }
        public virtual ICollection<tbFromWho> tbFromWho { get; set; }
        public virtual ICollection<tbIncome> tbIncome { get; set; }
        public virtual ICollection<tbUserComin> tbUserComin { get; set; }
    }
}
