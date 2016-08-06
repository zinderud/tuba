using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_URUN_SPARISMap : EntityTypeConfiguration<TBL_URUN_SPARIS>
    {
        public TBL_URUN_SPARISMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_URUN_SPARIS_ID);

            // Properties
            this.Property(t => t.URUN_SIPARIS_MIKTAR)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TBL_URUN_SPARIS");
            this.Property(t => t.TBL_URUN_SPARIS_ID).HasColumnName("TBL_URUN_SPARIS_ID");
            this.Property(t => t.TBL_URUN_ID).HasColumnName("TBL_URUN_ID");
            this.Property(t => t.TBL_SIPARIS_ID).HasColumnName("TBL_SIPARIS_ID");
            this.Property(t => t.URUN_SIPARIS_MIKTAR).HasColumnName("URUN_SIPARIS_MIKTAR");
            this.Property(t => t.ACIKLAMA).HasColumnName("ACIKLAMA");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");

            // Relationships
            this.HasOptional(t => t.TBL_SPARIS)
                .WithMany(t => t.TBL_URUN_SPARIS)
                .HasForeignKey(d => d.TBL_SIPARIS_ID);
            this.HasOptional(t => t.TBL_URUN)
                .WithMany(t => t.TBL_URUN_SPARIS)
                .HasForeignKey(d => d.TBL_URUN_ID);

        }
    }
}
