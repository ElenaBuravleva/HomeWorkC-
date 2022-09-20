﻿void Zadacha10()
{
    Console.WriteLine("Введите трёхзначное число");
    int number = Convert.ToInt32(Console.ReadLine());
    if (Math.Abs(number) > 999 || Math.Abs(number) < 100)
    {
        Console.WriteLine("Число не трёхзначное");
    }
    else
    {
        int second = (number / 10) % 10;
        if (second >= 0)
        {
            Console.WriteLine("Вторая цифра этого числа: " + second);
        }
        else Console.WriteLine("Вторая цифра этого числа: " + Math.Abs(second));
    }
}


void Zadacha13()
{
    Console.WriteLine("Введите число");
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else if (number < 1000)
    {
        Console.WriteLine("Третья цифра этого числа: " + number % 10);
    }
    else while (number > 1000)
        {
            number = number / 10;
            if (number < 1000)
            {
                Console.WriteLine("Третья цифра этого числа: " + number % 10);
            }
        }
}


void Zadacha15()
{
    Console.WriteLine("Введите порядковый номер дня недели");
    int daynumber = Convert.ToInt32(Console.ReadLine());
    if (daynumber <= 0 || daynumber > 7)
    {
        Console.WriteLine("Неверный диапазон");
    }
    else if (daynumber > 5)
    {
        Console.WriteLine("Выходной день");
    }
        else Console.WriteLine("День не является выходным");   
}
Zadacha10();
Zadacha13();
Zadacha15();