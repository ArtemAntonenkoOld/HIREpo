namespace libry
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbUserComin")]
    public partial class tbUserComin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cId { get; set; }

        public int cIdUser { get; set; }

        public int cFromWho { get; set; }

        public int cTopic { get; set; }

        [Required]
        [StringLength(1)]
        public string cDescription { get; set; }

        public virtual tbFromWho tbFromWho { get; set; }

        public virtual tbUser tbUser { get; set; }
    }
}
