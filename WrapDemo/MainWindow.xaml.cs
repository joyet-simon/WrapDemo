using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WrapDemo
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Random rand = new Random();
            Image newImage = new Image();
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == true) { newImage.Source = new BitmapImage(new Uri(of.FileName)); }
            newImage.Margin = new Thickness(10, 10, 10, 10);
            newImage.Height = 100;
            newImage.Width = 100;
            Int32 ranRot = (Int32)rand.Next(-45, 45);
            RotateTransform rt = new RotateTransform(ranRot);
            newImage.RenderTransform = rt;
            Int32 ranRotAbs = Math.Abs(ranRot);
            Canvas.SetTop(newImage, rand.Next(-ranRot + 10, (Int32)(canvas.Height - newImage.Height - ranRotAbs - 10)));
            Canvas.SetLeft(newImage, rand.Next(ranRot + 15, (Int32)(canvas.Width - newImage.Width - ranRotAbs - 50)));
            canvas.Children.Add(newImage);

        }
    }
}
