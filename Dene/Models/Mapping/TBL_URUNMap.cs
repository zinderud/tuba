using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_URUNMap : EntityTypeConfiguration<TBL_URUN>
    {
        public TBL_URUNMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_URUN_ID);

            // Properties
            this.Property(t => t.URUN_ADI)
                .HasMaxLength(50);

            this.Property(t => t.URUN_DURUM)
                .HasMaxLength(50);

            this.Property(t => t.URUN_ALIS_FIYATI)
                .HasMaxLength(50);

            this.Property(t => t.URUN_SATIS_FIYATI)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TBL_URUN");
            this.Property(t => t.TBL_URUN_ID).HasColumnName("TBL_URUN_ID");
            this.Property(t => t.URUN_ADI).HasColumnName("URUN_ADI");
            this.Property(t => t.URUN_KODU).HasColumnName("URUN_KODU");
            this.Property(t => t.TBL_URUN_TIPI_ID).HasColumnName("TBL_URUN_TIPI_ID");
            this.Property(t => t.TBL_URUN_CINSI_ID).HasColumnName("TBL_URUN_CINSI_ID");
            this.Property(t => t.TBL_URUN_MARKA_ID).HasColumnName("TBL_URUN_MARKA_ID");
            this.Property(t => t.TBL_URUN_BIRIM_ID).HasColumnName("TBL_URUN_BIRIM_ID");
            this.Property(t => t.TBL_KDV_ID).HasColumnName("TBL_KDV_ID");
            this.Property(t => t.URUN_DURUM).HasColumnName("URUN_DURUM");
            this.Property(t => t.URUN_ALIS_FIYATI).HasColumnName("URUN_ALIS_FIYATI");
            this.Property(t => t.URUN_SATIS_FIYATI).HasColumnName("URUN_SATIS_FIYATI");
            this.Property(t => t.TBL_PARA_TIPI_ID).HasColumnName("TBL_PARA_TIPI_ID");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");

            // Relationships
            this.HasOptional(t => t.TBL_KDV)
                .WithMany(t => t.TBL_URUN)
                .HasForeignKey(d => d.TBL_KDV_ID);
            this.HasOptional(t => t.TBL_PARA_TIPI)
                .WithMany(t => t.TBL_URUN)
                .HasForeignKey(d => d.TBL_PARA_TIPI_ID);
            this.HasOptional(t => t.TBL_URUN_BIRIM)
                .WithMany(t => t.TBL_URUN)
                .HasForeignKey(d => d.TBL_URUN_BIRIM_ID);
            this.HasOptional(t => t.TBL_URUN_CINSI)
                .WithMany(t => t.TBL_URUN)
                .HasForeignKey(d => d.TBL_URUN_CINSI_ID);
            this.HasOptional(t => t.TBL_URUN_MARKA)
                .WithMany(t => t.TBL_URUN)
                .HasForeignKey(d => d.TBL_URUN_MARKA_ID);
            this.HasOptional(t => t.TBL_URUN_TIPI)
                .WithMany(t => t.TBL_URUN)
                .HasForeignKey(d => d.TBL_URUN_TIPI_ID);

        }
    }
}
