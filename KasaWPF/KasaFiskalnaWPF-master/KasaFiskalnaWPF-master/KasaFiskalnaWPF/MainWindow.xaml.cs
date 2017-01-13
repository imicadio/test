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

namespace KasaFiskalnaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Koszyk koszyk = new Koszyk(); //pole  - dostęp do koszyka
        
        public MainWindow()
        {
            InitializeComponent();
            Ukryj();
        }

        public void Ukryj() //ukrycie wszystkich używanych paneli
        {
            PanelDodaj.Visibility = Visibility.Hidden;
            PanelSkasuj.Visibility = Visibility.Hidden;
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e) //odkrycie panelu na dodawanie produktów
        {
            Ukryj();
            PanelDodaj.Visibility = Visibility.Visible;
        }

        private void DodajProdukt_Click(object sender, RoutedEventArgs e) //dodanie produktu do zakupów
        {
            try
            {
                if (Nazwa.SelectedIndex == -1) throw new ArgumentNullException();
                double cenaJ= Convert.ToDouble(CenaJednostkowa.Text);
                if (cenaJ <= 0) throw new ArgumentOutOfRangeException();
                double ilosc = Convert.ToDouble(Ilosc.Text);
                if (ilosc <= 0) throw new ArgumentOutOfRangeException();
                koszyk.DodajProdukt(Nazwa.Text, cenaJ, ilosc);
                ZawartoscKoszyka.Text = koszyk.PodajZawartosc();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SkopiujOstatni_Click(object sender, RoutedEventArgs e) //skopiowanie ostatniego produktu na liście
        {
            Ukryj();
            koszyk.SkopiujOstatni();
            ZawartoscKoszyka.Text = koszyk.PodajZawartosc();

        }

        private void Skasuj_Click(object sender, RoutedEventArgs e) //odkrycie panelu do skasowania produktu
        {
            Ukryj();
            PanelSkasuj.Visibility = Visibility.Visible;
            
        }

        private void SkasujProdukt_Click(object sender, RoutedEventArgs e) //skasowanie produktu o pobranym indeksie
        {
            try
            {
                int nrPozycji = Convert.ToInt32(NrPozycji.Text);
                if (nrPozycji <= 0) throw new ArgumentOutOfRangeException();
                koszyk.Skasuj(nrPozycji);
                ZawartoscKoszyka.Text = koszyk.PodajZawartosc();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Wydrukuj_Click(object sender, RoutedEventArgs e) //wydrukowanie paragonu do pliku tekstowego
        {
            koszyk.Wydrukuj();
            ZawartoscKoszyka.Text = koszyk.PodajZawartosc();
        }

        private void Wyjscie_Click(object sender, RoutedEventArgs e) //wyjście z aplikacji
        {
            Environment.Exit(0);
        }

        private void Wyczysc_Click(object sender, RoutedEventArgs e) //wyczyszczenie listy zakupów
        {
            koszyk.Wyczysc();
            ZawartoscKoszyka.Text = koszyk.PodajZawartosc();
        }
    }
}
