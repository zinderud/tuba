using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_ODEMEMap : EntityTypeConfiguration<TBL_ODEME>
    {
        public TBL_ODEMEMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_ODEME_ID);

            // Properties
            this.Property(t => t.ODEME_KAYIT_TARIHI)
                .HasMaxLength(50);

            this.Property(t => t.ODEME_VADE_TARIHI)
                .HasMaxLength(50);

            this.Property(t => t.BELGE_NO)
                .HasMaxLength(50);

            this.Property(t => t.TUTAR)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TBL_ODEME");
            this.Property(t => t.TBL_ODEME_ID).HasColumnName("TBL_ODEME_ID");
            this.Property(t => t.ODEME_KAYIT_TARIHI).HasColumnName("ODEME_KAYIT_TARIHI");
            this.Property(t => t.ODEME_VADE_TARIHI).HasColumnName("ODEME_VADE_TARIHI");
            this.Property(t => t.TBL_ODEME_TURU_ID).HasColumnName("TBL_ODEME_TURU_ID");
            this.Property(t => t.TBL_ODEME_TIPI_ID).HasColumnName("TBL_ODEME_TIPI_ID");
            this.Property(t => t.BELGE_NO).HasColumnName("BELGE_NO");
            this.Property(t => t.TBL_SIRKET_ID).HasColumnName("TBL_SIRKET_ID");
            this.Property(t => t.TUTAR).HasColumnName("TUTAR");
            this.Property(t => t.TBL_PARA_TIPI_ID).HasColumnName("TBL_PARA_TIPI_ID");
            this.Property(t => t.TBL_KASA_ID).HasColumnName("TBL_KASA_ID");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");

            // Relationships
            this.HasOptional(t => t.TBL_KASA)
                .WithMany(t => t.TBL_ODEME)
                .HasForeignKey(d => d.TBL_KASA_ID);
            this.HasOptional(t => t.TBL_ODEME_TIPI)
                .WithMany(t => t.TBL_ODEME)
                .HasForeignKey(d => d.TBL_ODEME_TIPI_ID);
            this.HasOptional(t => t.TBL_ODEME_TURU)
                .WithMany(t => t.TBL_ODEME)
                .HasForeignKey(d => d.TBL_ODEME_TURU_ID);
            this.HasOptional(t => t.TBL_PARA_TIPI)
                .WithMany(t => t.TBL_ODEME)
                .HasForeignKey(d => d.TBL_PARA_TIPI_ID);
            this.HasOptional(t => t.TBL_SIRKET)
                .WithMany(t => t.TBL_ODEME)
                .HasForeignKey(d => d.TBL_SIRKET_ID);

        }
    }
}
