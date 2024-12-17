namespace QUANLY_KARAOKE_PROJECT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHONG")]
    public partial class PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONG()
        {
            DAT_PHONG = new HashSet<DAT_PHONG>();
        }

        [Key]
        public int IDPhong { get; set; }

        [StringLength(50)]
        public string TenPhong { get; set; }

        public int? IDLoaiPhong { get; set; }

        public byte? TrangThai { get; set; }

        public byte? HienDung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DAT_PHONG> DAT_PHONG { get; set; }

        public virtual LOAI_PHONG LOAI_PHONG { get; set; }
    }
}
