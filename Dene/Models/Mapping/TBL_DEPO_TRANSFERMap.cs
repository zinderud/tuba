using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_DEPO_TRANSFERMap : EntityTypeConfiguration<TBL_DEPO_TRANSFER>
    {
        public TBL_DEPO_TRANSFERMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_DEPO_TRANSFER_ID);

            // Properties
            this.Property(t => t.DEPO_TRANSFER_ADI)
                .HasMaxLength(50);

            this.Property(t => t.DEPO_TRANSFER_TARIHI)
                .HasMaxLength(50);

            this.Property(t => t.DEPO_TRANSFER_NEREDEN)
                .HasMaxLength(50);

            this.Property(t => t.DEPO_TRANSFER_NEREYE)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TBL_DEPO_TRANSFER");
            this.Property(t => t.TBL_DEPO_TRANSFER_ID).HasColumnName("TBL_DEPO_TRANSFER_ID");
            this.Property(t => t.DEPO_TRANSFER_ADI).HasColumnName("DEPO_TRANSFER_ADI");
            this.Property(t => t.DEPO_TRANSFER_TARIHI).HasColumnName("DEPO_TRANSFER_TARIHI");
            this.Property(t => t.DEPO_TRANSFER_NEREDEN).HasColumnName("DEPO_TRANSFER_NEREDEN");
            this.Property(t => t.DEPO_TRANSFER_NEREYE).HasColumnName("DEPO_TRANSFER_NEREYE");
            this.Property(t => t.TBL_URUN_ID).HasColumnName("TBL_URUN_ID");
            this.Property(t => t.DEPO_TRANSFER_ACIKLAMA).HasColumnName("DEPO_TRANSFER_ACIKLAMA");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");

            // Relationships
            this.HasOptional(t => t.TBL_URUN)
                .WithMany(t => t.TBL_DEPO_TRANSFER)
                .HasForeignKey(d => d.TBL_URUN_ID);

        }
    }
}
