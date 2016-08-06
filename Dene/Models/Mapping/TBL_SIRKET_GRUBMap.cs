using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_SIRKET_GRUBMap : EntityTypeConfiguration<TBL_SIRKET_GRUB>
    {
        public TBL_SIRKET_GRUBMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_SIRKET_GRUB_ID);

            // Properties
            this.Property(t => t.SIRKET_GRUP_ADI)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TBL_SIRKET_GRUB");
            this.Property(t => t.TBL_SIRKET_GRUB_ID).HasColumnName("TBL_SIRKET_GRUB_ID");
            this.Property(t => t.SIRKET_GRUP_ADI).HasColumnName("SIRKET_GRUP_ADI");
            this.Property(t => t.ACIKLAMA).HasColumnName("ACIKLAMA");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");
        }
    }
}
