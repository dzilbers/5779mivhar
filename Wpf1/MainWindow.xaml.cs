using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        private class MyList : IEnumerable<string>, INotifyCollectionChanged
        {
            public List<string> list = new List<string>();

            public event NotifyCollectionChangedEventHandler CollectionChanged;

            public IEnumerator<string> GetEnumerator()
            {
                return ((IEnumerable<string>)list).GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable<string>)list).GetEnumerator();
            }

            public void Add(string s)
            {
                list.Add(s);
                if (CollectionChanged != null)
                    CollectionChanged(this,
                        new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            }
        }

        public MainWindow()
        {
            InitializeComponent();
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
            //MyButton.Content = "שלום וברכה";
            //MyButton.Visibility = Visibility.Hidden;
        }

        private int counter = 0;
        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            MyButton.Content = "שלום וברכה";
            dropList.Add("More " + ++counter);
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

        public MyData MyOwner { get; set; } = new MyData() { User = "Avraham", Password = "123456" };
        private MyList dropList = new MyList();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //MyButton.Visibility = Visibility.Hidden;
            //MyButton.MouseDoubleClick += MyButton_MouseDoubleClick;
            MyGrid.DataContext = new MyData() { User = "Yossi", Password = "123456" };
            MyTxtBlock.DataContext = this;
            dropList.Add("First");
            dropList.Add("Second");
            MyCombo.ItemsSource = dropList;
        }
    }
}
