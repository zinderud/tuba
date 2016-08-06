using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Printing;

namespace Zinderud
{
    public class Barcode39 : Window
    {
        private int _WideNarrowRatio = 2;
        private Dictionary<string, byte[]> chars = new Dictionary<string, byte[]>();

        public int WideNarrowRatio
        {
            get { return _WideNarrowRatio; }
            set { _WideNarrowRatio = value; }
        }

        public Barcode39(string barkod, string malzemeAdi)
        {

            #region Karakterler

            chars.Add("1", new byte[] { 1, 0, 0, 1, 0, 0, 0, 0, 1 });
            chars.Add("2", new byte[] { 0, 0, 1, 1, 0, 0, 0, 0, 1 });
            chars.Add("3", new byte[] { 1, 0, 1, 1, 0, 0, 0, 0, 0 });
            chars.Add("4", new byte[] { 0, 0, 0, 1, 1, 0, 0, 0, 1 });
            chars.Add("5", new byte[] { 1, 0, 0, 1, 1, 0, 0, 0, 0 });
            chars.Add("6", new byte[] { 0, 0, 1, 1, 1, 0, 0, 0, 0 });
            chars.Add("7", new byte[] { 0, 0, 0, 1, 0, 0, 1, 0, 1 });
            chars.Add("8", new byte[] { 1, 0, 0, 1, 0, 0, 1, 0, 0 });
            chars.Add("9", new byte[] { 0, 0, 1, 1, 0, 0, 1, 0, 0 });
            chars.Add("0", new byte[] { 0, 0, 0, 1, 1, 0, 1, 0, 0 });
            chars.Add("A", new byte[] { 1, 0, 0, 0, 0, 1, 0, 0, 1 });
            chars.Add("B", new byte[] { 0, 0, 1, 0, 0, 1, 0, 0, 1 });
            chars.Add("C", new byte[] { 1, 0, 1, 0, 0, 1, 0, 0, 0 });
            chars.Add("D", new byte[] { 0, 0, 0, 0, 1, 1, 0, 0, 1 });
            chars.Add("E", new byte[] { 1, 0, 0, 0, 1, 1, 0, 0, 0 });
            chars.Add("F", new byte[] { 0, 0, 1, 0, 1, 1, 0, 0, 0 });
            chars.Add("G", new byte[] { 0, 0, 0, 0, 0, 1, 1, 0, 1 });
            chars.Add("H", new byte[] { 1, 0, 0, 0, 0, 1, 1, 0, 0 });
            chars.Add("I", new byte[] { 0, 0, 1, 0, 0, 1, 1, 0, 0 });
            chars.Add("J", new byte[] { 0, 0, 0, 0, 1, 1, 1, 0, 0 });
            chars.Add("K", new byte[] { 1, 0, 0, 0, 0, 0, 0, 1, 1 });
            chars.Add("L", new byte[] { 0, 0, 1, 0, 0, 0, 0, 1, 1 });
            chars.Add("M", new byte[] { 1, 0, 1, 0, 0, 0, 0, 1, 0 });
            chars.Add("N", new byte[] { 0, 0, 0, 0, 1, 0, 0, 1, 1 });
            chars.Add("O", new byte[] { 1, 0, 0, 0, 1, 0, 0, 1, 0 });
            chars.Add("P", new byte[] { 0, 0, 1, 0, 1, 0, 0, 1, 0 });
            chars.Add("Q", new byte[] { 0, 0, 0, 0, 0, 0, 1, 1, 1 });
            chars.Add("R", new byte[] { 1, 0, 0, 0, 0, 0, 1, 1, 0 });
            chars.Add("S", new byte[] { 0, 0, 1, 0, 0, 0, 1, 1, 0 });
            chars.Add("T", new byte[] { 0, 0, 0, 0, 1, 0, 1, 1, 0 });
            chars.Add("U", new byte[] { 1, 1, 0, 0, 0, 0, 0, 0, 1 });
            chars.Add("V", new byte[] { 0, 1, 1, 0, 0, 0, 0, 0, 1 });
            chars.Add("W", new byte[] { 1, 1, 1, 0, 0, 0, 0, 0, 0 });
            chars.Add("X", new byte[] { 0, 1, 0, 0, 1, 0, 0, 0, 1 });
            chars.Add("Y", new byte[] { 1, 1, 0, 0, 1, 0, 0, 0, 0 });
            chars.Add("Z", new byte[] { 0, 1, 1, 0, 1, 0, 0, 0, 0 });
            chars.Add("-", new byte[] { 0, 1, 0, 0, 0, 0, 1, 0, 1 });
            chars.Add(".", new byte[] { 1, 1, 0, 0, 0, 0, 1, 0, 0 });
            chars.Add(" ", new byte[] { 0, 1, 1, 0, 0, 0, 1, 0, 0 });
            chars.Add("*", new byte[] { 0, 1, 0, 0, 1, 0, 1, 0, 0 });
            chars.Add("$", new byte[] { 0, 1, 0, 1, 0, 1, 0, 0, 0 });
            chars.Add("/", new byte[] { 0, 1, 0, 1, 0, 0, 0, 1, 0 });
            chars.Add("+", new byte[] { 0, 1, 0, 0, 0, 1, 0, 1, 0 });
            chars.Add("%", new byte[] { 0, 0, 0, 1, 0, 1, 0, 1, 0 });

            #endregion

            #region UIElement tanımlamaları

            this.SizeToContent = SizeToContent.WidthAndHeight;
            this.Title = "Barkod";
            //this.MinHeight = 200;
            //this.MinWidth = 250;
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            //barkodu canvasın icine çiziyorum
            Canvas canvas = new Canvas();
            canvas.Width = 200;
            canvas.Height = 60;
            canvas.HorizontalAlignment = HorizontalAlignment.Left;
            canvas.VerticalAlignment = VerticalAlignment.Top;
            // canvas.Margin = new Thickness(20);
            canvas.Background = new SolidColorBrush(Colors.White);

            //barkod ile ilgili bilgileri stack panelde tutuyorum
            StackPanel mainPanel = new StackPanel();
            mainPanel.Orientation = Orientation.Vertical;
            mainPanel.Margin = new Thickness(20);
            StackPanel sp = new StackPanel();
            sp.Margin = new Thickness(0, 10, 0, 0);
            sp.Orientation = Orientation.Vertical;
            sp.HorizontalAlignment = HorizontalAlignment.Left;
            sp.Width = canvas.Width;
            TextBlock name = new TextBlock();
            TextBlock date = new TextBlock();
            name.Margin = new Thickness(0, 0, 0, 5);
            name.HorizontalAlignment = HorizontalAlignment.Left;
            date.Margin = new Thickness(0, 0, 0, 5);
            date.HorizontalAlignment = HorizontalAlignment.Left;
            Button printBtn = new Button();
            printBtn.Content = "Yazdır";
            printBtn.Margin = new Thickness(0, 0, 0, 5);
            printBtn.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(printBtn_PreviewMouseLeftButtonDown);
            printBtn.HorizontalAlignment = HorizontalAlignment.Left;
            printBtn.Padding = new Thickness(7, 2, 7, 2);
            #endregion

            #region Barkodu çizdir

            string text = barkod;
            if (!text.StartsWith("*"))
            {
                text = "*" + text;
            }
            if (!text.EndsWith("*"))
            {
                text = text + "*";
            }
            // insGraphics.FillRectangle(new SolidBrush(this.BackColor), 0, 0, this.Width, this.Height);

            int narrowCount = 0;
            int wideCount = 0;
            int blankCount = 0;
            for (int i = 0; i < text.Length; i++)
            {
                byte[] insByteArray = chars[text.Substring(i, 1)];
                foreach (byte insByte in insByteArray)
                {
                    if (insByte == 1)
                    {
                        wideCount++;
                    }
                    else
                    {
                        narrowCount++;
                    }
                }
                if (i + 1 != text.Length)
                {
                    blankCount++;
                }
            }
            decimal widthPerUnit = Math.Round(Convert.ToDecimal(canvas.Width) / Convert.ToDecimal(((wideCount * _WideNarrowRatio) + blankCount + narrowCount)), 2);
            decimal currentLeft = 0;
            for (int i = 0; i < text.Length; i++)
            {
                byte[] insByteArray = chars[text.Substring(i, 1)];
                int index = 0;
                foreach (byte insByte in insByteArray)
                {
                    if (index % 2 == 0)
                    {
                        // insGraphics.FillRectangle(new SolidBrush(this.ForeColor), (float)currentLeft, 0, (float)(insByte == 1 ? widthPerUnit * _WideNarrowRatio : widthPerUnit), this.Height);
                        Rectangle rectangle = new Rectangle();
                        canvas.Children.Add(rectangle);
                        rectangle.Margin = new Thickness((float)currentLeft, 0, 0, 0);
                        rectangle.Height = canvas.Height;
                        rectangle.Width = (float)(insByte == 1 ? widthPerUnit * _WideNarrowRatio : widthPerUnit);
                        rectangle.Fill = new SolidColorBrush(Colors.Black);
                    }
                    currentLeft += (insByte == 1 ? widthPerUnit * _WideNarrowRatio : widthPerUnit);

                    index++;
                }
                currentLeft += widthPerUnit;
            }

            #endregion

            //Bileşenleri pencereye ekliyorum
            name.Text = malzemeAdi;
            date.Text = DateTime.Now.ToString();
            sp.Children.Add(name);
            sp.Children.Add(date);
            sp.Children.Add(printBtn);
            mainPanel.Children.Add(canvas);
            mainPanel.Children.Add(sp);
            
            this.Content = mainPanel;
            this.Show();
        }

        void printBtn_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
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
                this.LayoutTransform = new ScaleTransform(scale, scale);
                //get the size of the printer page
                Size sz = new Size(capabilities.PageImageableArea.ExtentWidth, capabilities.PageImageableArea.ExtentHeight);

                //update the layout of the visual to the printer page size.
                this.Measure(sz);
                this.Arrange(new Rect(new Point(capabilities.PageImageableArea.OriginWidth, capabilities.PageImageableArea.OriginHeight), sz));

                //now print the visual to printer to fit on the one page.
                printDlg.PrintVisual(this, "First Fit to Page WPF Print");

            }
        }

    }
}
