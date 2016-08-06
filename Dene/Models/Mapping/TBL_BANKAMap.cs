using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_BANKAMap : EntityTypeConfiguration<TBL_BANKA>
    {
        public TBL_BANKAMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_BANKA_ID);

            // Properties
            this.Property(t => t.BANKA_ADI)
                .HasMaxLength(50);

            this.Property(t => t.BANKA_SUBE_ADI)
                .HasMaxLength(50);

            this.Property(t => t.BANKA_IBAN_NO)
                .HasMaxLength(50);

            this.Property(t => t.BANKA_TELEFON_1)
                .HasMaxLength(50);

            this.Property(t => t.BANKA_TELEFON_2)
                .HasMaxLength(50);

            this.Property(t => t.BANKA_IL)
                .HasMaxLength(50);

            this.Property(t => t.BANKA_ILCE)
                .HasMaxLength(50);

            this.Property(t => t.BANKA_MAIL)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TBL_BANKA");
            this.Property(t => t.TBL_BANKA_ID).HasColumnName("TBL_BANKA_ID");
            this.Property(t => t.BANKA_ADI).HasColumnName("BANKA_ADI");
            this.Property(t => t.BANKA_SUBE_ADI).HasColumnName("BANKA_SUBE_ADI");
            this.Property(t => t.BANKA_IBAN_NO).HasColumnName("BANKA_IBAN_NO");
            this.Property(t => t.TBL_PARA_TIPI_ID).HasColumnName("TBL_PARA_TIPI_ID");
            this.Property(t => t.BANKA_TELEFON_1).HasColumnName("BANKA_TELEFON_1");
            this.Property(t => t.BANKA_TELEFON_2).HasColumnName("BANKA_TELEFON_2");
            this.Property(t => t.BANKA_ADRES).HasColumnName("BANKA_ADRES");
            this.Property(t => t.BANKA_IL).HasColumnName("BANKA_IL");
            this.Property(t => t.BANKA_ILCE).HasColumnName("BANKA_ILCE");
            this.Property(t => t.BANKA_MAIL).HasColumnName("BANKA_MAIL");
            this.Property(t => t.BANKA_ACIKLAMA).HasColumnName("BANKA_ACIKLAMA");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");

            // Relationships
            this.HasOptional(t => t.TBL_PARA_TIPI)
                .WithMany(t => t.TBL_BANKA)
                .HasForeignKey(d => d.TBL_PARA_TIPI_ID);

        }
    }
}
