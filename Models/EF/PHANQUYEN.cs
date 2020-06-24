namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHANQUYEN")]
    public partial class PHANQUYEN
    {
        [Key]
        [StringLength(15)]
        public string MaNV { get; set; }

        [StringLength(20)]
        public string MaVT { get; set; }

        public virtual NGUOIDUNG NGUOIDUNG { get; set; }

        public virtual VAITRO VAITRO { get; set; }
    }
}
