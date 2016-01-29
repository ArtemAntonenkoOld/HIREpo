namespace libry
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbRssUserNew
    {
        [Key]
        public int cId { get; set; }

        public int cIdUser { get; set; }

        public int cIdNews { get; set; }

        public virtual tbNew tbNew { get; set; }

        public virtual tbRssUser tbRssUser { get; set; }
    }
}
