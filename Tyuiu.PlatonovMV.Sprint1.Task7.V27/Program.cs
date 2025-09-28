using System;
using Tyuiu.PlatonovMV.Sprint1.Task7.V27.Lib;

class Program
{
    static void Main()
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Платонов М. В. | ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #27                                                             *");
        Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение:         *");
        Console.WriteLine("*      cos^2x + sin^2y     x*y - 12                                       *");
        Console.WriteLine("* z = -------------- - -------------                                      *");
        Console.WriteLine("*       sin y + 1       15 + cos x                                        *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите значение x:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение y:");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double result = ds.Calculate(x, y);
        Console.WriteLine($"z = {result}");

        Console.ReadLine();
    }
}