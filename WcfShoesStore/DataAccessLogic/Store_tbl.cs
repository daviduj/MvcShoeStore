namespace WcfShoesStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [KnownType(typeof(Article_tbl))]
    [KnownType(typeof(Store_tbl))]
    public partial class Store_tbl
    {
        public Store_tbl()
        {
            Article_tbl = new HashSet<Article_tbl>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        public virtual ICollection<Article_tbl> Article_tbl { get; set; }
    }
}
