using Tyuiu.ReshetovaAA.Sprint1.Task1.V22.Lib;
DataService ds = new DataService();


Console.Title = "Спринт #1 | Выполнила: Решетова А. А.  | СМАРТб-25-1";
Console.WriteLine("***************************************************************************************************");
Console.WriteLine("*Спринт #1                                                                                        *");
Console.WriteLine("*Тема: Базовые навыки работы в C#                                                                 *");
Console.WriteLine("*Задание #1                                                                                       *");
Console.WriteLine("*Вариант #22                                                                                      *");
Console.WriteLine("*Выполнила: Решетова А. А.  | СМАРТб-25-1                                                         *");
Console.WriteLine("***************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                        *");
Console.WriteLine("* Написать контрольную программу на C#, которая вычисляет выражение (5+x)/(y*x)                   *");
Console.WriteLine("* И печатает результат на экране.                                                                 *");
Console.WriteLine("*                                                                                                 *");
Console.WriteLine("***************************************************************************************************");
Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
Console.WriteLine("***************************************************************************************************");
Console.WriteLine("* (5+x)/(y*x)                                                                                     *");


double x, y;


Console.WriteLine("Введите значение X:");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение Y:");
y = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("***************************************************************************************************");
Console.WriteLine("* Результат                                                                                       *");
Console.WriteLine("***************************************************************************************************");


Console.WriteLine(ds.Calculate(x, y));


Console.ReadLine();
