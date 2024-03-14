using Problemplecakowy;
namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int n;//= int.Parse(ilosc_przedmiotow.Text);
            int seed; //= int.Parse(sseed.Text);

            if (!int.TryParse(ilosc_przedmiotow.Text, out n) || n < 0)
            {
                ilosc_przedmiotow.BackColor = Color.Red;
            }
            else { ilosc_przedmiotow.BackColor = Color.White; }


            if (!int.TryParse(sseed.Text, out seed) || seed <= 0)
            {
                sseed.BackColor = Color.Red;
            }
            else { sseed.BackColor = Color.White; }



            Problem problem = new Problem(n, seed);
            wynik1.Text = problem.ToString();
            int cap;// = int.Parse(pojemnosc_plecaka.Text);
            if (!int.TryParse(pojemnosc_plecaka.Text, out cap) || cap < 0)
            {
                pojemnosc_plecaka.BackColor = Color.Red;
            }
            else { pojemnosc_plecaka.BackColor = Color.White; }
            wynik2.Text = problem.Solve(cap).ToString();
        }


    }
}
