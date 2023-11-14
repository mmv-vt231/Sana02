namespace PointsAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int avg, sum = 0;

            Console.WriteLine("Введіть 5 оцінок за 100-бальною шкалою:");
            for (int i = 0; i < 5; i++)
            {
                int x;
                do {
                    x = int.Parse(Console.ReadLine());

                    if (x < 0 || x > 100)
                        Console.WriteLine("Оцінка повинна бути від 0 до 100");
                } while (x < 0 || x > 100);

                sum += x;
            }
            
            avg = sum / 5;

            if(avg >= 50)
                Console.WriteLine("Допущено до екзамену");
            else
                Console.WriteLine("Недопущено до екзамену");
        }
    }
}