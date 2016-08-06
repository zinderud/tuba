using System.Collections.ObjectModel;
using SimpleMvvmToolkit;

namespace AnaEkran.Models
{
    public class Durumlar : ModelBase<Durumlar>

    {
         public Durumlar()
        {
            
            
        }
      private string _durumlar;
        public string Durum
        {
            get { return _durumlar; }
            set
            {
                _durumlar = value;
                NotifyPropertyChanged(m => m.Durum);

             }
        }
    }
    public  class DurumListesi : ModelBase<DurumListesi>
    {
        ObservableCollection<Durumlar> durum = new ObservableCollection<Durumlar>();
        public DurumListesi()
        {
            Durumlar dr = new Durumlar();
            dr.Durum = "EVET";
            durum.Add(dr);
            Durumlar dr1 = new Durumlar();
            dr1.Durum = "HAYIR";
            durum.Add(dr1);
            DurumcObservableCollection = durum;
        }
        private ObservableCollection<Durumlar> _durumlar;
        public ObservableCollection<Durumlar> DurumcObservableCollection
        {
            get { return _durumlar; }
            set
            {
                _durumlar = value;
                NotifyPropertyChanged(m => m.DurumcObservableCollection);

            }
        }
    }

}