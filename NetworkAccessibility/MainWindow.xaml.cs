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
        List<string> address = new List<string>();
        PING _ping, _ping002;
        public MainWindow()
        {
            InitializeComponent();
            _ping = new PING(FirstAddress.Text);
            //_ping002 = new PING(SecondAddress.Text);
        }
        private List<string> AddAddress()
        {
            if (FirstAddress.Text != "")
            {
                address.Add(FirstAddress.Text);
            }

            if (SecondAddress.Text != "")
            {
                address.Add(SecondAddress.Text);
            }

            if (ThirdAddress.Text != "")
            {
                address.Add(ThirdAddress.Text);
            }

            if (FourthAddress.Text != "")
            {
                address.Add(FourthAddress.Text);
            }

            if (FifthAddress.Text != "")
            {
                address.Add(FifthAddress.Text);
            }

            if (SixthAddress.Text != "")
            {
                address.Add(SixthAddress.Text);
            }
            return address;
        }

        private void ShowRes_Click(object sender, RoutedEventArgs e)
        {
           

            if (_ping.ShowAnswer(FirstAddress.Text))
            {
                
                FirstRect.Fill = Brushes.Green;
            }
            else
            {
                
                FirstRect.Fill = Brushes.Red;
            }

            //if (_ping.ShowAnswer(SecondAddress.Text))
            //{
            //    SecondRect.Fill = Brushes.Green;
            //}
            //else
            //{
            //    SecondRect.Fill = Brushes.Red;
            //}

            //if (_ping.ShowAnswer(AddAddress()))
            //{
            //    ThirdRect.Fill = Brushes.Green;
            //}
            //else
            //{
            //    ThirdRect.Fill = Brushes.Red;
            //}

            //if (_ping.ShowAnswer(AddAddress()))
            //{
            //    FourthRect.Fill = Brushes.Green;
            //}
            //else
            //{
            //    FourthRect.Fill = Brushes.Red;
            //}

            //if (_ping.ShowAnswer(AddAddress()))
            //{
            //    FifthRect.Fill = Brushes.Green;
            //}
            //else
            //{
            //    FifthRect.Fill = Brushes.Red;
            //}

            //if (_ping.ShowAnswer(AddAddress()))
            //{
            //    SixthRect.Fill = Brushes.Green;
            //}
            //else
            //{
            //    SixthRect.Fill = Brushes.Red;
            //}
        }
    }
}

