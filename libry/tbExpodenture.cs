namespace libry
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbExpodenture")]
    public partial class tbExpodenture
    {
        [Key]
        public int cId { get; set; }

        public DateTime cTime { get; set; }

        public decimal cSume { get; set; }

        [StringLength(30)]
        public string cCurrency { get; set; }

        public int cIdUser { get; set; }

        public virtual tbUser tbUser { get; set; }
    }
}
