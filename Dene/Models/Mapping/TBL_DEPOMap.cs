using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_DEPOMap : EntityTypeConfiguration<TBL_DEPO>
    {
        public TBL_DEPOMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_DEPO_ID);

            // Properties
            this.Property(t => t.DEPO_ADI)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TBL_DEPO");
            this.Property(t => t.TBL_DEPO_ID).HasColumnName("TBL_DEPO_ID");
            this.Property(t => t.DEPO_ADI).HasColumnName("DEPO_ADI");
            this.Property(t => t.DEPO_ACIKLAMA).HasColumnName("DEPO_ACIKLAMA");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");
        }
    }
}
