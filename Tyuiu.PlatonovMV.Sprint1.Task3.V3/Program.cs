using Tyuiu.PlatonovMV.Sprint1.Task3.V3.Lib;
using System;

class Program
{
    static void Main()
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Платонов М. В. | ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу вычисления объема параллелепипеда.                   *");
        Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double length, width, height;

        Console.WriteLine("Введите длину (см):");
        length = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите ширину (см):");
        width = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите высоту (см):");
        height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double volume = ds.ParallelepipedVolume(length, width, height);
        Console.WriteLine($"Объем: {volume} см.куб.");

        Console.ReadLine();
    }
}
//