using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace koscConsole
{
    public class Kosc
    {
        public static int instance;
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

        public Kosc(int oczka)
        {
            if(oczka < 1 || oczka > 6)
            {
                oczka = 0;
            }
            liczbaOczek = oczka;
            idPliku = oczka;
            dostepna = true;

            instance++;
        }

        public Kosc()
        {
            Random random = new Random();
            liczbaOczek = random.Next(1, 7);
            idPliku = liczbaOczek;
            dostepna = true;

            instance++;
        }

        public void Rzut()
        {
            if (dostepna)
            {
                Random random = new Random();
                liczbaOczek = random.Next(1, 7);
                idPliku = liczbaOczek;
            }
        }

        public void Block()
        {
            dostepna = false;
        }

        public string wynikSlownie()
        {
            switch (liczbaOczek)
            {
                case 1:
                    return "jeden";
                case 2:
                    return "dwa";
                case 3:
                    return "trzy";
                case 4:
                    return "cztery";
                case 5:
                    return "pięć";
                case 6:
                    return "sześć";
                default:
                    return "zero";
            }
        }
    }
}
