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

namespace AsyncUkol
{
    public partial class MainWindow : Window
    {
        private bool[] MakeSieve(int max)
        {
            bool[] is_prime = new bool[max + 1];
            for (int i = 2; i <= max; i++) is_prime[i] = true;

            for (int i = 2; i <= max; i++)
            {
                if (is_prime[i])
                {
                    for (int j = i * 2; j <= max; j += i)
                        is_prime[j] = false;
                }
            }
            return is_prime;
        }
        public MainWindow()
        {
            InitializeComponent();
            maxCislo.Items.Add("100");
            maxCislo.Items.Add("10000");
            maxCislo.Items.Add("1000000");
            maxCislo.Items.Add("100000000");
        }

        private void VybranoSefe_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
