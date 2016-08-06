using System;
using System.Collections.Generic;
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
using AnaEkran.Helpers;
using AnaEkran.Mesaj;
using AnaEkran.Views.AraSayfalar.Siparis;
using ZindeMesajServisi.Messaging;

namespace AnaEkran.Views.Bolumler.Satis
{
    /// <summary>
    /// Interaction logic for BolumSiparisDuzenleView.xaml
    /// </summary>
    public partial class BolumSiparisDuzenleView : UserControl
    {
           public BolumSiparisDuzenleView()
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

        public BolumSiparisDuzenleView(double height)
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

 
    }
}
