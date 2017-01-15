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

namespace Cukiernia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Przepis przepisy = new Przepis();
        private int ileSkladnikow;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void wyjscieB_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void dodajPrzepisB_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
               
                string przepis = "";
                int czas = 0;
                przepis = nazwaPrzepisu.Text;
                czas = Convert.ToInt32(czasPrzepisu.Text);               
                if (przepis == "")
                    throw new ArgumentNullException();
                if (czas < 0 || czas > 300)
                    throw new ArgumentOutOfRangeException();

                przepisy.UstawNazweICzas(przepis, czas);
                info_box.Text = "Przepis: \nNazwa przepisu:" + przepis + ", Czas przyg. w min." + czas;               
                GridNowyP.Visibility = Visibility.Hidden;
                GridDodajS.Visibility = Visibility.Visible;
            }
            catch (ArgumentNullException mes)
            {
                MessageBox.Show(mes.Message);
            }
            catch(ArgumentOutOfRangeException mes)
            {
                MessageBox.Show(mes.Message);
            }
            catch (Exception mes)
            {
                MessageBox.Show(mes.Message);
            }
        }

        private void nowyPrzepisB_Click(object sender, RoutedEventArgs e)
        {
            ileSkladnikow = 0;
            GridNowyP.Visibility = Visibility.Visible;
            dostawaB.Visibility = Visibility.Hidden;
            GridDostawa.Visibility = Visibility.Hidden;
            GridDodajS.Visibility = Visibility.Hidden;
            inffo_box.Text = "";
            info_box.Text = "";
            nazwaPrzepisu.Text = "";
            czasPrzepisu.Text = "";


        }

        private void dodajSkladnikB_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nazwa="";
                string ilosc="";
                double cena=0;
                nazwa = nazwaSklBox.Text;
                ilosc = iloscSklBox.Text;
                cena = Convert.ToDouble(cenaSklBox.Text);
                if (nazwa == "" || ilosc=="")
                    throw new ArgumentNullException();
                if (cena<=0)
                    throw new ArgumentOutOfRangeException();
                ileSkladnikow += 1;
                if (ileSkladnikow >= 3)
                    dostawaB.Visibility = Visibility.Visible;

                przepisy.DodajSkladnik(nazwa, ilosc, cena);
                inffo_box.Text =przepisy.ToString();
                nazwaSklBox.Text = "";
                iloscSklBox.Text = "";
                cenaSklBox.Text = "";

            }
            catch (ArgumentNullException mes)
            {
                MessageBox.Show(mes.Message);
            }
            catch (ArgumentOutOfRangeException mes)
            {
                MessageBox.Show(mes.Message);
            }
            catch (Exception mes)
            {
                MessageBox.Show(mes.Message);
            }
            
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dostawaB_Click(object sender, RoutedEventArgs e)
        {
            GridDostawa.Visibility = Visibility.Visible;
            GridDodajS.Visibility = Visibility.Hidden;
        }

        private void Sprawdz_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (comboBox.SelectedIndex == -1) throw new ArgumentNullException();
                NaWynos sprawdz = new NaWynos();
                DateTime data = Convert.ToDateTime(godzina.Text);
                String.Format("HHmm", data);
                sprawdz.UstawCzasDostawy(data);
                if (sprawdz.PoprawnyCzas())
                    MessageBox.Show("Dostępne!", "Info:");
                else
                    MessageBox.Show("Niemozliwe", "Info");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
