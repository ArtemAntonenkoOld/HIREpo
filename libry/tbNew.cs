namespace libry
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbNew
    {
        public tbNew()
        {
            tbRssUserNews = new HashSet<tbRssUserNew>();
            tbVideos = new HashSet<tbVideo>();
        }

        [Key]
        public int cId { get; set; }

        public int cTopic { get; set; }

        [StringLength(100)]
        public string cDescription { get; set; }

        public virtual ICollection<tbRssUserNew> tbRssUserNews { get; set; }

        public virtual ICollection<tbVideo> tbVideos { get; set; }
    }
}
