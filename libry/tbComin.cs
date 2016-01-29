namespace libry
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbComin
    {
        [Key]
        public int cId { get; set; }

        public int cTopic { get; set; }

        [StringLength(400)]
        public string cDecription { get; set; }

        public int cIdUser { get; set; }

        public int cIdBank { get; set; }

        public int? cIdAdress { get; set; }

        public virtual tbAdress tbAdress { get; set; }

        public virtual tbBank tbBank { get; set; }

        public virtual tbUser tbUser { get; set; }
    }
}
