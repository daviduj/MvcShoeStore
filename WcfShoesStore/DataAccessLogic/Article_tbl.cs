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
    public partial class Article_tbl
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public decimal Price { get; set; }

        public int TotalVault { get; set; }

        public int TotalShelf { get; set; }

        public int StoreId { get; set; }

        public virtual Store_tbl Store_tbl { get; set; }
    }
}
