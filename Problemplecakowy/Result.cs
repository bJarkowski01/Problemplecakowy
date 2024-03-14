using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemplecakowy
{
    internal class Result
    {
        int waga_totalna;
        int wartosc_totalna;
        public List<Przedmiot> przedmioty_w_plecaku = new List<Przedmiot>();
        public int liczba_przedmiotow_w_plecaku;

        public Result()
        {
            waga_totalna = 0;
            wartosc_totalna = 0;
        }
        public int get_Waga_Totalna { get { return waga_totalna;} }
        public int get_Wartosc_Totalna { get { return wartosc_totalna;} }

        public int set_Waga_Totalna { set { waga_totalna = value; } }

        public int set_Wartosc_Totalna { set { wartosc_totalna = value; } }

        public int set_Liczba_Przedmiotow_W_Plecaku {  set { liczba_przedmiotow_w_plecaku = value;} }

        public void DodajPrzemiot(int waga, int wartosc, int nr)
        {
            przedmioty_w_plecaku.Add(new Przedmiot(wartosc, waga, nr));
        }

        public override string ToString()
        {
            string result = $"V: {wartosc_totalna}, W: {waga_totalna}" + Environment.NewLine;
            for (int i = 0; i < liczba_przedmiotow_w_plecaku; i++)
            {
                result += $"Nr.: {przedmioty_w_plecaku[i].Nr}: V: {przedmioty_w_plecaku[i].Wartosc}, W: {przedmioty_w_plecaku[i].Waga}" + Environment.NewLine;
            }
            return result;
        }
    }
}
