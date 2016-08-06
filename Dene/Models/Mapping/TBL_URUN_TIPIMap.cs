using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_URUN_TIPIMap : EntityTypeConfiguration<TBL_URUN_TIPI>
    {
        public TBL_URUN_TIPIMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_URUN_TIPI_ID);

            // Properties
            this.Property(t => t.URUN_TIPI_ADI)
                .HasMaxLength(50);

            this.Property(t => t.URUN_TIPI_ACIKLAMA)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TBL_URUN_TIPI");
            this.Property(t => t.TBL_URUN_TIPI_ID).HasColumnName("TBL_URUN_TIPI_ID");
            this.Property(t => t.URUN_TIPI_ADI).HasColumnName("URUN_TIPI_ADI");
            this.Property(t => t.URUN_TIPI_ACIKLAMA).HasColumnName("URUN_TIPI_ACIKLAMA");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");
        }
    }
}
