using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_KASA_BAKIYEMap : EntityTypeConfiguration<TBL_KASA_BAKIYE>
    {
        public TBL_KASA_BAKIYEMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_KASA_BAKIYE_ID);

            // Properties
            this.Property(t => t.KUR)
                .HasMaxLength(50);

            this.Property(t => t.TARIH)
                .HasMaxLength(50);

            this.Property(t => t.TUTAR)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TBL_KASA_BAKIYE");
            this.Property(t => t.TBL_KASA_BAKIYE_ID).HasColumnName("TBL_KASA_BAKIYE_ID");
            this.Property(t => t.TBL_KASA_ID).HasColumnName("TBL_KASA_ID");
            this.Property(t => t.TBL_PARA_TIPI_ID).HasColumnName("TBL_PARA_TIPI_ID");
            this.Property(t => t.TBL_FIS_ID).HasColumnName("TBL_FIS_ID");
            this.Property(t => t.KUR).HasColumnName("KUR");
            this.Property(t => t.TARIH).HasColumnName("TARIH");
            this.Property(t => t.TUTAR).HasColumnName("TUTAR");
            this.Property(t => t.ACIKLAMA).HasColumnName("ACIKLAMA");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");

            // Relationships
            this.HasOptional(t => t.TBL_FIS)
                .WithMany(t => t.TBL_KASA_BAKIYE)
                .HasForeignKey(d => d.TBL_FIS_ID);
            this.HasOptional(t => t.TBL_KASA)
                .WithMany(t => t.TBL_KASA_BAKIYE)
                .HasForeignKey(d => d.TBL_KASA_ID);
            this.HasOptional(t => t.TBL_PARA_TIPI)
                .WithMany(t => t.TBL_KASA_BAKIYE)
                .HasForeignKey(d => d.TBL_PARA_TIPI_ID);

        }
    }
}
