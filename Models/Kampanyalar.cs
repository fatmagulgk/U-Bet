namespace Ucbet0._1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kampanyalar")]
    public partial class Kampanyalar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kampanyalar()
        {
            Bilet = new HashSet<Bilet>();
        }

        [Key]
        public int kampanyaID { get; set; }

        [Required]
        [StringLength(50)]
        public string kampanyaAd { get; set; }

        [Required]
        [StringLength(100)]
        public string kampanyaAciklama { get; set; }

        [Required]
        [StringLength(100)]
        public string kampanyaGorsel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bilet> Bilet { get; set; }
    }
}
