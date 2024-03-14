namespace Problemplecakowy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of items:" + Environment.NewLine);
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the seed:" + Environment.NewLine);
            int seed = int.Parse(Console.ReadLine());
            Problem problem = new Problem(n,seed);
            Console.WriteLine(problem.ToString());
            Console.WriteLine("Enter the capacity:" + Environment.NewLine);
            int capacity = int.Parse(Console.ReadLine());
            Console.WriteLine(problem.Solve(capacity).ToString());

        }
    }
}
