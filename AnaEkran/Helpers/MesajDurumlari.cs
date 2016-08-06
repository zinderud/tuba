#region ONUR KARADENİZ
// murat onur  Sio
// Görüntü   MesajDurumlari.cs
// 2013022814:40
// 2013  02
// 28 28
#endregion

using AnaEkran.Models;
using AnaEkran.ViewModels;
using SimpleMvvmToolkit;
using ZindeMesajServisi.Messaging;

namespace AnaEkran.Helpers
{
    public static partial class MesajDurumlari
    {
        public static readonly string BankaAnasayfa = "BankaAnasayfa";
        public static readonly string DepoAnasayfa = "DepoAnasayfa";
        public static readonly string FaturaAnasayfa = "FaturaAnasayfa";
        public static readonly string FisAnasayfa = "FisAnasayfa";
        public static readonly string GiderAnasayfa = "GiderAnasayfa";
        public static readonly string KasaAnasayfa = "KasaAnasayfa";
        public static readonly string OdemeAnasayfa = "OdemeAnasayfa";
        public static readonly string ParaTipiAnasayfa = "ParaTipiAnasayfa";
        public static readonly string PersonelAnasayfa = "PersonelAnasayfa";
        public static readonly string SiparisAnasayfa = "SiparisAnasayfa";
        public static readonly string SirketAnasayfa = "SirketAnasayfa";
        public static readonly string UrunAnasayfa = "UrunAnasayfa";
        public static readonly string AnaGoruntu = "AnaGoruntu";


      

        public static readonly string KullaniciGirisBasarili = "KullaniciGirisBasarili";
        public static readonly string AramenuAcilsin = "AramenuAcilsin";
        public static readonly string AramenuKapansin = "AramenuKapansin";
        public static readonly string AramenuTekAcil = "AramenuTekAcil";
        public static readonly string GirisEkraniSifirla = "GirisEkraniSifirla";
        public static readonly string KullaniciEkle = "KullaniciEkle";
       
        public static readonly string BankaEkle = "BankaEkle";

        public static readonly string BankaDuzenle = "BankaDuzenle";

        public static readonly string BankaBakiyeEkle = "BankaBakiyeEkle";

        public static readonly string BankaBakiyelistele = "BankaBakiyelistele";


        //Bolumdepo
        public static readonly string BolumDepoIslem = "BolumDepoIslem";

        public static readonly string BolumDepoTransfer = "BolumDepoTransfer";
        public static readonly string BolumSiparisDuzenle = "BolumSiparisDuzenle";
        public static readonly string BolumFaturaEkle = "BolumFaturaEkle";
    }
    public class KullaniciGirisMesaj
    {
        public TBL_PERSONEL_MODEL MesajTblPersonel { get; set; }
        public string Mesaj { get; set; }
    }
    public class StringMessage : MesajBase
    {
        public string Message { get; set; }

        public StringMessage()
        {
            Sender = "StringMessage";
        }
    }

    public class Gorunurluk : ViewModelBase<Gorunurluk>
    {
        private string _kirliVisibility;
        public string KirliVisibility
        {
            get { return _kirliVisibility; }
            set
            {
                _kirliVisibility = value;
                NotifyPropertyChanged(m => m.KirliVisibility);
            }
        }
        private string _temizVisibility;
        public string TemizVisibility
        {
            get { return _temizVisibility; }
            set
            {
                _temizVisibility = value;
                NotifyPropertyChanged(m => m.TemizVisibility);
            }
        }
        private string _depoVisibility;
        public string DepoVisibility
        {
            get { return _depoVisibility; }
            set
            {
                _depoVisibility = value;
                NotifyPropertyChanged(m => m.DepoVisibility);
            }
        }
        private string _destekVisibility;
        public string DestekVisibility
        {
            get { return _destekVisibility; }
            set
            {
                _destekVisibility = value;
                NotifyPropertyChanged(m => m.DestekVisibility);
            }
        }
        private string _yoneticiVisibility;
        public string YoneticiVisibility
        {
            get { return _yoneticiVisibility; }
            set
            {
                _yoneticiVisibility = value;
                NotifyPropertyChanged(m => m.YoneticiVisibility);
            }
        }
        private string _KullaniciGirisVisibility = "Collapsed";
        public string KullaniciGirisVisibility
        {
            get { return _KullaniciGirisVisibility; }
            set
            {
                _KullaniciGirisVisibility = value;
                NotifyPropertyChanged(m => m.KullaniciGirisVisibility);
            }
        }
        private string _aramenuVisibility = "Visible";
        public string AraMenuVisibility
        {
            get { return _aramenuVisibility; }
            set
            {
                _aramenuVisibility = value;
                NotifyPropertyChanged(m => m.AraMenuVisibility);
            }
        }

    }
}