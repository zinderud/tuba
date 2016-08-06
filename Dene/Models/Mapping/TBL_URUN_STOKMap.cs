using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_URUN_STOKMap : EntityTypeConfiguration<TBL_URUN_STOK>
    {
        public TBL_URUN_STOKMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_URUN_STOK_ID);

            // Properties
            this.Property(t => t.STOK_DURUM)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TBL_URUN_STOK");
            this.Property(t => t.TBL_URUN_STOK_ID).HasColumnName("TBL_URUN_STOK_ID");
            this.Property(t => t.TBL_URUN_ID).HasColumnName("TBL_URUN_ID");
            this.Property(t => t.TBL_DEPO_ID).HasColumnName("TBL_DEPO_ID");
            this.Property(t => t.URUN_BIRIM_MIKTARI).HasColumnName("URUN_BIRIM_MIKTARI");
            this.Property(t => t.STOK_DURUM).HasColumnName("STOK_DURUM");
            this.Property(t => t.ACIKLAMA).HasColumnName("ACIKLAMA");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");

            // Relationships
            this.HasOptional(t => t.TBL_DEPO)
                .WithMany(t => t.TBL_URUN_STOK)
                .HasForeignKey(d => d.TBL_DEPO_ID);
            this.HasOptional(t => t.TBL_URUN)
                .WithMany(t => t.TBL_URUN_STOK)
                .HasForeignKey(d => d.TBL_URUN_ID);

        }
    }
}
