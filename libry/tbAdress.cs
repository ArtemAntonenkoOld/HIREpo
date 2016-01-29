namespace libry
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbAdress")]
    public partial class tbAdress
    {
        public tbAdress()
        {
            tbComins = new HashSet<tbComin>();
            tbRssUsers = new HashSet<tbRssUser>();
        }

        [Key]
        public int cId { get; set; }

        [StringLength(100)]
        public string cAdressVal { get; set; }

        public int cIdBank { get; set; }

        [StringLength(100)]
        public string cStreet { get; set; }

        [StringLength(100)]
        public string cCity { get; set; }

        [StringLength(100)]
        public string cCountry { get; set; }

        [StringLength(70)]
        public string cLongitude { get; set; }

        [StringLength(70)]
        public string cLatitude { get; set; }

        public virtual tbBank tbBank { get; set; }

        public virtual ICollection<tbComin> tbComins { get; set; }

        public virtual ICollection<tbRssUser> tbRssUsers { get; set; }
    }
}
