namespace BookShop.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETHOADON")]
    public partial class CHITIETHOADON
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_HD { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_SACH { get; set; }

        public int? SOLUONG { get; set; }

        public int? GIA { get; set; }

        public int? PTKM { get; set; }

        public bool? ISDELETE { get; set; }

        public virtual HOADON HOADON { get; set; }

        public virtual SACH SACH { get; set; }
    }
}
