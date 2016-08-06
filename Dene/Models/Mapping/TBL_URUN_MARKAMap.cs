using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_URUN_MARKAMap : EntityTypeConfiguration<TBL_URUN_MARKA>
    {
        public TBL_URUN_MARKAMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_URUN_MARKA_ID);

            // Properties
            this.Property(t => t.URUN_MARKA_ADI)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TBL_URUN_MARKA");
            this.Property(t => t.TBL_URUN_MARKA_ID).HasColumnName("TBL_URUN_MARKA_ID");
            this.Property(t => t.TBL_URUN_TIPI_ID).HasColumnName("TBL_URUN_TIPI_ID");
            this.Property(t => t.TBL_URUN_CINSI_ID).HasColumnName("TBL_URUN_CINSI_ID");
            this.Property(t => t.URUN_MARKA_ADI).HasColumnName("URUN_MARKA_ADI");
            this.Property(t => t.URUN_MARKA_ACIKLAMA).HasColumnName("URUN_MARKA_ACIKLAMA");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");

            // Relationships
            this.HasRequired(t => t.TBL_URUN_CINSI)
                .WithMany(t => t.TBL_URUN_MARKA)
                .HasForeignKey(d => d.TBL_URUN_CINSI_ID);
            this.HasOptional(t => t.TBL_URUN_TIPI)
                .WithMany(t => t.TBL_URUN_MARKA)
                .HasForeignKey(d => d.TBL_URUN_TIPI_ID);

        }
    }
}
