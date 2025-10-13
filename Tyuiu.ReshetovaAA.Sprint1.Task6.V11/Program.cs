using Tyuiu.ReshetovaAA.Sprint1.Task6.V11.Lib;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнила: Фамилия Имя | СМАРТб-25-1";
        Console.WriteLine("****************************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                                        *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                                                 *");
        Console.WriteLine("* Задание #6                                                                                       *");
        Console.WriteLine("* Вариант #11                                                                                      *");
        Console.WriteLine("* Выполнила: Решетова Арина | СМАРТб-25-1                                                          *");
        Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
        Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что первая буква строки входит         *");
        Console.WriteLine("* в нее еще раз.                                                                                   *");
        Console.WriteLine("****************************************************************************************************");

        Console.WriteLine("***************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
        Console.WriteLine("***************************************************************************************************");

        Console.Write("Введите текст: ");
        string value = Console.ReadLine();

        DataService ds = new DataService();
        bool result = ds.CheckeFirstLetterRepetition(value);

        Console.WriteLine("***************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                     *");
        Console.WriteLine("***************************************************************************************************");

        if (result)
            Console.WriteLine("Первая буква встречается ещё раз в строке.");
        else
            Console.WriteLine("Первая буква больше не встречается.");

        Console.ReadKey();
    }
}