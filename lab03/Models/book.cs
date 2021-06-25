namespace lab03.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("book")]
    public partial class book
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string tilte { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string descripstion { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string author { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string img { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int price { get; set; }
    }
}
