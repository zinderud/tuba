using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;
using AnaEkran.ViewModels;

namespace AnaEkran.Views.AraSayfalar.Kasa
{
    /// <summary>
    /// Interaction logic for KasaEkleSayfasiView.xaml
    /// </summary>
    public partial class KasaEkleSayfasiView : Window
    {
        public KasaEkleSayfasiView()
        {
            InitializeComponent();
        }

        public void Connect(int connectionId, object target)
        {
        }

        private void KasaEkleSayfasiView_OnClosing(object sender, CancelEventArgs e)
        {this.Dispatcher.Invoke(() =>
        {
             
            //this.DataContext.GetType().GetMethod("Listele").Invoke(null, null);
        })
            ;
            
        }
    }
}
