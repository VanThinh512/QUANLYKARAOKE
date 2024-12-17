namespace QUANLY_KARAOKE_PROJECT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DAT_PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DAT_PHONG()
        {
            HOA_DON = new HashSet<HOA_DON>();
        }

        [Key]
        [StringLength(50)]
        public string IDDatPhong { get; set; }

        public int? IDKhachHang { get; set; }

        public int? IDPhong { get; set; }

        public DateTime? ThoiGianVao { get; set; }

        public DateTime? ThoiGianRa { get; set; }

        public int? TienPhong { get; set; }

        public virtual KHACH_HANG KHACH_HANG { get; set; }

        public virtual PHONG PHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOA_DON> HOA_DON { get; set; }
    }
}
