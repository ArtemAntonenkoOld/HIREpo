namespace libry
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbOperation")]
    public partial class tbOperation
    {
        public tbOperation()
        {
            tbOperationDetails = new HashSet<tbOperationDetail>();
            tbOperationComins = new HashSet<tbOperationComin>();
        }

        [Key]
        public int cId { get; set; }

        public int cOperationType { get; set; }

        public int cIsFinished { get; set; }

        public virtual ICollection<tbOperationDetail> tbOperationDetails { get; set; }

        public virtual ICollection<tbOperationComin> tbOperationComins { get; set; }
    }
}
