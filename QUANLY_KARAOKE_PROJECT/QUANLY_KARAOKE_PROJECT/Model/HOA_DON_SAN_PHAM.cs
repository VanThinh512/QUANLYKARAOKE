namespace QUANLY_KARAOKE_PROJECT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HOA_DON_SAN_PHAM
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string IDHoaDon { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDSanPham { get; set; }

        public int? SoLuong { get; set; }

        public int? ThanhTien { get; set; }

        public virtual HOA_DON HOA_DON { get; set; }

        public virtual SAN_PHAM SAN_PHAM { get; set; }
    }
}
