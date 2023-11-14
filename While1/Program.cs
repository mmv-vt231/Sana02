namespace While1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            CalcA(n);
            CalcB(n);
            CalcC(n);
        }

        static void CalcA(int n)
        {
            double a = 0;

            for(int i = 1; i <= n; i++)
                a += Math.Pow(-1, i) / (2 * i + 1);

            Console.WriteLine($"a = {a:F2}");
        }

        static void CalcB(int n)
        {
            double b = 0;

            for (int i = 1; i <= n; i++)
                b += 1 + (1.0 / (i * i));

            Console.WriteLine($"b = {b:F2}");
        }
        static void CalcC(int n)
        {
            double c = 0;

            for (int i = 1; i <= n; i++)
            {
                int fact = 1;
                for (int j = 1; j <= i; j++)
                    fact *= j;

                c += fact;
            }

            Console.WriteLine($"c = {c}");
        }
    }
}