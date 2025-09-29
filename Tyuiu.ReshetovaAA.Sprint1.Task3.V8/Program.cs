using Tyuiu.ReshetovaAA.Sprint1.Task3.V8.Lib;

namespace Tyuiu.ReshetovaAA.Sprint1.Task3.V8
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
            Console.WriteLine("*Задание #3                                                                                       *");
            Console.WriteLine("*Вариант #8                                                                                       *");
            Console.WriteLine("*Выполнила: Решетова А. А.  | СМАРТб-25-1                                                         *");
            Console.WriteLine("* УСЛОВИЕ:                                                                                        *");
            Console.WriteLine("*Написать программу вычисления величины дохода по вкладу.                                         *");


            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");

            double deposit = 2500;
            double percent = 20;
            double days = 30;

            Console.WriteLine("Сумма вклада (руб.) = " + deposit                                                                 );
            Console.WriteLine("Процентная ставка (% годовых) = " + percent                                                       );
            Console.WriteLine("Срок вклада (дней) = " + days                                                                     );

            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
            Console.WriteLine("*************************************************************************************************");

            double income = ds.IncomeAmount(deposit, percent, days);
            double total = deposit + income;

            Console.WriteLine("Доход: " + income + " руб.");
            Console.WriteLine("Сумма по окончании срока вклада: " + total + " руб.");

            Console.ReadKey();
        }
    }
}