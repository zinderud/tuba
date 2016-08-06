using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_KASAMap : EntityTypeConfiguration<TBL_KASA>
    {
        public TBL_KASAMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_KASA_ID);

            // Properties
            this.Property(t => t.KASA_ADI)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TBL_KASA");
            this.Property(t => t.TBL_KASA_ID).HasColumnName("TBL_KASA_ID");
            this.Property(t => t.TBL_PARA_TIPI_ID).HasColumnName("TBL_PARA_TIPI_ID");
            this.Property(t => t.KASA_ADI).HasColumnName("KASA_ADI");
            this.Property(t => t.KASA_ACIKLAMA).HasColumnName("KASA_ACIKLAMA");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");

            // Relationships
            this.HasOptional(t => t.TBL_PARA_TIPI)
                .WithMany(t => t.TBL_KASA)
                .HasForeignKey(d => d.TBL_PARA_TIPI_ID);

        }
    }
}
