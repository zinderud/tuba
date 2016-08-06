 
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

namespace AnaEkran.Views.Listele
{
    /// <summary>
    /// Interaction logic for TBL_SPARIS_TURUDuzenleView.xaml
    /// </summary>
    public partial class TBL_SPARIS_TURUDuzenleView : UserControl
    {
        public TBL_SPARIS_TURUDuzenleView()
        {
            InitializeComponent();
            Messenger.Default.Register<EkleTBL_SPARIS_TURUMesaj>(this, OnEkleTBL_SPARIS_TURUMesaj);

        }

        private void OnEkleTBL_SPARIS_TURUMesaj(EkleTBL_SPARIS_TURUMesaj obj)
        {
            if (this.DataContext != null)
            {
                var Metodlar = this.DataContext.GetType().GetMethod("Listele");
                Metodlar.Invoke(this.DataContext, null);

            }
            MessageBox.Show(obj.mesaj);
        }

        public TBL_SPARIS_TURUDuzenleView(double height)
        {
             InitializeComponent();
             Messenger.Default.Register<EkleTBL_SPARIS_TURUMesaj>(this, OnEkleTBL_SPARIS_TURUMesaj);

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
            SiparisTuruEkleSayfasi sayfasi = new SiparisTuruEkleSayfasi();
            sayfasi.ShowDialog();
        }
    }
}




	 
      ///////////////////////////////////////////////////

	 
      ///////////////////////////////////////////////////

	 
      ///////////////////////////////////////////////////



 

 ///////////////////////////////////////////////////

