using System;
using SimpleMvvmToolkit;

namespace AnaEkran.Models
{
    public class GrupToplamModel : ModelBase<GrupToplamModel>
    {
        private string _gruplanan;
        public string Gruplanan
        {
            get { return _gruplanan; }
            set
            {
                _gruplanan = value;
                NotifyPropertyChanged(m => m.Gruplanan);

             }
        }

        private string _Toplam;
        public string Toplam
        {
            get { return _Toplam; }
            set
            {
                _Toplam = value;
                NotifyPropertyChanged(m => m.Toplam);

            }
        }
    }
}