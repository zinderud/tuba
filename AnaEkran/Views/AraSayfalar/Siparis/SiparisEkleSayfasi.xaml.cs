using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using AnaEkran.Annotations;
using AnaEkran.Mesaj;
using AnaEkran.Models;
using ZindeMesajServisi.Messaging;
using Zinderud.Windows.Controls;

namespace AnaEkran.Views.AraSayfalar.Siparis
{
    /// <summary>
    /// Interaction logic for SiparisEkleSayfasi.xaml
    /// </summary>
    public partial class SiparisEkleSayfasi : Window, INotifyPropertyChanged
    {
        public SiparisEkleSayfasi()
        {
            InitializeComponent();
            //Messenger.Default.Register<EkleTBL_SPARISMesaj>(this, OnEkleTBL_SPARISMesaj);

        }
        private void OnEkleTBL_SPARISMesaj(EkleTBL_SPARISMesaj obj)
        {
            //if (this.DataContext != null)
            //{

            //    var Metodlar = this.DataContext.GetType().GetMethod("SiparisUrunTablosunaKayit");
            //    Metodlar.Invoke(this.DataContext, null);

            //}
            //MessageBox.Show(obj.mesaj);
        }
        public void Connect(int connectionId, object target)
        {

        }

        //private ObservableCollection<UrunSparisListesiModel> _secilenurunObservableCollection;
        //public ObservableCollection<UrunSparisListesiModel> SecilenUrunObservableCollection
        //{
        //    get { return _secilenurunObservableCollection; }
        //    set
        //    {
        //        _secilenurunObservableCollection = value;
        //        OnPropertyChanged("SecilenUrunObservableCollection");
        //    }
        //}

        //ObservableCollection<UrunSparisListesiModel> modeldene = new ObservableCollection<UrunSparisListesiModel>();
        private void Btnekle_OnClick(object sender, RoutedEventArgs e)
        {
            //modeldene =   TBL_URUNDTODataGrid.SelectedItems;

            //SecilenUrunObservableCollection = modeldene;
        }



        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }


 

        private async void SiparisEkleSayfasi_OnLoaded(object sender, RoutedEventArgs e)
        {
            //_urunListesiObservableCollection=

         }

        private void SioRangeBase_OnValueChanged(object sender, SioRangeBaseValueChangedEventArgs e)
        {
            if (this.DataContext != null)
            {

                var Metodlar = this.DataContext.GetType().GetMethod("SecilenDegisikligiKoleksiyonaUygula");
                Metodlar.Invoke(this.DataContext, null);
                var Metodlar1 = this.DataContext.GetType().GetMethod("EklemeHazirUrunSiparisListesiniyenile");
                Metodlar1.Invoke(this.DataContext, null);

            }
        }
    }
}
