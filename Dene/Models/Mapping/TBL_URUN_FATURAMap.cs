using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_URUN_FATURAMap : EntityTypeConfiguration<TBL_URUN_FATURA>
    {
        public TBL_URUN_FATURAMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_URUN_FATURA_ID);

            // Properties
            this.Property(t => t.URUN_FATURA_MIKTAR)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TBL_URUN_FATURA");
            this.Property(t => t.TBL_URUN_FATURA_ID).HasColumnName("TBL_URUN_FATURA_ID");
            this.Property(t => t.TBL_URUN_ID).HasColumnName("TBL_URUN_ID");
            this.Property(t => t.TBL_FATURA_ID).HasColumnName("TBL_FATURA_ID");
            this.Property(t => t.URUN_FATURA_MIKTAR).HasColumnName("URUN_FATURA_MIKTAR");
            this.Property(t => t.ACIKLAMA).HasColumnName("ACIKLAMA");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");

            // Relationships
            this.HasOptional(t => t.TBL_FATURA)
                .WithMany(t => t.TBL_URUN_FATURA)
                .HasForeignKey(d => d.TBL_FATURA_ID);
            this.HasOptional(t => t.TBL_URUN)
                .WithMany(t => t.TBL_URUN_FATURA)
                .HasForeignKey(d => d.TBL_URUN_ID);

        }
    }
}
