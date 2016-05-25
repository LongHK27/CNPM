namespace BookShop.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DATHANG")]
    public partial class DATHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DATHANG()
        {
            CHITIETDATHANGs = new HashSet<CHITIETDATHANG>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? SOLUONG { get; set; }

        [Required]
        [StringLength(50)]
        public string TENKH { get; set; }

        [StringLength(13)]
        public string SDTKH { get; set; }

        [StringLength(50)]
        public string DIACHIKH { get; set; }

        public DateTime? NGAYDAT { get; set; }

        public bool? ISDELETE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDATHANG> CHITIETDATHANGs { get; set; }
    }
}
