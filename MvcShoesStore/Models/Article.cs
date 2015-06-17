namespace WcfShoesStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;
    
    [DataContract]
    public partial class Article
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public int TotalVault { get; set; }

        [DataMember]
        public int TotalShelf { get; set; }

        [DataMember]
        public string StoreName { get; set; }
    }
}
