namespace libry
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbFromWho")]
    public partial class tbFromWho
    {
        public tbFromWho()
        {
            tbSystemComins = new HashSet<tbSystemComin>();
            tbUserComins = new HashSet<tbUserComin>();
        }

        [Required]
        [StringLength(1)]
        public string cName { get; set; }

        public int cUserId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cId { get; set; }

        public virtual tbUser tbUser { get; set; }

        public virtual ICollection<tbSystemComin> tbSystemComins { get; set; }

        public virtual ICollection<tbUserComin> tbUserComins { get; set; }
    }
}
