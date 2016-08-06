 
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
  using AnaEkran.Views.AraSayfalar.ParaTipi;
  using ZindeMesajServisi.Messaging;

namespace AnaEkran.Views.Listele
{
    /// <summary>
    /// Interaction logic for TBL_PARA_TIPIDuzenleView.xaml
    /// </summary>
    public partial class TBL_PARA_TIPIDuzenleView : UserControl
    {
        public TBL_PARA_TIPIDuzenleView()
        {
            InitializeComponent();
            Messenger.Default.Register<EkleTBL_PARA_TIPIMesaj>(this, OnEkleTBL_PARA_TIPIMesaj);

        }

        private void OnEkleTBL_PARA_TIPIMesaj(EkleTBL_PARA_TIPIMesaj obj)
        {
            if (this.DataContext != null)
            {
                var Metodlar = this.DataContext.GetType().GetMethod("Listele");
                Metodlar.Invoke(this.DataContext, null);

            }
            MessageBox.Show(obj.mesaj);
        }

        public TBL_PARA_TIPIDuzenleView(double height)
        {
             InitializeComponent();
             Messenger.Default.Register<EkleTBL_PARA_TIPIMesaj>(this, OnEkleTBL_PARA_TIPIMesaj);

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
            ParaTipiEkleSayfasi sayfasi = new ParaTipiEkleSayfasi();
            sayfasi.ShowDialog();
        }
    }
}




	 
      ///////////////////////////////////////////////////

	 
      ///////////////////////////////////////////////////



 

 ///////////////////////////////////////////////////

