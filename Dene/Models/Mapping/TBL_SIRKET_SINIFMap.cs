using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_SIRKET_SINIFMap : EntityTypeConfiguration<TBL_SIRKET_SINIF>
    {
        public TBL_SIRKET_SINIFMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_SIRKET_SINIF_ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("TBL_SIRKET_SINIF");
            this.Property(t => t.TBL_SIRKET_SINIF_ID).HasColumnName("TBL_SIRKET_SINIF_ID");
            this.Property(t => t.SIRKET_SINIF_ADI).HasColumnName("SIRKET_SINIF_ADI");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");
        }
    }
}
