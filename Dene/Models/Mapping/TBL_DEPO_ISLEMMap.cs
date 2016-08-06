using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_DEPO_ISLEMMap : EntityTypeConfiguration<TBL_DEPO_ISLEM>
    {
        public TBL_DEPO_ISLEMMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_DEPO_ISLEM_ID);

            // Properties
            this.Property(t => t.DEPO_ISLEM_ADI)
                .HasMaxLength(50);

            this.Property(t => t.URUN_MIKTAR)
                .HasMaxLength(50);

            this.Property(t => t.DEPO_ONAY)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TBL_DEPO_ISLEM");
            this.Property(t => t.TBL_DEPO_ISLEM_ID).HasColumnName("TBL_DEPO_ISLEM_ID");
            this.Property(t => t.TBL_DEPO_ID).HasColumnName("TBL_DEPO_ID");
            this.Property(t => t.TBL_URUN_ID).HasColumnName("TBL_URUN_ID");
            this.Property(t => t.DEPO_ISLEM_ADI).HasColumnName("DEPO_ISLEM_ADI");
            this.Property(t => t.URUN_MIKTAR).HasColumnName("URUN_MIKTAR");
            this.Property(t => t.DEPO_ONAY).HasColumnName("DEPO_ONAY");
            this.Property(t => t.ACIKLAMA).HasColumnName("ACIKLAMA");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");

            // Relationships
            this.HasOptional(t => t.TBL_DEPO)
                .WithMany(t => t.TBL_DEPO_ISLEM)
                .HasForeignKey(d => d.TBL_DEPO_ID);
            this.HasOptional(t => t.TBL_URUN)
                .WithMany(t => t.TBL_DEPO_ISLEM)
                .HasForeignKey(d => d.TBL_URUN_ID);

        }
    }
}
