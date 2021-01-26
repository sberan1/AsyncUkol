using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
        
        static CancellationTokenSource cts;
        CancellationToken ct;
        public virtual bool[] MakeSieve(int max)
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

            Combobox.Items.Add("prvocisla obsahujici 7");
            Combobox.Items.Add("prvocisla koncici 4");
            Combobox.Items.Add("prvocisla obsahujici prvni dve 1");

        }
        

        private async void VybranoSefe_Click(object sender, RoutedEventArgs e)
        {
            int max = int.Parse(maxCislo.SelectedItem.ToString());
            if (Combobox.SelectedItem.ToString() == "prvocisla obsahujici 7" && maxCislo.SelectedItem != null)
            {
                cts = new CancellationTokenSource();
                ct = cts.Token;

                await Task.Run(() =>
                {
                    List<int> prvocislaHodnoty = new List<int>();
                    bool[] prvocisla = new bool[max + 1];
                    this.Dispatcher.Invoke(() =>
                    {
                    Listbox.Items.Add("prvocisla obsahujici 7                                       Working on it");
                    });
                for (int i = 2; i <= max; i++) prvocisla[i] = true;

                    for (int i = 2; i <= max; i++)
                    {
                        if (prvocisla[i])
                        {
                            for (int j = i * 2; j <= max; j += i)
                                prvocisla[j] = false;
                        }
                    }
                    for (int i = 0; i < max; i++)
                    {
                        if (prvocisla[i] == true)
                        {
                            prvocislaHodnoty.Add(i);
                        }
                    }

                    prvocislaHodnoty.ForEach(delegate (int name)
                    {
                        string strName = name.ToString();


                        if (strName.Contains('7'))
                        {
                            using StreamWriter writer = new StreamWriter(@"C:\Temp\vysledkyma7.txt");
                            writer.Write(name);
                        }
                    });
                    this.Dispatcher.Invoke(() =>
                    {
                    int a = Listbox.Items.IndexOf("prvocisla obsahujici 7                                       Working on it");
                    Listbox.Items.RemoveAt(a);
                    Listbox.Items.Insert(a, "prvocisla obsahujici 7                                       Hotovo");
                    });
                    cts.Cancel();
                });
            }
            if (Combobox.SelectedItem.ToString() == "prvocisla obsahujici prvni dve 1" && maxCislo.SelectedItem != null)
            {
                cts = new CancellationTokenSource();
                ct = cts.Token;
                this.Dispatcher.Invoke(() =>
                {
                    Listbox.Items.Add("prvocisla obsahujici prvni dve 1                                       Working on it");
                });
                await Task.Run(() =>
                {
                    List<int> prvocislaHodnoty = new List<int>();
                    bool[] prvocisla = new bool[max + 1];
                    for (int i = 2; i <= max; i++) prvocisla[i] = true;

                    for (int i = 2; i <= max; i++)
                    {
                        if (prvocisla[i])
                        {
                            for (int j = i * 2; j <= max; j += i)
                                prvocisla[j] = false;
                        }
                    }
                    for (int i = 0; i < max; i++)
                    {
                        if (prvocisla[i] == true)
                        {
                            prvocislaHodnoty.Add(i);
                        }
                    }
                    prvocislaHodnoty.ForEach(delegate (int name)
                    {
                        string strName = name.ToString();
                        int[] digits = strName.Where(char.IsNumber)
                        .Select(c => int.Parse(c.ToString()))
                        .ToArray();

                        if (digits[0] == 1 && digits[1] == 1)
                        {
                            using StreamWriter writer = new StreamWriter(@"C:\Temp\vysledkydve1.txt");
                            writer.Write(name);
                        }
                    });
                    this.Dispatcher.Invoke(() =>
                    {
                    int a = Listbox.Items.IndexOf("prvocisla obsahujici prvni dve 1                                       Working on it"); 
                    Listbox.Items.RemoveAt(a); 
                    Listbox.Items.Insert(a, "prvocisla obsahujici prvni dve 1                                       Hotovo");
                });
                cts.Cancel();
                });
            }
            if (Combobox.SelectedItem.ToString() == "prvocisla koncici 4" && maxCislo.SelectedItem != null)
            {
                cts = new CancellationTokenSource();
                ct = cts.Token;
                this.Dispatcher.Invoke(() =>
                {
                    Listbox.Items.Add("prvocisla koncici 4                                       Working on it");
                });
                await Task.Run(() =>
                {
                    List<int> prvocislaHodnoty = new List<int>();
                    bool[] prvocisla = new bool[max + 1];
                    for (int i = 2; i <= max; i++) prvocisla[i] = true;

                    for (int i = 2; i <= max; i++)
                    {
                        if (prvocisla[i])
                        {
                            for (int j = i * 2; j <= max; j += i)
                                prvocisla[j] = false;
                        }
                    }
                    for (int i = 0; i < max; i++)
                    {
                        if (prvocisla[i] == true)
                        {
                            prvocislaHodnoty.Add(i);
                        }
                    }
                    prvocislaHodnoty.ForEach(delegate (int name)
                    {
                        string strName = name.ToString();
                        int[] digits = strName.Where(char.IsNumber)
                        .Select(c => int.Parse(c.ToString()))
                        .ToArray();

                        if (digits[digits.Length - 1] == 4)
                        {
                            using StreamWriter writer = new StreamWriter(@"C:\Temp\vysledkykonec4.txt");
                            writer.Write(name);
                        }
                    });
                    this.Dispatcher.Invoke(() =>
                    {
                     
                    int a = Listbox.Items.IndexOf("prvocisla koncici 4                                       Working on it");
                    Listbox.Items.RemoveAt(a);
                    Listbox.Items.Insert(a, "prvocisla koncici 4                                       Hotovo");
                    });
                    cts.Cancel();
                });
            }
            else
            {
                MessageBox.Show("Zapomnel jste vybrat jeden parametr", "Chyba", MessageBoxButton.OK);
            }
        }
    }
}
