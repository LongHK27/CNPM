namespace BookShop.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETPHIEUNHAP")]
    public partial class CHITIETPHIEUNHAP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_PN { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_SACH { get; set; }

        public int? SOLUONG { get; set; }

        public bool? ISDELETE { get; set; }

        public virtual PHIEUNHAP PHIEUNHAP { get; set; }

        public virtual SACH SACH { get; set; }
    }
}
