namespace Ucbet0._1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ucuslar")]
    public partial class Ucuslar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ucuslar()
        {
            Bilet = new HashSet<Bilet>();
        }

        [Key]
        public int ucusID { get; set; }

        [Required]
        [StringLength(50)]
        public string kalkisYeri { get; set; }

        [Required]
        [StringLength(50)]
        public string varisYeri { get; set; }

        [Column(TypeName = "date")]
        public DateTime ucusTarih { get; set; }

        public TimeSpan ucusSaat { get; set; }

        [Required]
        [StringLength(50)]
        public string bagaj { get; set; }

        [Column(TypeName = "money")]
        public decimal fiyat { get; set; }

        public int koltukId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bilet> Bilet { get; set; }

        public virtual Koltuk Koltuk { get; set; }
    }
}
