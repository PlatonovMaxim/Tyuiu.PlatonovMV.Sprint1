using System;
using Tyuiu.PlatonovMV.Sprint1.Task6.V2.Lib;

class Program
{
    static void Main()
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Платонов М. В. | ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Работа со строками класс String                                   *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнил: Платонов Максим Владимирович | ИСТНб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу: пользователь вводит текст.                          *");
        Console.WriteLine("* Проверить, есть ли в строке слово Hello.                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        bool hasHello = ds.CheckHello(text);
        Console.WriteLine(hasHello ? "Слово 'Hello' найдено!" : "Слово 'Hello' не найдено!");

        Console.ReadLine();
    }
}