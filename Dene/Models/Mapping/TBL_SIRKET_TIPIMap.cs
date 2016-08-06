using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_SIRKET_TIPIMap : EntityTypeConfiguration<TBL_SIRKET_TIPI>
    {
        public TBL_SIRKET_TIPIMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_SIRKET_TIPI_ID);

            // Properties
            this.Property(t => t.SIRKET_TIPI_ADI)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TBL_SIRKET_TIPI");
            this.Property(t => t.TBL_SIRKET_TIPI_ID).HasColumnName("TBL_SIRKET_TIPI_ID");
            this.Property(t => t.SIRKET_TIPI_ADI).HasColumnName("SIRKET_TIPI_ADI");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");
        }
    }
}
