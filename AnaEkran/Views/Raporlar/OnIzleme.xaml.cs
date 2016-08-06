using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Xps.Packaging;

namespace AnaEkran.Views.Raporlar
{
    /// <summary>
    /// Interaction logic for OnIzleme.xaml
    /// </summary>
    public partial class OnIzleme : Window
    {
        public OnIzleme()
        {
            InitializeComponent();
            InitializeComponent();
            //Burada ana penceremiz bu pencereyi çağırdığında hemen oluşturulmuş belgeyi görüntülüyoruz.
            //Okunacak xps belgesini oluşturuyor ve hangi dosyayı oluşturacağımızı belirliyoruz.
            XpsDocument okunacakBelge = new XpsDocument(@"D:\Temp\onizleme.xps", FileAccess.Read);
            XpsOkuyucu.Document = okunacakBelge.GetFixedDocumentSequence();
        }

        public void Connect(int connectionId, object target)
        {
             
        }
    }
}
