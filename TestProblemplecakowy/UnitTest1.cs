using Problemplecakowy;
namespace TestProblemplecakowy
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void CzyDodajeNElementowDoListyPrzedmiotow()
        {
            List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
            foreach (int n in sizes)
            {
                Problem problem = new Problem(n, 1);
                Assert.AreEqual(n, problem.przedmioty.Count);
            }
        }

        [TestMethod]
        public void CzyDodajeWszystkoDoPlecaka()
        {
            List<int> sizes = new List<int> { 10, 20, 30, 40, 50 };
            int cap = 500;
            foreach (int n in sizes)
            {
                Problem problem = new Problem(n, 1);
                Result result = problem.Solve(cap);
                Assert.AreEqual(n, result.liczba_przedmiotow_w_plecaku);
                Assert.AreEqual(n, result.przedmioty_w_plecaku.Count);
            }
        }

        [TestMethod]
        public void CzyZwraca0GdyNieDodamPrzedmiotow()
        {
            Problem problem = new Problem(0, 1);
            Result result = problem.Solve(10);
            Assert.AreEqual(0, problem.przedmioty.Count);
            Assert.AreEqual(0, result.przedmioty_w_plecaku.Count);
        }

        [TestMethod]
        public void CzyDzialaDlaDuzejIlosciPrzedmiotow()
            {
                Problem problem1 = new Problem(1000000, 1);
            Problem problem2 = new Problem(1000000, 1);
            Result result1 = problem1.Solve(1000);
            Result result2 = problem2.Solve(1000);
            Assert.AreEqual(result1.get_Waga_Totalna, result2.get_Waga_Totalna);
            }



        [TestMethod]
        public void Testlista1()
        {
            int n = 10;
            int seed = 1;
            int cap = 10;
            Problem problem = new Problem(n,seed);
            Result result = problem.Solve(cap);
            Assert.AreNotEqual(0,result.przedmioty_w_plecaku.Count);
            Assert.AreNotEqual(0, result.liczba_przedmiotow_w_plecaku);
        }
        [TestMethod]
        public void Testlista2() 
        {
            int n = 10;
            int seed = 1;
            int cap = 0;
            Problem problem = new Problem(n, seed);
            Result result = problem.Solve(cap);
            Assert.AreEqual(0, result.liczba_przedmiotow_w_plecaku);
            Assert.AreEqual(0, result.przedmioty_w_plecaku.Count);
        }
        [TestMethod]
        public void Testlista3()
        {
            int n = 4;
            int seed = 1;
            int cap = 10;
            Problem problem1 = new Problem(n,seed);
            //0: V=1, W=3 ;; 1: V=7, W=5 ;; 2: V=4, W=6 ;; 3: V=9 W=4;
            Problem problem2 = new Problem(n,seed);
            problem2.przedmioty.Clear();
            problem2.przedmioty.Add(new Przedmiot(1, 3, 0));
            problem2.przedmioty.Add(new Przedmiot(9, 4, 1));
            problem2.przedmioty.Add(new Przedmiot(7, 5, 2));
            problem2.przedmioty.Add(new Przedmiot(4, 6, 3));
            Result result1 = problem1.Solve(cap);
            Result result2 = problem2.Solve(cap);
            Assert.AreEqual(result1.get_Waga_Totalna, result2.get_Waga_Totalna);
            Assert.AreEqual(result1.get_Wartosc_Totalna, result2.get_Wartosc_Totalna);
        }

        [TestMethod]
        public void Testlista4()
        {
            int n = 3;
            int seed = 1;
            int cap = 10;
            // Wylosowane przedmioty: nr.0 V=1, W=3 ;; nr.1 V=7, W=5 ;; nr.2 V=4, W=6
            Problem problem = new Problem(n, seed);
            Result result = problem.Solve(cap);
            Assert.AreEqual(8, result.get_Waga_Totalna);
            Assert.AreEqual(8, result.get_Wartosc_Totalna);
        }
    }
}
