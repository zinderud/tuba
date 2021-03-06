 
  using System;
using System.Collections.Generic;
using System.Linq;
  using System.Reflection;
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
  using AnaEkran.Views.AraSayfalar.Fatura;
  using ZindeMesajServisi.Messaging;
  using MessageBox = System.Windows.Forms.MessageBox;

namespace AnaEkran.Views.Listele
{
    /// <summary>
    /// Interaction logic for TBL_FATURA_TURUDuzenleView.xaml
    /// </summary>
    public partial class TBL_FATURA_TURUDuzenleView : UserControl
    {
        public TBL_FATURA_TURUDuzenleView()
        {
            InitializeComponent();
            Messenger.Default.Register<EkleTBL_FATURA_TURUMesaj>(this, OnEkleTBL_FATURA_TURUMesaj);
        }

        public TBL_FATURA_TURUDuzenleView(double height)
        {
             InitializeComponent();
            var anim = new AnimationHelper();
            anim.UserControlDropDownAnim(this, height);
            Messenger.Default.Register<EkleTBL_FATURA_TURUMesaj>(this, OnEkleTBL_FATURA_TURUMesaj);

         }

        private void OnEkleTBL_FATURA_TURUMesaj(EkleTBL_FATURA_TURUMesaj obj)
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
            FaturaTuruEkleSayfasi sayfasi = new FaturaTuruEkleSayfasi();
            sayfasi.ShowDialog();
        }
    }
}




	 
      ///////////////////////////////////////////////////

	 
      ///////////////////////////////////////////////////

	 
      ///////////////////////////////////////////////////



 

 ///////////////////////////////////////////////////

