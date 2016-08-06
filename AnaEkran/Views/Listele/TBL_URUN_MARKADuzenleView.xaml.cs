 
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
  using AnaEkran.Views.AraSayfalar.Urun;
  using ZindeMesajServisi.Messaging;

namespace AnaEkran.Views.Listele
{
    /// <summary>
    /// Interaction logic for TBL_URUN_MARKADuzenleView.xaml
    /// </summary>
    public partial class TBL_URUN_MARKADuzenleView : UserControl
    {
        public TBL_URUN_MARKADuzenleView()
        {
            InitializeComponent();
            Messenger.Default.Register<EkleTBL_URUN_MARKAMesaj>(this, OnEkleTBL_URUN_MARKAMesaj);

         }

        public TBL_URUN_MARKADuzenleView(double height)
        {
             InitializeComponent();
             Messenger.Default.Register<EkleTBL_URUN_MARKAMesaj>(this, OnEkleTBL_URUN_MARKAMesaj);

            var anim = new AnimationHelper();
            anim.UserControlDropDownAnim(this, height);
         }

        private void OnEkleTBL_URUN_MARKAMesaj(EkleTBL_URUN_MARKAMesaj obj)
        {
            if (this.DataContext != null)
            {
                var Metodlar = this.DataContext.GetType().GetMethod("Listele");
                Metodlar.Invoke(this.DataContext, null);

            }
            MessageBox.Show(obj.mesaj);
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
 
        }

        public void Connect(int connectionId, object target)
        {
        }
        private void BtnEklemeButton_OnClick(object sender, RoutedEventArgs e)
        {
            UrunMarkaEkleSayfasi sayfasi = new UrunMarkaEkleSayfasi();
            sayfasi.ShowDialog();
        }
    }
}




	 
      ///////////////////////////////////////////////////

	 
      ///////////////////////////////////////////////////

	 
      ///////////////////////////////////////////////////

	 
      ///////////////////////////////////////////////////

	 
      ///////////////////////////////////////////////////



 

 ///////////////////////////////////////////////////

