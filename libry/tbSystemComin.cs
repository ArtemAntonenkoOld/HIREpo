namespace libry
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbSystemComin")]
    public partial class tbSystemComin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cId { get; set; }

        public int cFromWho { get; set; }

        public int cTopic { get; set; }

        public virtual tbFromWho tbFromWho { get; set; }
    }
}
