using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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
        public event PropertyChangedEventHandler PropertyChanged;
        static CancellationTokenSource cts = new CancellationTokenSource();
        CancellationToken ct;

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
        public void Metoda1() 
        {
           
            for (int i = 0; i < int.Parse(maxCislo.Text); i++)
            {
                
            }
        }
        public void Metoda2()
        {
            for (int i = 0; i < int.Parse(maxCislo.Text); i++)
            {

            }
        }
        public void Metoda3()
        {
            for (int i = 0; i < int.Parse(maxCislo.Text); i++)
            {

            }
        }

        private async void VybranoSefe_Click(object sender, RoutedEventArgs e)
        {
            if (Combobox.SelectedItem == "placeholder" && maxCislo.SelectedItem != null)
            {
                await Task.Run(() =>
                {
                    Metoda3();
                });
            }
            if (Combobox.SelectedItem == "placeholder1" && maxCislo.SelectedItem != null)
            {
                await Task.Run(() =>
                {
                    Metoda3();
                });
            }
            if (Combobox.SelectedItem == "placeholder2" && maxCislo.SelectedItem != null)
            {
                await Task.Run(() =>
                {
                    Metoda3();
                });
            }
            else
            {
                MessageBox.Show("Zapomnel jste vybrat jeden parametr", "Chyba", MessageBoxButton.OK);
            }
        }
    }
}
