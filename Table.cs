namespace UAS_PBO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Table")]
    public partial class Table
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nama { get; set; }

        [Required]
        [StringLength(20)]
        public string Usia { get; set; }

        [Required]
        [StringLength(200)]
        public string Analisis { get; set; }
    }
}
