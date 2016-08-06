using System.Collections.ObjectModel;
using SimpleMvvmToolkit;

namespace AnaEkran.Models
{
    public class PersonelYetki: ModelBase<PersonelYetki>

    {
        public PersonelYetki()
        {
            
            
        }
        private string _PersonelYetkisi;
        public string PersonelYetkisi
        {
            get { return _PersonelYetkisi; }
            set
            {
                _PersonelYetkisi = value;
                NotifyPropertyChanged(m => m.PersonelYetkisi);

             }
        }
    }
    public  class PersonelYetkisiListesi : ModelBase<PersonelYetkisiListesi>
    {
        ObservableCollection<PersonelYetki> yetki = new ObservableCollection<PersonelYetki>();
        public PersonelYetkisiListesi()
        {
            PersonelYetki dr = new PersonelYetki();
            dr.PersonelYetkisi = "ADMİN YETKİLİSİ";
            yetki.Add(dr);

            PersonelYetki dr1 = new PersonelYetki();
            dr1.PersonelYetkisi = "SATIŞ YETKİLİSİ";
            yetki.Add(dr1);

            PersonelYetki dr2 = new PersonelYetki();
            dr2.PersonelYetkisi = "DEPO YETKİLİSİ";
            yetki.Add(dr2);

            PersonelYetki dr3 = new PersonelYetki();
            dr3.PersonelYetkisi = "PAZARLAMA YETKİLİSİ";
            yetki.Add(dr3);
         

            PersonelYetkiObservableCollection = yetki;
        }
        private ObservableCollection<PersonelYetki> _durumlar;
        public ObservableCollection<PersonelYetki> PersonelYetkiObservableCollection
        {
            get { return _durumlar; }
            set
            {
                _durumlar = value;
                NotifyPropertyChanged(m => m.PersonelYetkiObservableCollection);

            }
        }
    }

}