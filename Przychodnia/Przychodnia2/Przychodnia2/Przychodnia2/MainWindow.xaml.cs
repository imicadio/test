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

namespace Przychodnia2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Przychodnia przychodnia = new Przychodnia();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void dodaj_doLekarza_Click(object sender, RoutedEventArgs e)
        {
            string imie, choroba;
            int wiek;
            imie = imie_pacjenta.Text;
            choroba = choroba_pacjenta.Text;
            wiek = Convert.ToInt32(wiek_pacjenta.Text);
            przychodnia.ZapiszDoLekarza(imie, wiek, choroba);
            wyswietl_info.Text= przychodnia.ToString();
            imie_pacjenta.Text = "";
            choroba_pacjenta.Text = "";
            wiek_pacjenta.Text = "";
        }

        private void dodaj_lek_Click(object sender, RoutedEventArgs e)
        {
            string imie, specjalnosc;
            try
            {
                imie = imieBox.Text;
                specjalnosc = specjalnoscBox.Text;
                if (imie == "" || specjalnosc == "")
                    throw new ArgumentNullException();
            }
            catch (ArgumentNullException mes)
            {
                MessageBox.Show(mes.Message);
            }


            GridUstawLekarza.Visibility = Visibility.Hidden;
            GridPrzyciski.Visibility = Visibility.Visible;
            przychodnia.UstawLekarz(imieBox.Text, specjalnoscBox.Text);
            wyswietl_info.Text = przychodnia.ToString();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            GridUstawLekarza.Visibility = Visibility.Visible;
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            GridZapiszDo.Visibility = Visibility.Visible;
            GridUstawLekarza.Visibility = Visibility.Hidden;
        }

        private void wykonaj_porade_Click(object sender, RoutedEventArgs e)
        {
            GridZapiszDo.Visibility = Visibility.Hidden;
            MessageBox.Show(przychodnia.WykonajPorade(),"Info");
            wyswietl_info.Text = przychodnia.ToString();
        }

        private void wykonaj_badanie_Click(object sender, RoutedEventArgs e)
        {
            GridZapiszDo.Visibility = Visibility.Hidden;
            MessageBox.Show(przychodnia.WykonajBadanie(),"Info");
        }

        private void generuj_raport_Click(object sender, RoutedEventArgs e)
        {
            przychodnia.GenerujRaport();
            MessageBox.Show("Zakonczono generowanie raportu","Wynik:");
        }
    }
}
