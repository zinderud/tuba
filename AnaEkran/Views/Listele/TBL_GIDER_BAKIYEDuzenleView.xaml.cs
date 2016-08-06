 
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
  using AnaEkran.Models;
  using AnaEkran.Views.AraSayfalar.Gider;
  using ZindeMesajServisi.Messaging;
  using MessageBox = System.Windows.Forms.MessageBox;

namespace AnaEkran.Views.Listele
{
    /// <summary>
    /// Interaction logic for TBL_GIDER_BAKIYEDuzenleView.xaml
    /// </summary>
    public partial class TBL_GIDER_BAKIYEDuzenleView : UserControl
    {
        public TBL_GIDER_BAKIYEDuzenleView()
        {
            InitializeComponent();
            Messenger.Default.Register<EkleTBL_GIDER_BAKIYEMesaj>(this, OnEkleTBL_GIDER_BAKIYEMesaj);

        }

        private void OnEkleTBL_GIDER_BAKIYEMesaj(EkleTBL_GIDER_BAKIYEMesaj obj)
        {
            TBL_KASA_BAKIYE_MODEL model = new TBL_KASA_BAKIYE_MODEL();
            if (obj.MesajTBL_GIDER_BAKIYE != null)
            {
                model.TBL_KASA_ID = Convert.ToInt32(obj.MesajTBL_GIDER_BAKIYE.KUR);
                model.TUTAR = obj.MesajTBL_GIDER_BAKIYE.TUTAR;
            
                model.TARIH = obj.MesajTBL_GIDER_BAKIYE.TARIH;
                model.ACIKLAMA = "Gider bakiye Ekleme Kýsmýndan iþlem yapýldý.  "+obj.MesajTBL_GIDER_BAKIYE.ACIKLAMA;
                model.TBL_PARA_TIPI_ID = obj.MesajTBL_GIDER_BAKIYE.TBL_PARA_TIPI_ID;
                


            }
            if (this.DataContext != null)
            {
                var Metodlar = this.DataContext.GetType().GetMethod("Listele");
                Metodlar.Invoke(this.DataContext, null);
                var deposotkekle = this.DataContext.GetType().GetMethod("GiderKasaEkle");
                deposotkekle.Invoke(this.DataContext, new object[] { model });


            }
            MessageBox.Show(obj.mesaj);      
        }

        public TBL_GIDER_BAKIYEDuzenleView(double height)
        {
             InitializeComponent();
             Messenger.Default.Register<EkleTBL_GIDER_BAKIYEMesaj>(this, OnEkleTBL_GIDER_BAKIYEMesaj);

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
            GiderBakiyeEkleSayfasi sayfasi = new GiderBakiyeEkleSayfasi();
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

	 
      ///////////////////////////////////////////////////

	 
      ///////////////////////////////////////////////////



 

 ///////////////////////////////////////////////////

