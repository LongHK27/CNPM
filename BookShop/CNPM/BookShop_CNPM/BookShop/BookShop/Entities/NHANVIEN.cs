namespace BookShop.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            HOADONs = new HashSet<HOADON>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string TEN { get; set; }

        public DateTime? NGAYSINH { get; set; }

        [StringLength(13)]
        public string SDT { get; set; }

        [StringLength(20)]
        public string TENDANGNHAP { get; set; }

        [StringLength(10)]
        public string MATKHAU { get; set; }

        public int? ID_QUYEN { get; set; }

        public bool? ISDELETE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }

        public virtual PHANQUYEN PHANQUYEN { get; set; }
    }
}
