namespace libry
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbRssUser")]
    public partial class tbRssUser
    {
        public tbRssUser()
        {
            tbRssUserNews = new HashSet<tbRssUserNew>();
        }

        [Key]
        public int cId { get; set; }

        public int? cMail { get; set; }

        public virtual tbAdress tbAdress { get; set; }

        public virtual ICollection<tbRssUserNew> tbRssUserNews { get; set; }
    }
}
