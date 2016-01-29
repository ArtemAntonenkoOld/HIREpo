namespace libry
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbRate")]
    public partial class tbRate
    {
        public tbRate()
        {
            tbCurrencyRates = new HashSet<tbCurrencyRate>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cId { get; set; }

        public decimal? cRate { get; set; }

        public DateTime cDate { get; set; }

        public int cIsValid { get; set; }

        public virtual ICollection<tbCurrencyRate> tbCurrencyRates { get; set; }
    }
}
