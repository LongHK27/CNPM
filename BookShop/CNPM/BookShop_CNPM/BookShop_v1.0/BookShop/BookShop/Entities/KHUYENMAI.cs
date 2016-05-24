namespace BookShop.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHUYENMAI")]
    public partial class KHUYENMAI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHUYENMAI()
        {
            CHITIETKMs = new HashSet<CHITIETKM>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string TENKM { get; set; }

        public DateTime? NGAYBATDAU { get; set; }

        public DateTime? NGAYKETTHUC { get; set; }

        public bool? ISDELETE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETKM> CHITIETKMs { get; set; }
    }
}
