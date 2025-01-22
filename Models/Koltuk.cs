namespace Ucbet0._1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Koltuk")]
    public partial class Koltuk
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Koltuk()
        {
            Ucuslar = new HashSet<Ucuslar>();
        }

        public int koltukID { get; set; }

        [Required]
        [StringLength(50)]
        public string koltukNo { get; set; }

        public bool koltukDurumu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ucuslar> Ucuslar { get; set; }
    }
}
