using Tyuiu.ReshetovaAA.Sprint1.Task4.V26.Lib;

namespace Tyuiu.Sprint1.Task3.V8.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнила: Решетова Арина | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                        *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                                                 *");
            Console.WriteLine("* Задание #4                                                                                       *");
            Console.WriteLine("* Вариант #26                                                                                       *");
            Console.WriteLine("* Выполнила: Решетова Арина | СМАРТб-25-1                                                             *");
            Console.WriteLine("***************************************************************************************************");
           
            
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,                          *");
            Console.WriteLine("* вычисляет результат по формуле (arctg(x) + y) / e^(y+z)                                          *");
            Console.WriteLine("* и выводит результат с округлением до 3-х знаков после запятой.                                   *");
            Console.WriteLine("***************************************************************************************************");

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");

            Console.Write("Введите x:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите y:");
            double y = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            double result = ds.Calculate(x, y);

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("Результат вычисления:" + result);

            Console.ReadKey();
        }
    }
}