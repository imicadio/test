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

namespace Train
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Pociag pociag = new Pociag();
        bool czy_lokomotywa = false;
        bool czy_wagon = false;
        public MainWindow()
        {
            InitializeComponent();
            LMasa.Visibility = Visibility.Hidden;
            LModel.Visibility = Visibility.Hidden;
            LTyp.Visibility = Visibility.Hidden;
            Typ.Visibility = Visibility.Hidden;
            TModel.Visibility = Visibility.Hidden;
            TMasa.Visibility = Visibility.Hidden;
            LRodz.Visibility = Visibility.Hidden;
            Dodaj.Visibility = Visibility.Hidden;
            TRodzLad.Visibility = Visibility.Hidden;
            
        }

        private void DLok_Click(object sender, RoutedEventArgs e)
        {
            LMasa.Visibility = Visibility.Visible;
            LModel.Visibility = Visibility.Visible;
            TModel.Visibility = Visibility.Visible;
            TModel.Text = "";
            TMasa.Text = "";
            TMasa.Visibility = Visibility.Visible;
            Dodaj.Visibility = Visibility.Visible;
            LRodz.Visibility = Visibility.Hidden;
            Typ.Visibility = Visibility.Hidden;
            LTyp.Visibility = Visibility.Hidden;
            TRodzLad.Visibility = Visibility.Hidden;
            czy_wagon = false;
            czy_lokomotywa = true;
        }

        private void DWag_Click(object sender, RoutedEventArgs e)
        {
            LMasa.Visibility = Visibility.Visible;
            LModel.Visibility = Visibility.Visible;
            LTyp.Visibility = Visibility.Visible;
            Typ.Visibility = Visibility.Visible;
            TModel.Visibility = Visibility.Visible;
            TMasa.Text = "";
            TModel.Text = "";
            TRodzLad.Text = "";
            TMasa.Visibility = Visibility.Visible;
            LRodz.Visibility = Visibility.Visible;
            Dodaj.Visibility = Visibility.Visible;
            TRodzLad.Visibility = Visibility.Visible;
            czy_lokomotywa = false;
            czy_wagon = true;
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            bool jest_liczba = true;
            string dane = TMasa.Text;

            try
            {
                int liczba_ok = int.Parse(dane);
                if (liczba_ok <=0) throw new ArgumentOutOfRangeException();
                
            }
            catch
            {
                MessageBox.Show("Podaj liczbe dodatnia");
                jest_liczba = false;
            }

            if (jest_liczba)
            {
                if (czy_lokomotywa)
                {
                    int m = int.Parse(TMasa.Text);
                    pociag.DodajLokomotywe(m, TModel.Text);
                }


                if (czy_wagon)
                {
                    int m = int.Parse(TMasa.Text);
                    if (Typ.Text == "Osobowy")
                    {
                        pociag.DodajOsobowy(m, TModel.Text, TRodzLad.Text);
                    }
                    if (Typ.Text == "Towarowy")
                    {
                        pociag.DodajTowarowy(m, TModel.Text, TRodzLad.Text);
                    }
                }
            }
            TZaw.Text = pociag.Informacje();
        }

        private void SPop_Click(object sender, RoutedEventArgs e)
        {
            if (pociag.MozeJechac() == true)
            {
                Poprawnosc.Text = "Moze jechac";
            }
            else Poprawnosc.Text = "Nie moze jechac";
        }

    }
}
