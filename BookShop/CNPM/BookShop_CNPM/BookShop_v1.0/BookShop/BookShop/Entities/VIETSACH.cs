namespace BookShop.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VIETSACH")]
    public partial class VIETSACH
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_SACH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_TACGIA { get; set; }

        public DateTime? NGAYVIET { get; set; }

        [StringLength(20)]
        public string VAITRO { get; set; }

        public bool? ISDELETE { get; set; }

        public virtual SACH SACH { get; set; }

        public virtual TACGIA TACGIA { get; set; }
    }
}
