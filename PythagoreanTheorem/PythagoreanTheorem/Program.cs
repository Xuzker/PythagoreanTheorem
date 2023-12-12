namespace PythagoreanTheorem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = 100;

            Console.WriteLine("Тройки Пифагора с квадратами меньше {0}:");

            for (int a = 1; a <= limit; a++)
            {
                for (int b = a; b <= limit; b++)
                {
                    int cSquare = a * a + b * b;
                    int c = (int)Math.Sqrt(cSquare);

                    if (c * c == cSquare && c <= limit)
                    {
                        Console.WriteLine("{0}, {1}, {2}", a, b, c);
                    }
                }
            }
        }
    }
}