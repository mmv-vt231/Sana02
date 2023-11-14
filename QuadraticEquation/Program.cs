namespace QuadraticEquation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int a, b, c, D;
            double x1, x2;

            Console.WriteLine("Введіть число a:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть число b:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть число c:");
            c = int.Parse(Console.ReadLine());

            D = b * b - 4 * a * c;
            Console.WriteLine($"Дискримінант = {D}");

            if (D > 0) {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);

                Console.WriteLine($"x1 = {x1}\nx2 = {x2}");
            } else if(D == 0) {
                x1 = -b / (2 * a);

                Console.WriteLine($"x = {x1}");
            } else {
                Console.WriteLine($"Коренів немає");
            }
        }
    }
}