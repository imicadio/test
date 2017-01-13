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

namespace kasa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Koszyk koszyk = new Koszyk();

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            gridDodaj.Visibility = Visibility.Visible;
            usuun.Visibility = Visibility.Hidden;
        }

        private void Wyjscie_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double cena;
                cena = Convert.ToInt32(textCena.Text);
                double ilosc;
                ilosc = Convert.ToInt32(textWaga.Text);
                if(cena <=0 && ilosc <= 0)
                    throw new ArgumentOutOfRangeException(); // sprawdza czy masa dodatnia 

                koszyk.DodajProdukt(textNazwa.Text, cena, ilosc);
                teksty.Text = koszyk.PodajZawartosc();
            }

            catch
            {
                MessageBox.Show("Sprawdź poprawność wprowadzonych danych");
            }
        }

        private void Skopiuj_Click(object sender, RoutedEventArgs e)
        {
            gridDodaj.Visibility = Visibility.Hidden;
            usuun.Visibility = Visibility.Hidden;
            koszyk.SkopiujOstatni();
            teksty.Text = koszyk.PodajZawartosc();
        }

        private void Skasuj_Click(object sender, RoutedEventArgs e)
        {
            gridDodaj.Visibility = Visibility.Hidden;
            usuun.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int nrPozycji = Convert.ToInt32(NrPozycji.Text);
                if (nrPozycji <= 0) throw new ArgumentOutOfRangeException();
                koszyk.Skasuj(nrPozycji);
                teksty.Text = koszyk.PodajZawartosc();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Wydrukuj_Click(object sender, RoutedEventArgs e)
        {
            koszyk.Wydrukuj();
            teksty.Text = koszyk.PodajZawartosc();
        }

        private void Wyczysc_Click(object sender, RoutedEventArgs e)
        {
            koszyk.Wyczysc();
            teksty.Text = koszyk.PodajZawartosc();
        }
    }
}