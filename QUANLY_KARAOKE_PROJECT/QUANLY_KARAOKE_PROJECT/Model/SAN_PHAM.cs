namespace QUANLY_KARAOKE_PROJECT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAN_PHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SAN_PHAM()
        {
            HOA_DON_SAN_PHAM = new HashSet<HOA_DON_SAN_PHAM>();
        }

        [Key]
        public int IDSanPham { get; set; }

        [StringLength(50)]
        public string TenSanPham { get; set; }

        [StringLength(50)]
        public string MoTa { get; set; }

        public int? DonGia { get; set; }

        public byte? HienDung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOA_DON_SAN_PHAM> HOA_DON_SAN_PHAM { get; set; }
    }
}
