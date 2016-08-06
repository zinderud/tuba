using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_ODEME_TURUMap : EntityTypeConfiguration<TBL_ODEME_TURU>
    {
        public TBL_ODEME_TURUMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_ODEME_TURU_ID);

            // Properties
            this.Property(t => t.ODEME_TURU_ADI)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TBL_ODEME_TURU");
            this.Property(t => t.TBL_ODEME_TURU_ID).HasColumnName("TBL_ODEME_TURU_ID");
            this.Property(t => t.ODEME_TURU_ADI).HasColumnName("ODEME_TURU_ADI");
            this.Property(t => t.ODEME_TURU_ACIKLAMA).HasColumnName("ODEME_TURU_ACIKLAMA");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");
        }
    }
}
