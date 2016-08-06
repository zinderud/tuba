using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.IO.Packaging;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Xps;
using System.Windows.Xps.Packaging;
using AnaEkran.Annotations;
using AnaEkran.Views.Raporlar;

namespace AnaEkran.Views.Raporlar.Urun
{
    /// <summary>
    /// Interaction logic for UrunListesiView.xaml
    /// </summary>
    public partial class UrunListesiView : UserControl,INotifyPropertyChanged
    {
        public UrunListesiView()
        {
            InitializeComponent();
            doldur();
        }
        ObservableCollection<urundene> dene = new ObservableCollection<urundene>();

        public void doldur()
        {
            for (int i = 0; i < 1000; i++)
            {
                dene.Add(new urundene("urun"+i,"fiyat"+i));

            }
            Urundene = dene;

            datadene.ItemsSource = dene;
        }
        public void Connect(int connectionId, object target)
        {
             
        }

        public ObservableCollection<urundene> Urundene { get; set; }


        private ObservableCollection<urundene> myVar;

        
        
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
             
	
        }


        private void btnYazdir_Click(object sender, RoutedEventArgs e)
        {
            //Burada formuYazdir adında bir PrintDialog nesnesi oluşturuyorum.
            PrintDialog formuYazdir = new PrintDialog();

            //if ile Dialog penceresin gösterimi başarılı/gerçekleştiyse kontrol ediyorum.
            if (formuYazdir.ShowDialog() == true)
            {
                /* PrintVisual içerisine anaAlan adını verdiğimiz Grid nesnesini baz alıyoruz
                 * çıktı adını ise Form Çıktısı olmasını istiyoruz */
                formuYazdir.PrintVisual((anaAlan), "Form Çıktısı");
            }

            //PrintDialog'un açılamaması durumunda bir mesaj penceresi ve bir mesaj çıkarmasını istiyoruz.
            else
            {
                MessageBox.Show("Hiç seçim yapılmadı. Bilginize.");
            }

        }

        //Önizleme oluşturuyoruz.
        private void btnOnizleme_Click(object sender, RoutedEventArgs e)
        {
            //Package sınıfından bir nesne oluşturuyoruz ve bu nesneye kayıt yerini ve ne yapacağını belirtiyoruz.
            Package onizlemeBilgiler = Package.Open(@"D:\Temp\onizleme.xps", FileMode.Create);

            //Xps dosyası oluşturuyoruz ve gerekli bilgileri oluşturduğumuz Package nesnesinden alıyoruz.
            XpsDocument onizleme = new XpsDocument(onizlemeBilgiler);

            //Xps yazıcısı oluşturuyoruz ve hangi dökümanı baz alacağını (onizleme) belirtiyoruz
            XpsDocumentWriter xpsYazici = XpsDocument.CreateXpsDocumentWriter(onizleme);

            //anaAlan adlı grid nesnemizi baz almasını ve bu nesne içerisinde olan her şeyi yazdırmasını istiyoruz.
            xpsYazici.Write(anaAlan);

            //Artık işimiz bitti ve package nesnemizle dökümanımızı kapatmamız lazım.
            onizleme.Close();
            onizlemeBilgiler.Close();

            /*Solution Explorer içerisinde bulunan önceden oluşturduğumuz OnIzleme adlı pencereden 
             * bir nesne oluşturuyoruz ve Show() metodu ile gösteriyoruz. */
            OnIzleme ac = new OnIzleme();
            ac.Show();
        }

    }

    public class urundene
    {
        public string Urunadi { get; set; }
        public string Fiyati { get; set; }

        public urundene(string urunadi, string fiyati)
        {
            Urunadi = urunadi;
            Fiyati = fiyati;
        }
    }

   

}
