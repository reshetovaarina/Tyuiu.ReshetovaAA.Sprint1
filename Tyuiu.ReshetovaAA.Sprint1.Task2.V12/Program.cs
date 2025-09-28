using Tyuiu.ReshetovaAA.Sprint1.Task2.V12.Lib;
namespace Tyuiu.SpirinIS.Sprint1.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Решетова А. А.  | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("*Спринт #1                                                                                        *");
            Console.WriteLine("*Тема: Базовые навыки работы в C#                                                                 *");
            Console.WriteLine("*Задание #2                                                                                       *");
            Console.WriteLine("*Вариант #12                                                                                      *");
            Console.WriteLine("*Выполнила: Решетова А. А.  | СМАРТб-25-1                                                         *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                        *");
            Console.WriteLine("*Известны длины стороны параллелепипеда. Вычислить объем параллелепипеда.                         *");
            Console.WriteLine("* И печатает результат на экране.                                                                 *");
            Console.WriteLine("*                                                                                                 *");


            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            Console.Write("*Введите длину параллелепипеда:                                                                        *");
            int value = Convert.ToInt32(Console.ReadLine());

            Console.Write("*Введите ширину параллелепипеда:                                                                       *");
            int valueTwo = Convert.ToInt32(Console.ReadLine());

            Console.Write("*Введите высоту параллелепипеда:                                                                       *");
            int valueThree = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
            Console.WriteLine("****************************************************************************************************");

            int volume = ds.CalculateParallelepipedVolume(value, valueTwo, valueThree);
            Console.WriteLine("Объем параллелепипеда = " + volume);

            Console.ReadLine();
        }
    }
}