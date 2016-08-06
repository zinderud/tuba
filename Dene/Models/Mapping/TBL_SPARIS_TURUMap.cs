using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_SPARIS_TURUMap : EntityTypeConfiguration<TBL_SPARIS_TURU>
    {
        public TBL_SPARIS_TURUMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_SPARIS_TURU_ID);

            // Properties
            this.Property(t => t.SPARIS_TURU_ADI)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TBL_SPARIS_TURU");
            this.Property(t => t.TBL_SPARIS_TURU_ID).HasColumnName("TBL_SPARIS_TURU_ID");
            this.Property(t => t.SPARIS_TURU_ADI).HasColumnName("SPARIS_TURU_ADI");
            this.Property(t => t.SPARIS_TURU_ACIKLAMA).HasColumnName("SPARIS_TURU_ACIKLAMA");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");
        }
    }
}
