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
using AnaEkran.Views.Ekle;
 
using ZindeMesajServisi.Messaging;
using MessageBox = System.Windows.Forms.MessageBox;

namespace AnaEkran.Views.AraSayfalar.Personel
{
    /// <summary>
    /// Interaction logic for PersonelAnasayfaView.xaml
    /// </summary>
    public partial class PersonelAnasayfaView : UserControl
    {
        public PersonelAnasayfaView()
        {
            InitializeComponent();
        }

        private void BtnEklemeButton_OnClick(object sender, RoutedEventArgs e)
        {
           PERSONELEkleView ekle = new PERSONELEkleView();
            ekle.ShowDialog();

        }

        public PersonelAnasayfaView(double height)
        {
             InitializeComponent();
            var anim = new AnimationHelper();
            anim.UserControlDropDownAnim(this, height);
            Messenger.Default.Register<EkleTBL_PERSONELMesaj>(this, OnEkleTBL_PERSONELMesaj);
        }

        private void OnEkleTBL_PERSONELMesaj(EkleTBL_PERSONELMesaj obj)
        {
            MessageBox.Show(obj.mesaj); 
        }
        public void Connect(int connectionId, object target)
        {
          
          
        }

       
    }
}
