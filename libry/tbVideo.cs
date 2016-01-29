namespace libry
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbVideo
    {
        [Key]
        public int cId { get; set; }

        [Required]
        [StringLength(100)]
        public string cSource { get; set; }

        public int cIdNews { get; set; }

        public virtual tbNew tbNew { get; set; }
    }
}
