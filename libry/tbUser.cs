namespace libry
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbUser")]
    public partial class tbUser
    {
        public tbUser()
        {
            tbComins = new HashSet<tbComin>();
            tbExpodentures = new HashSet<tbExpodenture>();
            tbFromWhoes = new HashSet<tbFromWho>();
            tbIncomes = new HashSet<tbIncome>();
            tbUserComins = new HashSet<tbUserComin>();
        }

        [Key]
        public int cId { get; set; }

        [StringLength(50)]
        public string cName { get; set; }

        public virtual ICollection<tbComin> tbComins { get; set; }

        public virtual ICollection<tbExpodenture> tbExpodentures { get; set; }

        public virtual ICollection<tbFromWho> tbFromWhoes { get; set; }

        public virtual ICollection<tbIncome> tbIncomes { get; set; }

        public virtual ICollection<tbUserComin> tbUserComins { get; set; }
    }
}
