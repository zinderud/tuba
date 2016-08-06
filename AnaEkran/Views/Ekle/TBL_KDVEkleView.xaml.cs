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

namespace AnaEkran.Views.Ekle
{
    /// <summary>
    /// Interaction logic for TBL_KDVEkleView.xaml
    /// </summary>
    public partial class TBL_KDVEkleView : UserControl
    {
        public TBL_KDVEkleView()
        {
            InitializeComponent();
        }
         private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }
         public TBL_KDVEkleView(double height)
        {
             InitializeComponent();
            var anim = new AnimationHelper();
            anim.UserControlDropDownAnim(this, height);
         }

       
        public void Connect(int connectionId, object target)
        {
        }
    }
}
