using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace KosciDesktop
{
    public partial class MainWindow : Window
    {
        private Kosc[] kosci;
        private Image[] obrazyKosci;
        private string folderObrazow;

        public MainWindow()
        {
            InitializeComponent();

            kosci = new Kosc[5];
            obrazyKosci = new Image[5];
            obrazyKosci[0] = imgKosc0;
            obrazyKosci[1] = imgKosc1;
            obrazyKosci[2] = imgKosc2;
            obrazyKosci[3] = imgKosc3;
            obrazyKosci[4] = imgKosc4;

            for (int i = 0; i < kosci.Length; i++)
            {
                kosci[i] = new Kosc();
            }

            folderObrazow = AppDomain.CurrentDomain.BaseDirectory;
            OdswiezWidok();
        }

        private void KlikRzut(object sender, RoutedEventArgs e)
        {
            int suma = 0;

            for (int i = 0; i < kosci.Length; i++)
            {
                kosci[i].Rzut();
                suma = suma + kosci[i].liczbaOczek;
            }

            txtWynik.Text = suma.ToString();
            OdswiezWidok();
        }

        private void KlikKosc(object sender, MouseButtonEventArgs e)
        {
            Image obraz = (Image)sender;
            int indeks = int.Parse(obraz.Tag.ToString());

            kosci[indeks].ZmienDostepnosc();
            OdswiezWidok();
        }

        private void OdswiezWidok()
        {
            for (int i = 0; i < kosci.Length; i++)
            {
                string nazwaPliku = kosci[i].pliki[kosci[i].idPliku];
                obrazyKosci[i].Source = WczytajObraz(nazwaPliku);

                if (kosci[i].dostepna == true)
                {
                    obrazyKosci[i].Opacity = 1.0;
                }
                else
                {
                    obrazyKosci[i].Opacity = 0.5;
                }
            }
        }

        private BitmapImage WczytajObraz(string nazwaPliku)
        {
            string sciezka = Path.Combine(folderObrazow, nazwaPliku);
            BitmapImage obraz = new BitmapImage();
            obraz.BeginInit();
            obraz.UriSource = new Uri(sciezka, UriKind.Absolute);
            obraz.CacheOption = BitmapCacheOption.OnLoad;
            obraz.EndInit();
            return obraz;
        }
    }
}
