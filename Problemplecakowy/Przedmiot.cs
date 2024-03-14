using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemplecakowy
{
    internal class Przedmiot
    {
        int wartosc;
        int waga;
        float stosunek;
        int nr;
        public Przedmiot(int _wartosc, int _waga, int _nr)
        {
            this.wartosc = _wartosc;
            this.waga = _waga;
            this.stosunek = (float)_wartosc / (float)_waga;
            this.nr = _nr;
        }
        public float Stosunek { get {  return stosunek; } }
        public int Waga { get {  return waga; } }
        public int Wartosc { get { return wartosc; } }

        public int Nr { get { return nr; } }
    }
}
