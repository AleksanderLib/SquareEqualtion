using System;

namespace SquareEqualtion_1
{
    class Program
    {
        static void Main()
        {
            double a, b, c;
            while (true)
            {
                try
                {
                    Console.Write("Введите a = ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите b = ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите c = ");
                    c = Convert.ToDouble(Console.ReadLine());
                    break;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат данных");
                }
            }

            SquareEqualtion equaltion = new SquareEqualtion();
            equaltion.GetRoots(a, b, c);

            Output(a, b, c, equaltion);

            Console.ReadLine();
        }

        private static void Output(double a, double b, double c, SquareEqualtion equaltion)
        {
            double[] rezult = equaltion.GetRoots(a, b, c);

            switch (rezult.Length)
            {
                case 1:
                    Console.WriteLine("Уравнение имеет один корень");
                    Console.WriteLine("x1 = {0}", rezult[0]);
                    break;
                case 2:
                    Console.WriteLine("Уравнение имеет два корня");
                    Console.WriteLine("x1 = {0} x2 = {1}", rezult[0], rezult[1]);
                    break;
                default:
                    Console.WriteLine("Уравнение не имеет вещественных корней");
                    break;
            }
        }
    }
}
