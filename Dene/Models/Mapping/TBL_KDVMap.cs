using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_KDVMap : EntityTypeConfiguration<TBL_KDV>
    {
        public TBL_KDVMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_KDV_ID);

            // Properties
            this.Property(t => t.TBL_KDV_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("TBL_KDV");
            this.Property(t => t.TBL_KDV_ID).HasColumnName("TBL_KDV_ID");
            this.Property(t => t.KDV_YUZDESI).HasColumnName("KDV_YUZDESI");
            this.Property(t => t.KDV_ACIKLAMA).HasColumnName("KDV_ACIKLAMA");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");
        }
    }
}
