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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int c = 5;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = new Button
            {
                Margin = new Thickness(5),
                Height = 43,
                Width = 100,
                FontSize = 20,
                Content = (c++).ToString()

            };
            Sp.Children.Add(button);
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (Sp.Children.Count > 0)
            {
                Sp.Children.RemoveAt(Sp.Children.Count - 1);
            }
        }
    }
}

