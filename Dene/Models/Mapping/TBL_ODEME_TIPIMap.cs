using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_ODEME_TIPIMap : EntityTypeConfiguration<TBL_ODEME_TIPI>
    {
        public TBL_ODEME_TIPIMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_ODEME_TIPI_ID);

            // Properties
            this.Property(t => t.ODEME_TIPI_ADI)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TBL_ODEME_TIPI");
            this.Property(t => t.TBL_ODEME_TIPI_ID).HasColumnName("TBL_ODEME_TIPI_ID");
            this.Property(t => t.ODEME_TIPI_ADI).HasColumnName("ODEME_TIPI_ADI");
            this.Property(t => t.ODEME_TIPI_ACIKLAMA).HasColumnName("ODEME_TIPI_ACIKLAMA");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");
        }
    }
}
