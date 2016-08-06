using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_URUN_CINSIMap : EntityTypeConfiguration<TBL_URUN_CINSI>
    {
        public TBL_URUN_CINSIMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_URUN_CINSI_ID);

            // Properties
            this.Property(t => t.URUN_CINSI_ADI)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TBL_URUN_CINSI");
            this.Property(t => t.TBL_URUN_CINSI_ID).HasColumnName("TBL_URUN_CINSI_ID");
            this.Property(t => t.TBL_URUN_TIPI_ID).HasColumnName("TBL_URUN_TIPI_ID");
            this.Property(t => t.URUN_CINSI_ADI).HasColumnName("URUN_CINSI_ADI");
            this.Property(t => t.URUN_CINSI_ACIKLAMA).HasColumnName("URUN_CINSI_ACIKLAMA");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");

            // Relationships
            this.HasOptional(t => t.TBL_URUN_TIPI)
                .WithMany(t => t.TBL_URUN_CINSI)
                .HasForeignKey(d => d.TBL_URUN_TIPI_ID);

        }
    }
}
