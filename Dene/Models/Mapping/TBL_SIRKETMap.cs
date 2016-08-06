using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_SIRKETMap : EntityTypeConfiguration<TBL_SIRKET>
    {
        public TBL_SIRKETMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_SIRKET_ID);

            // Properties
            this.Property(t => t.SIRKET_ADI)
                .HasMaxLength(50);

            this.Property(t => t.SIRKET_TELEFON_1)
                .HasMaxLength(50);

            this.Property(t => t.SIRKET_TELEFON_2)
                .HasMaxLength(50);

            this.Property(t => t.SIRKET_FAX_1)
                .HasMaxLength(50);

            this.Property(t => t.SIRKET_FAX_2)
                .HasMaxLength(50);

            this.Property(t => t.SIRKET_MAIL_1)
                .HasMaxLength(50);

            this.Property(t => t.SIRKET_MAIL_2)
                .HasMaxLength(50);

            this.Property(t => t.SIRKET_WEB_ADRES)
                .HasMaxLength(50);

            this.Property(t => t.SIRKET_VERGI_DAIRESI)
                .HasMaxLength(50);

            this.Property(t => t.SIRKET_VERGI_NO)
                .HasMaxLength(50);

            this.Property(t => t.SIRKET_IL)
                .HasMaxLength(50);

            this.Property(t => t.SIRKET_ILCE)
                .HasMaxLength(50);

            this.Property(t => t.SIRKET_POSTA_KODU)
                .HasMaxLength(50);

            this.Property(t => t.SIRKET_BANKA_ADI)
                .HasMaxLength(50);

            this.Property(t => t.SIRKET_BANKA_SUBE_ADI)
                .HasMaxLength(50);

            this.Property(t => t.SIRKET_HESAP_NO)
                .HasMaxLength(50);

            this.Property(t => t.SIRKET_IBAN)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TBL_SIRKET");
            this.Property(t => t.TBL_SIRKET_ID).HasColumnName("TBL_SIRKET_ID");
            this.Property(t => t.TBL_SIRKET_GRUB_ID).HasColumnName("TBL_SIRKET_GRUB_ID");
            this.Property(t => t.TBL_SIRKET_SINIF_ID).HasColumnName("TBL_SIRKET_SINIF_ID");
            this.Property(t => t.TBL_SIRKET_TIPI_ID).HasColumnName("TBL_SIRKET_TIPI_ID");
            this.Property(t => t.SIRKET_ADI).HasColumnName("SIRKET_ADI");
            this.Property(t => t.SIRKET_TELEFON_1).HasColumnName("SIRKET_TELEFON_1");
            this.Property(t => t.SIRKET_TELEFON_2).HasColumnName("SIRKET_TELEFON_2");
            this.Property(t => t.SIRKET_FAX_1).HasColumnName("SIRKET_FAX_1");
            this.Property(t => t.SIRKET_FAX_2).HasColumnName("SIRKET_FAX_2");
            this.Property(t => t.SIRKET_MAIL_1).HasColumnName("SIRKET_MAIL_1");
            this.Property(t => t.SIRKET_MAIL_2).HasColumnName("SIRKET_MAIL_2");
            this.Property(t => t.SIRKET_WEB_ADRES).HasColumnName("SIRKET_WEB_ADRES");
            this.Property(t => t.SIRKET_VERGI_DAIRESI).HasColumnName("SIRKET_VERGI_DAIRESI");
            this.Property(t => t.SIRKET_VERGI_NO).HasColumnName("SIRKET_VERGI_NO");
            this.Property(t => t.SIRKET_ADRES).HasColumnName("SIRKET_ADRES");
            this.Property(t => t.SIRKET_IL).HasColumnName("SIRKET_IL");
            this.Property(t => t.SIRKET_ILCE).HasColumnName("SIRKET_ILCE");
            this.Property(t => t.SIRKET_POSTA_KODU).HasColumnName("SIRKET_POSTA_KODU");
            this.Property(t => t.SIRKET_BANKA_ADI).HasColumnName("SIRKET_BANKA_ADI");
            this.Property(t => t.SIRKET_BANKA_SUBE_ADI).HasColumnName("SIRKET_BANKA_SUBE_ADI");
            this.Property(t => t.SIRKET_HESAP_NO).HasColumnName("SIRKET_HESAP_NO");
            this.Property(t => t.SIRKET_IBAN).HasColumnName("SIRKET_IBAN");
            this.Property(t => t.SIRKET_ACIKLAMA).HasColumnName("SIRKET_ACIKLAMA");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");

            // Relationships
            this.HasOptional(t => t.TBL_SIRKET_GRUB)
                .WithMany(t => t.TBL_SIRKET)
                .HasForeignKey(d => d.TBL_SIRKET_GRUB_ID);
            this.HasOptional(t => t.TBL_SIRKET_SINIF)
                .WithMany(t => t.TBL_SIRKET)
                .HasForeignKey(d => d.TBL_SIRKET_SINIF_ID);
            this.HasOptional(t => t.TBL_SIRKET_TIPI)
                .WithMany(t => t.TBL_SIRKET)
                .HasForeignKey(d => d.TBL_SIRKET_TIPI_ID);

        }
    }
}
