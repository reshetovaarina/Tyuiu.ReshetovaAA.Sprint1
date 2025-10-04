using Tyuiu.ReshetovaAA.Sprint1.Task5.V3.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнила: Решетова А. А.  | СМАРТб-25-1";
Console.WriteLine("***************************************************************************************************");
Console.WriteLine("*Спринт #1                                                                                        *");
Console.WriteLine("*Тема: Базовые навыки работы в C#                                                                 *");
Console.WriteLine("*Задание #3                                                                                       *");
Console.WriteLine("*Вариант #8                                                                                       *");
Console.WriteLine("*Выполнила: Решетова А. А.  | СМАРТб-25-1                                                         *");
Console.WriteLine("* УСЛОВИЕ:                                                                                        *");
Console.WriteLine("*Присвоить целой переменной h третью от конца цифру в записи положительного целого числа k        *");


Console.WriteLine("***************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
Console.WriteLine("***************************************************************************************************");

Console.WriteLine("*Введите k:                                                                                        *");
int k = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ h:                                                                                      *");
Console.WriteLine("***************************************************************************************************");
int res = Convert.ToInt32(ds.Calculate(k));
Console.WriteLine(res);

Console.ReadKey();