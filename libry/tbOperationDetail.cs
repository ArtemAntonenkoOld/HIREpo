namespace libry
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbOperationDetail
    {
        [Key]
        public int cId { get; set; }

        public int cType { get; set; }

        [Required]
        [StringLength(1)]
        public string cParams { get; set; }

        public int cIdOperation { get; set; }

        public virtual tbOperation tbOperation { get; set; }
    }
}
