using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_FISMap : EntityTypeConfiguration<TBL_FIS>
    {
        public TBL_FISMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_FIS_ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("TBL_FIS");
            this.Property(t => t.TBL_FIS_ID).HasColumnName("TBL_FIS_ID");
            this.Property(t => t.ACIKLAMA).HasColumnName("ACIKLAMA");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");
        }
    }
}
