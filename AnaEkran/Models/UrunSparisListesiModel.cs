using System;
using SimpleMvvmToolkit;

namespace AnaEkran.Models
{
    public class UrunSparisListesiModel : ModelBase<UrunSparisListesiModel>
    {
        public bool Secim { get { return _secim; } set { if (!Equals(value, _secim)) { _secim = value; NotifyPropertyChanged(m => m.Secim); } } }
        private bool _secim;
    
        public int TBL_URUN_ID { get { return _tBL_URUN_ID; } set { if (!Equals(value, _tBL_URUN_ID)) { _tBL_URUN_ID = value; NotifyPropertyChanged(m => m.TBL_URUN_ID); } } }
        private int _tBL_URUN_ID;
        public string Adet { get { return _Adet; } set { if (!Equals(value, _Adet)) { _Adet = value; NotifyPropertyChanged(m => m.Adet); } } }
        private string _Adet="1";

        public string URUN_ADI { get { return _uRUN_ADI; } set { if (!Equals(value, _uRUN_ADI)) { _uRUN_ADI = value; NotifyPropertyChanged(m => m.URUN_ADI); } } }
        private string _uRUN_ADI;


        public string URUN_KODU { get { return _uRUN_KODU; } set { if (!Equals(value, _uRUN_KODU)) { _uRUN_KODU = value; NotifyPropertyChanged(m => m.URUN_KODU); } } }
        private string _uRUN_KODU;
        public Nullable<int> TBL_KDV_ID { get { return _tBL_KDV_ID; } set { if (!Equals(value, _tBL_KDV_ID)) { _tBL_KDV_ID = value; NotifyPropertyChanged(m => m.TBL_KDV_ID); } } }
        private Nullable<int> _tBL_KDV_ID=0;

        public string URUN_SATIS_FIYATI { get { return _uRUN_SATIS_FIYATI; } set { if (!Equals(value, _uRUN_SATIS_FIYATI)) { _uRUN_SATIS_FIYATI = value; NotifyPropertyChanged(m => m.URUN_SATIS_FIYATI); } } }
        private string _uRUN_SATIS_FIYATI;
        public string ToplamFiyat { get { return _toplamFiyet; } set { if (!Equals(value, _toplamFiyet)) { _toplamFiyet = value; NotifyPropertyChanged(m => m.ToplamFiyat); } } }
        private string _toplamFiyet;


    
    
    }
}