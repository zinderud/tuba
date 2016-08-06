using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using WPFModel.BusinessModelObjects;
using System.Printing;

namespace Zinderud
{
    public class ReportManager : Window
    {

        
        public ReportManager(ObservableCollection<TblAletModel> liste, string resimAdi, string baslik, string setiDuzenleyen)
        {

            this.WindowState=WindowState.Maximized;

            // Ana grid
            Grid mainGrid = new Grid();
            mainGrid.HorizontalAlignment = HorizontalAlignment.Stretch;
            mainGrid.VerticalAlignment = VerticalAlignment.Stretch;
            mainGrid.ShowGridLines = false;
            // Satırları oluştur
            RowDefinition gridRow1 = new RowDefinition { Height = GridLength.Auto };
            RowDefinition gridRow2 = new RowDefinition { Height = new GridLength(1, GridUnitType.Star) };
            mainGrid.RowDefinitions.Add(gridRow1);
            mainGrid.RowDefinitions.Add(gridRow2);

            #region Ust kısım
            // Üstteki grid
            Grid topGrid = new Grid();
            topGrid.ShowGridLines = true;
            topGrid.MinHeight = 50;
            // Sütunlar
            ColumnDefinition topGridCol = new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) };
            ColumnDefinition topGridCol2 = new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) };
            ColumnDefinition topGridCol3 = new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) };
            topGrid.ColumnDefinitions.Add(topGridCol);
            topGrid.ColumnDefinitions.Add(topGridCol2);
            topGrid.ColumnDefinitions.Add(topGridCol3);


            // bilgilerin gösterileceği grid ( kullanıcı adı, tarih vs...)
            Grid reportGrid = new Grid();
            reportGrid.HorizontalAlignment = HorizontalAlignment.Stretch;
            reportGrid.VerticalAlignment = VerticalAlignment.Stretch;
         
            // Satır ve sütunların tanımı
            RowDefinition row1 = new RowDefinition();
            RowDefinition row2 = new RowDefinition();
            RowDefinition row3 = new RowDefinition();
            reportGrid.RowDefinitions.Add(row1);
            reportGrid.RowDefinitions.Add(row2);
            reportGrid.RowDefinitions.Add(row3);
            ColumnDefinition col1 = new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) };
            ColumnDefinition col2 = new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) };
            reportGrid.ColumnDefinitions.Add(col1);
            reportGrid.ColumnDefinitions.Add(col2);
           
            // Bileşenleri oluştur
            TextBlock editor = CreateTextBlock("Seti Düzenleyen :", new SolidColorBrush(Colors.Black), 16, new Thickness(0));
            TextBlock editorName = CreateTextBlock(setiDuzenleyen, new SolidColorBrush(Colors.Black), 16, new Thickness(10, 0, 0, 0));
            TextBlock date = CreateTextBlock("Tarih / Saat :", new SolidColorBrush(Colors.Black), 16, new Thickness(0));
            TextBlock curDate = CreateTextBlock(DateTime.Now.ToString(), new SolidColorBrush(Colors.Black), 16, new Thickness(10, 0, 0, 0));
            TextBlock sign = CreateTextBlock("Imza :", new SolidColorBrush(Colors.Black), 16, new Thickness(0));
           
            // Bileşenlerin grid üzerindeki konumları
            Grid.SetRow(editor, 0);
            Grid.SetColumn(editor, 0);
            Grid.SetRow(editorName, 0);
            Grid.SetColumn(editorName, 1);
            Grid.SetRow(date, 1);
            Grid.SetColumn(date, 0);
            Grid.SetRow(curDate, 1);
            Grid.SetColumn(curDate, 1);
            Grid.SetRow(sign, 2);
            Grid.SetColumn(sign, 0);
          
            // Bileşenleri gride ekle
            reportGrid.Children.Add(editor);
            reportGrid.Children.Add(editorName);
            reportGrid.Children.Add(date);
            reportGrid.Children.Add(curDate);
            reportGrid.Children.Add(sign);
          
            // Üst kısmı tamamla
            Border border = new Border
            {
                BorderThickness = new Thickness(3),
                BorderBrush = new SolidColorBrush(Colors.Black),
                CornerRadius = new CornerRadius(10),
                Margin = new Thickness(5, 50, 5, 10),
            };
            StackPanel panel = new StackPanel { Orientation=Orientation.Horizontal,};
            Image myImage = ImageLoader(resimAdi);
            panel.Children.Add(myImage);
            myImage.HorizontalAlignment = HorizontalAlignment.Center;
            TextBlock tBlock = CreateTextBlock(baslik, new SolidColorBrush(Colors.Green), 20, new Thickness(40, 0, 40, 0));
            Grid.SetColumn(tBlock, 0);
            topGrid.Children.Add(tBlock);
            tBlock.HorizontalAlignment = HorizontalAlignment.Center;
            tBlock.VerticalAlignment = VerticalAlignment.Center;
            Grid.SetColumn(reportGrid, 1);
            topGrid.Children.Add(reportGrid);
            reportGrid.Margin = new Thickness(40, 0, 40, 0);
            reportGrid.HorizontalAlignment = HorizontalAlignment.Center;
            reportGrid.VerticalAlignment = VerticalAlignment.Center;   
            Button btn= new Button{ Content="Yazdır"};
            Grid.SetColumn(btn, 2);
            btn.MinWidth = 100;
            topGrid.Children.Add(btn);
            panel.Children.Add(topGrid);
            //topGrid.HorizontalAlignment = HorizontalAlignment.Right;
            border.Child = panel;
            var tgrid = new Grid();
            tgrid.Children.Add(border);
            Grid.SetRow(tgrid, 0);
            mainGrid.Children.Add(tgrid);
            #endregion

            #region Alt kısım

            // Alt kısımdaki border
            Border gridBorder = new Border
            {
                BorderThickness = new Thickness(3),
                BorderBrush = new SolidColorBrush(Colors.Black),
                CornerRadius = new CornerRadius(10),
                Margin = new Thickness(5, 10, 5, 10),
            };

            DataGrid dGrid = new DataGrid();
                dGrid.Margin = new Thickness(0);
                dGrid.Background = new SolidColorBrush(Colors.White);
                Grid bottomGrid = new Grid();
                bottomGrid.HorizontalAlignment = HorizontalAlignment.Stretch;
                bottomGrid.VerticalAlignment = VerticalAlignment.Stretch;
                int count = 0;
                int total = 0;
             dGrid.ItemsSource = liste;
                // Malzeme sayısına göre sütun sayısını belirliyorum
                // Amacım alet listesini sayfaya sığdırmak
                if (dGrid.Items.Count-1 > 0 && dGrid.Items.Count < 41) { count = 1 ; }
                else if (dGrid.Items.Count-1 >= 41 && dGrid.Items.Count < 81) { count = 2; }
                else if (dGrid.Items.Count-1 >= 81 && dGrid.Items.Count < 121) { count = 3; }
                else if (dGrid.Items.Count-1 >= 121 && dGrid.Items.Count < 161) { count = 4; }
                else if (dGrid.Items.Count - 1 >= 161 && dGrid.Items.Count < 201) { count = 5; }
                else if (dGrid.Items.Count - 1 >= 201 && dGrid.Items.Count < 241) { count = 6; }
                // Alet sayısına gore sutun oluştur
                for (int i = 0; i < count; i++)
                {
                    bottomGrid.ColumnDefinitions.Add(new ColumnDefinition {Width = new GridLength(1,GridUnitType.Star)});
                    DataGrid temp = new DataGrid 
                    { 
                        CanUserAddRows=false,
                        Background = new SolidColorBrush(Colors.White)
                    };

                    Type type = dGrid.Items.GetItemAt(0).GetType();

                    #region Temiz Alan

                    if (type.Name == "TblAletModel") 
                    {
                        var list = new ObservableCollection<RaporModel>();
                        RaporModel report = null;

                        for (int j = total; j < total + 40; j++)
                        {
                            if (j == dGrid.Items.Count - 1) { break; }
                            var item = dGrid.Items.GetItemAt(j) as TblAletModel;
                            report = new RaporModel();
                            report.Aletler = item.AletAdi;
                            report.Onay = item.AletCheck;                        
                            list.Add(report);
                        }

                        temp.ItemsSource = list;
                        Grid.SetColumn(temp, i);
                        bottomGrid.Children.Add(temp);
                        total += 40;
                    }

                    #endregion
                }
             
                //bottomGrid.Children.Add(dGrid);
                gridBorder.Child = bottomGrid;
                var bgrid = new Grid();
                bgrid.Children.Add(gridBorder);
                Grid.SetRow(bgrid, 1);
                mainGrid.Children.Add(bgrid);
                          
            #endregion  

            //mainGrid.Children.Add(border);

                btn.PreviewMouseLeftButtonDown += (sender, args) => btn_MouseLeftButtonDown(bgrid);
            this.Content = mainGrid;
            this.ShowDialog();     
 
        }

        void btn_MouseLeftButtonDown(Grid grid)
        {

            PrintDialog printDlg = new System.Windows.Controls.PrintDialog();

            if (printDlg.ShowDialog() == true)
            {
                //get selected printer capabilities
                PrintCapabilities capabilities = printDlg.PrintQueue.GetPrintCapabilities(printDlg.PrintTicket);

                //get scale of the print wrt to screen of WPF visual
                double scale = Math.Min(capabilities.PageImageableArea.ExtentWidth / this.ActualWidth, capabilities.PageImageableArea.ExtentHeight /
                                this.ActualHeight);

                //Transform the Visual to scale
               // this.LayoutTransform = new ScaleTransform(scale, scale);
                grid.LayoutTransform = new ScaleTransform(scale , scale);
                //get the size of the printer page
                Size sz = new Size(capabilities.PageImageableArea.ExtentWidth, capabilities.PageImageableArea.ExtentHeight);

                //update the layout of the visual to the printer page size.
                //this.Measure(sz);
                //this.Arrange(new Rect(new Point(capabilities.PageImageableArea.OriginWidth, capabilities.PageImageableArea.OriginHeight), sz));
                grid.Measure(sz);
                grid.Arrange(new Rect(new Point(capabilities.PageImageableArea.OriginWidth, capabilities.PageImageableArea.OriginHeight), sz));

                //now print the visual to printer to fit on the one page.
              printDlg.PrintVisual(this, "First Fit to Page WPF Print");

            }
         
        }

        /// <summary>
        /// Kullanıcdan yüklenecek resmin adını alır.
        /// Girilen isim hangi dizinde ise onu ekranda görüntüler.
        /// (Bu kullanım /Resources/Images klasoru var sayılarak yapılmıştır!!)
        /// </summary>
        /// <param name="imageName"></param>
        /// <returns></returns>
        private Image ImageLoader(string imageName)
        {
            string currentDirectory = Environment.CurrentDirectory.ToString();
            string directory = currentDirectory.Replace("bin\\Debug", "Resources\\Images\\");
            directory = directory + imageName;
            Image myImage = new Image();
            BitmapImage myBitmapImage = new BitmapImage();
            myBitmapImage.BeginInit();
            myBitmapImage.UriSource = new Uri(directory);
            myBitmapImage.EndInit();
            myImage.Source = myBitmapImage;
            return myImage;
        }

        /// <summary>
        /// Kullanıcıdan texti, text rengini ve font büyüklüğü bilgilerini 
        /// alarak istenilen textboxı geri döndürür.
        /// </summary>
        /// <returns></returns>
        private TextBlock CreateTextBlock(string info, SolidColorBrush brush, double fontSize, Thickness margin)
        {
            return new TextBlock
            {
                Text = info,
                Foreground = brush,
                FontSize = fontSize,
                Margin = margin,
                VerticalAlignment = VerticalAlignment.Center
            };
        }
    }
}
