 
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


        //�nizleme olu�turuyoruz.
        private void btnOnizleme_Click(object sender, RoutedEventArgs e)
        {
            //Package s�n�f�ndan bir nesne olu�turuyoruz ve bu nesneye kay�t yerini ve ne yapaca��n� belirtiyoruz.
            Package onizlemeBilgiler = Package.Open(@"D:\Temp\onizleme.xps", FileMode.Create);

            //Xps dosyas� olu�turuyoruz ve gerekli bilgileri olu�turdu�umuz Package nesnesinden al�yoruz.
            XpsDocument onizleme = new XpsDocument(onizlemeBilgiler);

            //Xps yaz�c�s� olu�turuyoruz ve hangi d�k�man� baz alaca��n� (onizleme) belirtiyoruz
            XpsDocumentWriter xpsYazici = XpsDocument.CreateXpsDocumentWriter(onizleme);

            //anaAlan adl� grid nesnemizi baz almas�n� ve bu nesne i�erisinde olan her �eyi yazd�rmas�n� istiyoruz.
            xpsYazici.Write(anaAlan);

            //Art�k i�imiz bitti ve package nesnemizle d�k�man�m�z� kapatmam�z laz�m.
            onizleme.Close();
            onizlemeBilgiler.Close();

            /*Solution Explorer i�erisinde bulunan �nceden olu�turdu�umuz OnIzleme adl� pencereden 
             * bir nesne olu�turuyoruz ve Show() metodu ile g�steriyoruz. */
            OnIzleme ac = new OnIzleme();
            ac.Show();
        }
    }
}




