using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Ucbet0._1.Models
{
    public partial class ucbetdb : DbContext
    {
        public ucbetdb()
            : base("name=ucbetdb7")
        {
        }

        public virtual DbSet<Bilet> Bilet { get; set; }
        public virtual DbSet<Kampanyalar> Kampanyalar { get; set; }
        public virtual DbSet<Koltuk> Koltuk { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Ucuslar> Ucuslar { get; set; }
        public virtual DbSet<Yetki> Yetki { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kampanyalar>()
                .HasMany(e => e.Bilet)
                .WithRequired(e => e.Kampanyalar)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Koltuk>()
                .HasMany(e => e.Ucuslar)
                .WithRequired(e => e.Koltuk)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.Bilet)
                .WithRequired(e => e.Kullanici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ucuslar>()
                .Property(e => e.fiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Ucuslar>()
                .HasMany(e => e.Bilet)
                .WithRequired(e => e.Ucuslar)
                .HasForeignKey(e => e.ucusIdd)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yetki>()
                .HasMany(e => e.Kullanici)
                .WithRequired(e => e.Yetki)
                .WillCascadeOnDelete(false);
        }
    }
}
