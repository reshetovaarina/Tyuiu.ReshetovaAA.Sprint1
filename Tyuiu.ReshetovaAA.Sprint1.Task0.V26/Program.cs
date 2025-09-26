using Tyuiu.ReshetovaAA.Sprint1.Task0.V26.Lib;
DataService ds = new DataService();


Console.Title = "Спринт #1 | Выполнила: Решетова А. А.  | СМАРТб-25-1";
Console.WriteLine("***************************************************************************************************");
Console.WriteLine("*Спринт #1                                                                                        *");
Console.WriteLine("*Тема: Базовые навыки работы в C#                                                                 *");
Console.WriteLine("*Задание #0                                                                                       *");
Console.WriteLine("*Вариант #26                                                                                      *");
Console.WriteLine("*Выполнила: Решетова А. А.  | СМАРТб-25-1                                                         *");
Console.WriteLine("***************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                        *");
Console.WriteLine("* Написать контрольную программу на C#, которая вычисляет выражение (4 * 5)/ 2 - (18 / 2)/ 3      *");
Console.WriteLine("* И печатает результат на экране.                                                                 *");
Console.WriteLine("*                                                                                                 *");
Console.WriteLine("***************************************************************************************************");
Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
Console.WriteLine("***************************************************************************************************");
Console.WriteLine("* (4 * 5)/ 2 - (18 / 2)/ 3                                                                        *");

Console.WriteLine(ds.Calculate());

Console.ReadLine();

