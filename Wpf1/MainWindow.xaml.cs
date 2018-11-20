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

namespace Wpf1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //MyButton.Visibility = Visibility.Hidden;
            //MyButton.MouseDoubleClick += MyButton_MouseDoubleClick;
        }

        private void MyButton_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("הנני כאן!",
                "MY BOX",
                MessageBoxButton.OKCancel,
                MessageBoxImage.Exclamation,
                MessageBoxResult.Cancel,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            if (result == MessageBoxResult.OK)
                MyButton.Content = "די לחפור";

            e.
            //MyButton.Content = "שלום וברכה";
            //MyButton.Visibility = Visibility.Hidden;
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            MyButton.Content = "שלום וברכה";
        }

        static private Random random = new Random(DateTime.Now.Millisecond);

        private void MyButton_MouseMove(object sender, MouseEventArgs e)
        {
            //Button btn = sender as Button;
            //Size size = (btn.Parent as Grid).RenderSize;
            //Thickness margin = btn.Margin;
            //margin.Left = random.NextDouble() * (size.Width - btn.ActualWidth);
            //margin.Top = random.NextDouble() * (size.Height - btn.ActualHeight);
            //btn.Margin = margin;
        }
    }
}
