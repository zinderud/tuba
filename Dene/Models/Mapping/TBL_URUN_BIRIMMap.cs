using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_URUN_BIRIMMap : EntityTypeConfiguration<TBL_URUN_BIRIM>
    {
        public TBL_URUN_BIRIMMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_URUN_BIRIM_ID);

            // Properties
            this.Property(t => t.URUN_BIRIM_ADI)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TBL_URUN_BIRIM");
            this.Property(t => t.TBL_URUN_BIRIM_ID).HasColumnName("TBL_URUN_BIRIM_ID");
            this.Property(t => t.URUN_BIRIM_ADI).HasColumnName("URUN_BIRIM_ADI");
            this.Property(t => t.URUN_BIRIM_ACIKLAMA).HasColumnName("URUN_BIRIM_ACIKLAMA");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");
        }
    }
}
