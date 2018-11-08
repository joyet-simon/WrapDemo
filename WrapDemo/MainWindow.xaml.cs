using Microsoft.Win32;
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
            Image newImage = new Image();
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == true) { newImage.Source = new BitmapImage(new Uri(of.FileName)); }
            newImage.Margin = new Thickness(10, 10, 10, 10);
            newImage.Height = 100;
            wrap.Children.Add(newImage);
        }
    }
}
