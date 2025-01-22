namespace Ucbet0._1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kullanici")]
    public partial class Kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanici()
        {
            Bilet = new HashSet<Bilet>();
        }

        public int kullaniciID { get; set; }

        public int yetkiId { get; set; }

        [StringLength(11)]
        public string TCno { get; set; }

        [StringLength(7)]
        public string pasaportNo { get; set; }

        [Required]
        [StringLength(50)]
        public string ad { get; set; }

        [Required]
        [StringLength(50)]
        public string soyad { get; set; }

        [Required]
        [StringLength(50)]
        public string uyruk { get; set; }

        [Column(TypeName = "date")]
        public DateTime doğumt { get; set; }

        [StringLength(50)]
        public string cinsiyet { get; set; }

        [Required]
        [StringLength(50)]
        public string telefonNo { get; set; }

        [Required]
        [StringLength(50)]
        public string Eposta { get; set; }

        [Required]
        [StringLength(16)]
        public string kullaniciSifre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bilet> Bilet { get; set; }

        public virtual Yetki Yetki { get; set; }
    }
}
