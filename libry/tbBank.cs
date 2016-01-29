namespace libry
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbBank")]
    public partial class tbBank
    {
        public tbBank()
        {
            tbAdresses = new HashSet<tbAdress>();
            tbComins = new HashSet<tbComin>();
            tbCurrencyRates = new HashSet<tbCurrencyRate>();
        }

        [Key]
        public int cId { get; set; }

        [Required]
        [StringLength(81)]
        public string cName { get; set; }

        public int cRating { get; set; }

        public virtual ICollection<tbAdress> tbAdresses { get; set; }

        public virtual ICollection<tbComin> tbComins { get; set; }

        public virtual ICollection<tbCurrencyRate> tbCurrencyRates { get; set; }
    }
}
