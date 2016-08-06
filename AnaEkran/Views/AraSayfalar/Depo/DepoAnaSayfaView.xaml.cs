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

namespace AnaEkran.Views.AraSayfalar.Depo
{
    /// <summary>
    /// Interaction logic for DepoAnaSayfaView.xaml
    /// </summary>
    public partial class DepoAnaSayfaView : UserControl
    {
        public DepoAnaSayfaView()
        {
            InitializeComponent();
        }

        public void Connect(int connectionId, object target)
        {
        }
        public DepoAnaSayfaView(double height)
        {
             InitializeComponent();
            var anim = new AnimationHelper();
            anim.UserControlDropDownAnim(this, height);
        }

       

       
      
    }
}
