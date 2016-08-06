using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_SPARISMap : EntityTypeConfiguration<TBL_SPARIS>
    {
        public TBL_SPARISMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_SPARIS_ID);

            // Properties
            this.Property(t => t.SPARIS_TARIH)
                .HasMaxLength(50);

            this.Property(t => t.SPARIS_VADE_TARIH)
                .HasMaxLength(50);

            this.Property(t => t.SPARIS_FATURA_SERI_NO)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TBL_SPARIS");
            this.Property(t => t.TBL_SPARIS_ID).HasColumnName("TBL_SPARIS_ID");
            this.Property(t => t.TBL_SIRKET_ID).HasColumnName("TBL_SIRKET_ID");
            this.Property(t => t.TBL_SPARIS_TURU_ID).HasColumnName("TBL_SPARIS_TURU_ID");
            this.Property(t => t.SPARIS_TARIH).HasColumnName("SPARIS_TARIH");
            this.Property(t => t.SPARIS_VADE_TARIH).HasColumnName("SPARIS_VADE_TARIH");
            this.Property(t => t.SPARIS_FATURA_SERI_NO).HasColumnName("SPARIS_FATURA_SERI_NO");
            this.Property(t => t.TBL_PARA_TIPI_ID).HasColumnName("TBL_PARA_TIPI_ID");
            this.Property(t => t.TBL_ODEME_TIPI_ID).HasColumnName("TBL_ODEME_TIPI_ID");
            this.Property(t => t.TBL_KASA_ID).HasColumnName("TBL_KASA_ID");
            this.Property(t => t.TBL_DEPO_ID).HasColumnName("TBL_DEPO_ID");
            this.Property(t => t.TBL_PERSONEL_ID).HasColumnName("TBL_PERSONEL_ID");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");

            // Relationships
            this.HasOptional(t => t.TBL_DEPO)
                .WithMany(t => t.TBL_SPARIS)
                .HasForeignKey(d => d.TBL_DEPO_ID);
            this.HasOptional(t => t.TBL_KASA)
                .WithMany(t => t.TBL_SPARIS)
                .HasForeignKey(d => d.TBL_KASA_ID);
            this.HasOptional(t => t.TBL_ODEME_TIPI)
                .WithMany(t => t.TBL_SPARIS)
                .HasForeignKey(d => d.TBL_ODEME_TIPI_ID);
            this.HasOptional(t => t.TBL_PARA_TIPI)
                .WithMany(t => t.TBL_SPARIS)
                .HasForeignKey(d => d.TBL_PARA_TIPI_ID);
            this.HasOptional(t => t.TBL_PERSONEL)
                .WithMany(t => t.TBL_SPARIS)
                .HasForeignKey(d => d.TBL_PERSONEL_ID);
            this.HasOptional(t => t.TBL_SIRKET)
                .WithMany(t => t.TBL_SPARIS)
                .HasForeignKey(d => d.TBL_SIRKET_ID);
            this.HasOptional(t => t.TBL_SPARIS_TURU)
                .WithMany(t => t.TBL_SPARIS)
                .HasForeignKey(d => d.TBL_SPARIS_TURU_ID);

        }
    }
}
