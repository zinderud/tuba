 
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
  using AnaEkran.Views.AraSayfalar.Sirket;
  using ZindeMesajServisi.Messaging;

namespace AnaEkran.Views.Listele
{
    /// <summary>
    /// Interaction logic for TBL_SIRKET_SINIFDuzenleView.xaml
    /// </summary>
    public partial class TBL_SIRKET_SINIFDuzenleView : UserControl
    {
        public TBL_SIRKET_SINIFDuzenleView()
        {
            InitializeComponent();
            Messenger.Default.Register<EkleTBL_SIRKET_SINIFMesaj>(this, OnEkleTBL_SIRKET_SINIFMesaj);

        }

        private void OnEkleTBL_SIRKET_SINIFMesaj(EkleTBL_SIRKET_SINIFMesaj obj)
        {
            if (this.DataContext != null)
            {
                var Metodlar = this.DataContext.GetType().GetMethod("Listele");
                Metodlar.Invoke(this.DataContext, null);

            }
            MessageBox.Show(obj.mesaj);
        }

        public TBL_SIRKET_SINIFDuzenleView(double height)
        {
             InitializeComponent();
             Messenger.Default.Register<EkleTBL_SIRKET_SINIFMesaj>(this, OnEkleTBL_SIRKET_SINIFMesaj);

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
            SirketSinifEkleSayfasi sayfasi = new SirketSinifEkleSayfasi();
            sayfasi.ShowDialog();
        }
    }
}




	 
      ///////////////////////////////////////////////////

	 
      ///////////////////////////////////////////////////



 

 ///////////////////////////////////////////////////

