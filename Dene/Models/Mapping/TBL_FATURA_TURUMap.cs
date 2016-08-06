using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_FATURA_TURUMap : EntityTypeConfiguration<TBL_FATURA_TURU>
    {
        public TBL_FATURA_TURUMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_FATURA_TURU_ID);

            // Properties
            this.Property(t => t.FATURA_TURU_ADI)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TBL_FATURA_TURU");
            this.Property(t => t.TBL_FATURA_TURU_ID).HasColumnName("TBL_FATURA_TURU_ID");
            this.Property(t => t.FATURA_TURU_ADI).HasColumnName("FATURA_TURU_ADI");
            this.Property(t => t.FATURA_TURU_ACIKLAMA).HasColumnName("FATURA_TURU_ACIKLAMA");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");
        }
    }
}
