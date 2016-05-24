namespace BookShop.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SACH")]
    public partial class SACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SACH()
        {
            CHITIETHOADONs = new HashSet<CHITIETHOADON>();
            CHITIETKMs = new HashSet<CHITIETKM>();
            CHITIETPHIEUNHAPs = new HashSet<CHITIETPHIEUNHAP>();
            VIETSACHes = new HashSet<VIETSACH>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string TEN { get; set; }

        public int? GIABAN { get; set; }

        public int? GIANHAP { get; set; }

        public string MOTA { get; set; }

        public int? ID_CHUDE { get; set; }

        public int? ID_NXB { get; set; }

        public string BIA { get; set; }

        public int? SOLUONG { get; set; }

        [StringLength(50)]
        public string KHO { get; set; }

        public int? SOTRANG { get; set; }

        public bool? ISDELETE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETKM> CHITIETKMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHIEUNHAP> CHITIETPHIEUNHAPs { get; set; }

        public virtual CHUDE CHUDE { get; set; }

        public virtual NHAXUATBAN NHAXUATBAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VIETSACH> VIETSACHes { get; set; }
    }
}
