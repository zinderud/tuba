 
  using System;
using System.Collections.Generic;
  using System.IO;
  using System.IO.Packaging;
  using System.Linq;
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
  using AnaEkran.Helpers;
  using AnaEkran.Mesaj;
  using AnaEkran.Views.AraSayfalar.Siparis;
  using AnaEkran.Views.Raporlar;
  using ZindeMesajServisi.Messaging;

namespace AnaEkran.Views.Listele
{
    /// <summary>
    /// Interaction logic for TBL_SPARISDuzenleView.xaml
    /// </summary>
    public partial class TBL_SPARISDuzenleView : UserControl
    {
        public TBL_SPARISDuzenleView()
        {
            InitializeComponent();
            Messenger.Default.Register<EkleTBL_SPARISMesaj>(this, OnEkleTBL_SPARISMesaj);

        }

        private void OnEkleTBL_SPARISMesaj(EkleTBL_SPARISMesaj obj)
        {
            if (this.DataContext != null)
            {
                var Metodlar = this.DataContext.GetType().GetMethod("Listele");
                Metodlar.Invoke(this.DataContext, null);
                //var Metodlar1 = this.DataContext.GetType().GetMethod("SiparisUrunTablosunaKayit");
                // Metodlar1.Invoke(this.DataContext, null);
            }
            MessageBox.Show(obj.mesaj);
        }

        public TBL_SPARISDuzenleView(double height)
        {
             InitializeComponent();
            var anim = new AnimationHelper();
            anim.UserControlDropDownAnim(this, height);
         }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
 
        }

        public void Connect(int connectionId, object target)
        {
        }
        private void BtnEklemeButton_OnClick(object sender, RoutedEventArgs e)
        {
            SiparisEkleSayfasi sayfasi = new SiparisEkleSayfasi();
            sayfasi.ShowDialog();
        }


        //Önizleme oluþturuyoruz.
        private void btnOnizleme_Click(object sender, RoutedEventArgs e)
        {
            //Package sýnýfýndan bir nesne oluþturuyoruz ve bu nesneye kayýt yerini ve ne yapacaðýný belirtiyoruz.
            Package onizlemeBilgiler = Package.Open(@"D:\Temp\onizleme.xps", FileMode.Create);

            //Xps dosyasý oluþturuyoruz ve gerekli bilgileri oluþturduðumuz Package nesnesinden alýyoruz.
            XpsDocument onizleme = new XpsDocument(onizlemeBilgiler);

            //Xps yazýcýsý oluþturuyoruz ve hangi dökümaný baz alacaðýný (onizleme) belirtiyoruz
            XpsDocumentWriter xpsYazici = XpsDocument.CreateXpsDocumentWriter(onizleme);

            //anaAlan adlý grid nesnemizi baz almasýný ve bu nesne içerisinde olan her þeyi yazdýrmasýný istiyoruz.
            xpsYazici.Write(anaAlan);

            //Artýk iþimiz bitti ve package nesnemizle dökümanýmýzý kapatmamýz lazým.
            onizleme.Close();
            onizlemeBilgiler.Close();

            /*Solution Explorer içerisinde bulunan önceden oluþturduðumuz OnIzleme adlý pencereden 
             * bir nesne oluþturuyoruz ve Show() metodu ile gösteriyoruz. */
            OnIzleme ac = new OnIzleme();
            ac.Show();
        }
    }
}




