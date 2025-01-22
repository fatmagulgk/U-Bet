namespace Ucbet0._1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bilet")]
    public partial class Bilet
    {
        public int biletID { get; set; }

        public int kullaniciId { get; set; }

        public int ucusIdd { get; set; }

        public int kampanyaId { get; set; }

        public bool biletDurum { get; set; }

        public virtual Kampanyalar Kampanyalar { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        public virtual Ucuslar Ucuslar { get; set; }
    }
}
