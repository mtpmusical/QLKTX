namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VAITRO")]
    public partial class VAITRO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VAITRO()
        {
            PHANQUYENs = new HashSet<PHANQUYEN>();
        }

        [Key]
        [StringLength(20)]
        public string MaVT { get; set; }

        [StringLength(20)]
        public string TenVT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANQUYEN> PHANQUYENs { get; set; }
    }
}
