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
using ZindeMesajServisi.Messaging;

namespace AnaEkran.Views.AraSayfalar.Kasa
{
    /// <summary>
    /// Interaction logic for KasaAnaSayfaView.xaml
    /// </summary>
    public partial class KasaAnaSayfaView : UserControl
    {
        public KasaAnaSayfaView()
        {
            InitializeComponent();
        }
        public KasaAnaSayfaView(double height)
        {
             InitializeComponent();
            var anim = new AnimationHelper();
            anim.UserControlDropDownAnim(this, height);
            Messenger.Default.Register<EkleTBL_KASAMesaj>(this, OnEkleTBL_KASAMesaj);
            Messenger.Default.Register<EkleTBL_KASA_BAKIYEMesaj>(this, OnEkleTBL_KASA_BAKIYEMesaj);
        }

        private void OnEkleTBL_KASA_BAKIYEMesaj(EkleTBL_KASA_BAKIYEMesaj obj)
        {
            MessageBox.Show(obj.mesaj);
        }

        private void OnEkleTBL_KASAMesaj(EkleTBL_KASAMesaj obj)
        {
            MessageBox.Show(obj.mesaj); 
        }

        public void Connect(int connectionId, object target)
        {
        }
    }
}
