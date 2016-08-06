using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_GIDERMap : EntityTypeConfiguration<TBL_GIDER>
    {
        public TBL_GIDERMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_GIDER_ID);

            // Properties
            this.Property(t => t.GİDER_ADI)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TBL_GIDER");
            this.Property(t => t.TBL_GIDER_ID).HasColumnName("TBL_GIDER_ID");
            this.Property(t => t.TBL_PARA_TIPI_ID).HasColumnName("TBL_PARA_TIPI_ID");
            this.Property(t => t.GİDER_ADI).HasColumnName("GİDER_ADI");
            this.Property(t => t.GİDER_ACIKLAMA).HasColumnName("GİDER_ACIKLAMA");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");

            // Relationships
            this.HasOptional(t => t.TBL_PARA_TIPI)
                .WithMany(t => t.TBL_GIDER)
                .HasForeignKey(d => d.TBL_PARA_TIPI_ID);

        }
    }
}
