namespace libry
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbCurrency")]
    public partial class tbCurrency
    {
        public tbCurrency()
        {
            tbCurrencyRates = new HashSet<tbCurrencyRate>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cId { get; set; }

        [StringLength(500)]
        public string cCurrencyLong { get; set; }

        [StringLength(100)]
        public string cCurrencyShort { get; set; }

        public virtual ICollection<tbCurrencyRate> tbCurrencyRates { get; set; }
    }
}
