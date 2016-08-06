using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Dene.Models.Mapping
{
    public class TBL_PERSONELMap : EntityTypeConfiguration<TBL_PERSONEL>
    {
        public TBL_PERSONELMap()
        {
            // Primary Key
            this.HasKey(t => t.TBL_PERSONEL_ID);

            // Properties
            this.Property(t => t.PERSONEL_AD_SOYAD)
                .HasMaxLength(50);

            this.Property(t => t.PERSONEL_GOREVI)
                .HasMaxLength(50);

            this.Property(t => t.PERSONEL_TELEFON1)
                .HasMaxLength(50);

            this.Property(t => t.PERSONEL_TELEFON2)
                .HasMaxLength(50);

            this.Property(t => t.PERSONEL_MAIL)
                .HasMaxLength(50);

            this.Property(t => t.PERSONEL_CALISMA_DURUMU)
                .HasMaxLength(50);

            this.Property(t => t.PERSONEL_ISE_BASLAMA_TARIHI)
                .HasMaxLength(50);

            this.Property(t => t.PERSONEL_ISTEN_AYRILMA_TARIHI)
                .HasMaxLength(50);

            this.Property(t => t.PERSONEL_ISE_GELIS_SAATI)
                .HasMaxLength(50);

            this.Property(t => t.PERSONEL_ISTEN_CIKIS_SAATI)
                .HasMaxLength(50);

            this.Property(t => t.PERSONEL_SSK_NO)
                .HasMaxLength(50);

            this.Property(t => t.PERSONEL_CINSIYET)
                .HasMaxLength(50);

            this.Property(t => t.PERSONEL_KIMLIK_NO)
                .HasMaxLength(50);

            this.Property(t => t.PERSONEL_DOGUM_TARIHI)
                .HasMaxLength(50);

            this.Property(t => t.PERSONEL_DOGUM_YERI)
                .HasMaxLength(50);

            this.Property(t => t.PERSONEL_EGITIM_DURUMU)
                .HasMaxLength(50);

            this.Property(t => t.PERSONEL_ACIKLAMA)
                .HasMaxLength(50);

            this.Property(t => t.PERSONEL_AYAKKABI_NO)
                .HasMaxLength(50);

            this.Property(t => t.PERSONEL_GOMLEK_NO)
                .HasMaxLength(50);

            this.Property(t => t.PERSONEL_MONT_NO)
                .HasMaxLength(50);

            this.Property(t => t.PERSONEL_PANTOLON_NO)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TBL_PERSONEL");
            this.Property(t => t.TBL_PERSONEL_ID).HasColumnName("TBL_PERSONEL_ID");
            this.Property(t => t.PERSONEL_AD_SOYAD).HasColumnName("PERSONEL_AD_SOYAD");
            this.Property(t => t.YETKI_SEVIYESI).HasColumnName("YETKI_SEVIYESI");
            this.Property(t => t.SIFRE).HasColumnName("SIFRE");
            this.Property(t => t.BARKOD_ID).HasColumnName("BARKOD_ID");
            this.Property(t => t.PERSONEL_GOREVI).HasColumnName("PERSONEL_GOREVI");
            this.Property(t => t.PERSONEL_TELEFON1).HasColumnName("PERSONEL_TELEFON1");
            this.Property(t => t.PERSONEL_TELEFON2).HasColumnName("PERSONEL_TELEFON2");
            this.Property(t => t.PERSONEL_MAIL).HasColumnName("PERSONEL_MAIL");
            this.Property(t => t.PERSONEL_CALISMA_DURUMU).HasColumnName("PERSONEL_CALISMA_DURUMU");
            this.Property(t => t.PERSONEL_ISE_BASLAMA_TARIHI).HasColumnName("PERSONEL_ISE_BASLAMA_TARIHI");
            this.Property(t => t.PERSONEL_ISTEN_AYRILMA_TARIHI).HasColumnName("PERSONEL_ISTEN_AYRILMA_TARIHI");
            this.Property(t => t.PERSONEL_ISE_GELIS_SAATI).HasColumnName("PERSONEL_ISE_GELIS_SAATI");
            this.Property(t => t.PERSONEL_ISTEN_CIKIS_SAATI).HasColumnName("PERSONEL_ISTEN_CIKIS_SAATI");
            this.Property(t => t.PERSONEL_SSK_NO).HasColumnName("PERSONEL_SSK_NO");
            this.Property(t => t.PERSONEL_CINSIYET).HasColumnName("PERSONEL_CINSIYET");
            this.Property(t => t.PERSONEL_KIMLIK_NO).HasColumnName("PERSONEL_KIMLIK_NO");
            this.Property(t => t.PERSONEL_DOGUM_TARIHI).HasColumnName("PERSONEL_DOGUM_TARIHI");
            this.Property(t => t.PERSONEL_DOGUM_YERI).HasColumnName("PERSONEL_DOGUM_YERI");
            this.Property(t => t.PERSONEL_EGITIM_DURUMU).HasColumnName("PERSONEL_EGITIM_DURUMU");
            this.Property(t => t.PERSONEL_ACIKLAMA).HasColumnName("PERSONEL_ACIKLAMA");
            this.Property(t => t.PERSONEL_AYAKKABI_NO).HasColumnName("PERSONEL_AYAKKABI_NO");
            this.Property(t => t.PERSONEL_GOMLEK_NO).HasColumnName("PERSONEL_GOMLEK_NO");
            this.Property(t => t.PERSONEL_MONT_NO).HasColumnName("PERSONEL_MONT_NO");
            this.Property(t => t.PERSONEL_PANTOLON_NO).HasColumnName("PERSONEL_PANTOLON_NO");
            this.Property(t => t.YEDEK).HasColumnName("YEDEK");
        }
    }
}
