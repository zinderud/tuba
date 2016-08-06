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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using AnaEkran.Views.Listele;

namespace AnaEkran.Views.Raporlar.Urun
{
    /// <summary>
    /// Interaction logic for UrunListeRaporSayfasi.xaml
    /// </summary>
    public partial class UrunListeRaporSayfasi : Window
    {
        public UrunListeRaporSayfasi()
        {
            InitializeComponent();
        }
        private void FixedDocument_Loaded(object sender, RoutedEventArgs e)
        {
            FixedDocument fixedDocument = sender as FixedDocument;

            UrunListesiView myUserControl = new UrunListesiView();
            myUserControl.HorizontalAlignment = HorizontalAlignment.Center;
            myUserControl.VerticalAlignment = VerticalAlignment.Center;
           
            var sil3 = myUserControl.datadene.Columns.Count.ToString();
            var sil4 = myUserControl.Height;
            Grid grid = new Grid();
            grid.Children.Add(myUserControl);
            var sil1 = grid.ActualHeight;
            var sil2 = grid.Height;
            //var sil3=grid.
            FixedPage fixedPage = new FixedPage();
            fixedPage.Children.Add(grid);

            Binding widthBinding = new Binding("ActualWidth");
            widthBinding.Source = fixedPage;
            Binding heightBinding = new Binding("ActualHeight");
            heightBinding.Source = fixedPage;
            grid.SetBinding(Grid.WidthProperty, widthBinding);
            grid.SetBinding(Grid.HeightProperty, heightBinding);

            PageContent pageContent = new PageContent();
            (pageContent as IAddChild).AddChild(fixedPage);

            fixedDocument.Pages.Add(pageContent);
        }
        public void Connect(int connectionId, object target)
        {
             
        }
    }
}
