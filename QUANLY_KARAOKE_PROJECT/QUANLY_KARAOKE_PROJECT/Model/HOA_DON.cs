namespace QUANLY_KARAOKE_PROJECT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HOA_DON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOA_DON()
        {
            HOA_DON_SAN_PHAM = new HashSet<HOA_DON_SAN_PHAM>();
        }

        [Key]
        [StringLength(50)]
        public string IDHoaDon { get; set; }

        public int? IDKhachHang { get; set; }

        [StringLength(50)]
        public string IDDatPhong { get; set; }

        [StringLength(50)]
        public string NgayGioTao { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        public int? TongCong { get; set; }

        public int? GiamGia { get; set; }

        public int? Tong { get; set; }

        public byte? TrangThai { get; set; }

        public int? PhuThu { get; set; }

        public virtual DAT_PHONG DAT_PHONG { get; set; }

        public virtual KHACH_HANG KHACH_HANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOA_DON_SAN_PHAM> HOA_DON_SAN_PHAM { get; set; }
    }
}
