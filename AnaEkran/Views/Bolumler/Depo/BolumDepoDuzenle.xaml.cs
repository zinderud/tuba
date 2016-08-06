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
using AnaEkran.Views.AraSayfalar.Depo;
using ZindeMesajServisi.Messaging;

namespace AnaEkran.Views.Bolumler.Depo
{
    /// <summary>
    /// Interaction logic for BolumDepoDuzenle.xaml
    /// </summary>
    public partial class BolumDepoDuzenle : UserControl
    {
        public BolumDepoDuzenle()
        {
            InitializeComponent();
            Messenger.Default.Register<EkleTBL_DEPOMesaj>(this, OnEkleTBL_DEPOMesaj);

        }

        public BolumDepoDuzenle(double height)
        {
             InitializeComponent();
            var anim = new AnimationHelper();
            anim.UserControlDropDownAnim(this, height);
            Messenger.Default.Register<EkleTBL_DEPOMesaj>(this, OnEkleTBL_DEPOMesaj);

         }
        private void OnEkleTBL_DEPOMesaj(EkleTBL_DEPOMesaj obj)
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
        {DepoEkleSayfasi sayfasi=new DepoEkleSayfasi();
            sayfasi.ShowDialog();
        }
    }
}