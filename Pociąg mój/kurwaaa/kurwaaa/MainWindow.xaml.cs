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

namespace kurwaaa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Ukryj();
        }

        private Pociag pociag = new Pociag();

        public void Ukryj()
        {
            PanelLokomotywa.Visibility = Visibility.Hidden;
            PanelWagon.Visibility = Visibility.Hidden;
        }

        private void DodLokomot_Click(object sender, RoutedEventArgs e)
        {
            PanelLokomotywa.Visibility = Visibility.Visible;
            PanelWagon.Visibility = Visibility.Hidden;
        }

        private void DodajL_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int masaLok;
                masaLok = Convert.ToInt32(MasaL.Text);
                if (masaLok <= 0)
                    throw new ArgumentOutOfRangeException(); // sprawdza czy masa dodatnia

                pociag.DodajLokomotywe(ModelL.Text, masaLok);
                SkladPociagu.Text = pociag.Informacje();
            }
            catch
            {
                MessageBox.Show("Sprawdź poprawność wprowadzonych danych");
            }
        }

        private void UkryjL_Click(object sender, RoutedEventArgs e)
        {
            Ukryj();
        }

        private void DodWagon_Click(object sender, RoutedEventArgs e)
        {
            PanelLokomotywa.Visibility = Visibility.Hidden;
            PanelWagon.Visibility = Visibility.Visible;
        }

        private void DodajW_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int masaWag;
                masaWag = Convert.ToInt32(MasaW.Text);

                if (masaWag <= 0)
                    throw new ArgumentOutOfRangeException();

                if (Typ.SelectedIndex == 0)
                {
                    pociag.DodajOsobowy(ModelW.Text, masaWag, RodzajLadunek.Text);
                }

                if (Typ.SelectedIndex == 1)
                {
                    pociag.DodajTowarowy(ModelW.Text, masaWag, RodzajLadunek.Text);
                }

                else
                    throw new ArgumentNullException();

                SkladPociagu.Text = pociag.Informacje();
            }

            catch
            {
                MessageBox.Show("Sprawdź poprawność wprowadzonych danych!");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (pociag.MozeJechac())
                MessageBox.Show("Zapierdalamy! :D");

            else
                MessageBox.Show("Coś poszło nie tak :c");
        }

        private void UkryjW_Click(object sender, RoutedEventArgs e)
        {
            Ukryj();
        }

        

    }
}
