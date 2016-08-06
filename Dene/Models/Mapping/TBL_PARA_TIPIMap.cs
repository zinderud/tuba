using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_PARA_TIPIMap : EntityTypeConfiguration<TBL_PARA_TIPI>
    {
        public TBL_PARA_TIPIMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_PARA_TIPI_ID);

            // Properties
            this.Property(t => t.PARA_TIPI_ADI)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TBL_PARA_TIPI");
            this.Property(t => t.TBL_PARA_TIPI_ID).HasColumnName("TBL_PARA_TIPI_ID");
            this.Property(t => t.PARA_TIPI_ADI).HasColumnName("PARA_TIPI_ADI");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");
        }
    }
}
