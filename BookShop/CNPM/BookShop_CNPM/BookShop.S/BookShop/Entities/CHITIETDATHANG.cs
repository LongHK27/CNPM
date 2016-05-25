namespace BookShop.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETDATHANG")]
    public partial class CHITIETDATHANG
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_DH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string TENSACH { get; set; }

        public int? SOLUONG { get; set; }

        public bool? ISDELETE { get; set; }

        public virtual DATHANG DATHANG { get; set; }
    }
}
