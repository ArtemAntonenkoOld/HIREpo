namespace libry
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbOperationComin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cId { get; set; }

        public int cIdOperation { get; set; }

        [Required]
        [StringLength(500)]
        public string cDescription { get; set; }

        public int cTopic { get; set; }

        public virtual tbOperation tbOperation { get; set; }
    }
}
