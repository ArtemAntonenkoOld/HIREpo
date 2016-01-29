namespace libry
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbCurrencyRate")]
    public partial class tbCurrencyRate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cId { get; set; }

        public int cIdRate { get; set; }

        public int cIdCurrency { get; set; }

        public int cIdBank { get; set; }

        public virtual tbBank tbBank { get; set; }

        public virtual tbCurrency tbCurrency { get; set; }

        public virtual tbRate tbRate { get; set; }
    }
}
