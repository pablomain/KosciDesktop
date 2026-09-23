using System;

namespace KosciDesktop
{
    public class Kosc
    {
        public static int liczbaInstancji = 0;
        public static Random losowa = new Random();

        public string[] pliki =
        {
            "kosc0.png",
            "kosc1.png",
            "kosc2.png",
            "kosc3.png",
            "kosc4.png",
            "kosc5.png",
            "kosc6.png"
        };

        public int liczbaOczek;
        public int idPliku;
        public bool dostepna;

        public Kosc()
        {
            liczbaOczek = 0;
            idPliku = 0;
            dostepna = true;
            liczbaInstancji++;
        }

        public Kosc(int oczka)
        {
            if (oczka < 1 || oczka > 6)
            {
                oczka = 0;
            }

            liczbaOczek = oczka;
            idPliku = oczka;
            dostepna = true;
            liczbaInstancji++;
        }

        public void Rzut()
        {
            if (dostepna == true)
            {
                liczbaOczek = losowa.Next(1, 7);
                idPliku = liczbaOczek;
            }
        }

        public void ZmienDostepnosc()
        {
            if (dostepna == true)
            {
                dostepna = false;
            }
            else
            {
                dostepna = true;
            }
        }
    }
}
