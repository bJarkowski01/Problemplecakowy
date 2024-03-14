using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("TestProblemplecakowy")]
[assembly: InternalsVisibleTo("GUI")]
namespace Problemplecakowy
{
    internal class Problem
    {
        public int liczba_przedmiotow;
        public int seed;
        public List<Przedmiot> przedmioty = new List<Przedmiot>();
        public Problem(int n, int _seed)
        {
            this.liczba_przedmiotow = n;
            this.seed = _seed;
            Random random = new Random(seed);
            for (int i = 0;i<n;i++)
            {
                int waga = random.Next(1,10);
                int wartosc = random.Next(1,10);
                przedmioty.Add(new Przedmiot(wartosc, waga, i));
            }
        }
        public void SortujPrzedmioty()
        {
            przedmioty.Sort((x, y) => y.Stosunek.CompareTo(x.Stosunek));
        }

        public Result Solve(int capacity)
        {
            Result result = new Result();
            SortujPrzedmioty();
            int liczba_przedmiotow_w_plecaku=0;
            for (int i = 0; i < liczba_przedmiotow; i++)
            {
                if (capacity >= przedmioty[i].Waga)
                {
                    capacity = capacity - przedmioty[i].Waga;
                    result.set_Waga_Totalna = result.get_Waga_Totalna + przedmioty[i].Waga;
                    result.set_Wartosc_Totalna = result.get_Wartosc_Totalna + przedmioty[i].Wartosc;
                    result.DodajPrzemiot(przedmioty[i].Waga, przedmioty[i].Wartosc, przedmioty[i].Nr);
                    liczba_przedmiotow_w_plecaku++;
                }
     
            }
            result.set_Liczba_Przedmiotow_W_Plecaku = liczba_przedmiotow_w_plecaku;
            return result;
        }
        public override string ToString()
        {
            string result = $"Liczba przedmiotów: {liczba_przedmiotow}" + Environment.NewLine;
            for (int i = 0; i < liczba_przedmiotow; i++)
            {
                result += $"Nr.: {przedmioty[i].Nr}: V: {przedmioty[i].Wartosc}, W: {przedmioty[i].Waga}" + Environment.NewLine;
            }
            return result;
        }
    }
}
