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
using AnaEkran.Views.AraSayfalar.Fatura;
using ZindeMesajServisi.Messaging;

namespace AnaEkran.Views.Bolumler.Satis
{
    /// <summary>
    /// Interaction logic for BolumFaturaEkleView.xaml
    /// </summary>
    public partial class BolumFaturaEkleView : UserControl
    {
     public BolumFaturaEkleView()
        {
            InitializeComponent();
            Messenger.Default.Register<EkleTBL_FATURAMesaj>(this, OnEkleTBL_FATURAMesaj);

        }

        private void OnEkleTBL_FATURAMesaj(EkleTBL_FATURAMesaj obj)
        {
            if (this.DataContext != null)
            {
                var Metodlar = this.DataContext.GetType().GetMethod("Listele");
                Metodlar.Invoke(this.DataContext, null);

            }
            MessageBox.Show(obj.mesaj);
        }

        public BolumFaturaEkleView(double height)
        {
             InitializeComponent();
             Messenger.Default.Register<EkleTBL_FATURAMesaj>(this, OnEkleTBL_FATURAMesaj);

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
            FaturaEkleSayfasi sayfasi = new FaturaEkleSayfasi();
            sayfasi.ShowDialog();
        }
    }
}
