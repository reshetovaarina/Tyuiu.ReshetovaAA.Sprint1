using Tyuiu.ReshetovaAA.Sprint1.Task7.V30.Lib;

namespace Tyuiu.ReshetovaAA.Sprint1.Task6.V30.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Вариант 30 | Решетова А.А. | СМАРТб-25-1";

            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* Спринт #1. Задание 7. Вариант 30                                                    *");
            Console.WriteLine("* Выполнила: Решетова Арина | СМАРТб-25-1                                             *");
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* Условие:                                                                            *");
            Console.WriteLine("* Вычислить выражение:                                                               *");
            Console.WriteLine("* z = x + e^x + (sin(x^5) + x^3) / 3^x + y^5 / 5^y                                   *");
            Console.WriteLine("* Результат округлить до 3 знаков после запятой.                                     *");
            Console.WriteLine("*****************************************************************************************");

            double x, y;
            Console.Write("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите y: ");
            y = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();

            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine($"Результат:");
            Console.WriteLine("*****************************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}