using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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

namespace NetworkAccessibility
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        PING _ping;
        public MainWindow()
        {
            InitializeComponent();
            _ping = new PING();
        }
        private List<string> AddAddress()
        {
            List<string> address = new List<string>(); // Создаётся при каждом вызове метода, чтобы обнулялся

            address.Add(FirstAddress.Text);
            address.Add(SecondAddress.Text);
            address.Add(ThirdAddress.Text);
            address.Add(FourthAddress.Text);
            address.Add(FifthAddress.Text);
            address.Add(SixthAddress.Text);

            return address;
        }

        private void ShowRes_Click(object sender, RoutedEventArgs e)
        {
            List<string> addres = AddAddress();
            Rectangle[] rects = { FirstRect, SecondRect, ThirdRect, FourthRect, FifthRect, SixthRect };
            for (int i = 0; i < addres.Count; i++)
            {
                if (addres[i] == "")
                {
                    rects[i].Fill = Brushes.White;
                    continue;
                }
                if (_ping.ShowAnswer(addres[i]))
                {
                    rects[i].Fill = Brushes.Green;
                }
                else
                {
                    rects[i].Fill = Brushes.Red;
                }
            }
        }
    }
}

