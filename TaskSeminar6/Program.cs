void Zadacha41()
{   
    Console.WriteLine("Задача 41");
    string quit = " ";
    int col = 0;
    int num;
    bool inputing = true;
    while (inputing)
    {
        Console.WriteLine("Введите число или нажмите q для выхода.");
        quit = Console.ReadLine();
        if (quit != "q") 
        {
            num = Convert.ToInt32(quit);
            if (num > 0) 
            {
                col++;
            }
        }
        else inputing = false;
    }
    if (col == 0) Console.WriteLine("Положительных чисел нет");
    if (col == 1) Console.WriteLine($"Вы ввели {col} положительное число");
    if (col > 1 && col < 5) Console.WriteLine($"Вы ввели {col} положительных числа");
    if (col > 4) Console.WriteLine($"Вы ввели {col} положительных чисел");
}

void Zadacha43()
{
    Console.WriteLine("_____________________________________________");
    Console.WriteLine("_____________________________________________");
    Console.WriteLine("Задача 43");
    Console.WriteLine("Введите коэффициент b1");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэффициент k1");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэффициент b2");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэффициент k2");
    double k2 = Convert.ToInt32(Console.ReadLine());
    if (k1 == k2) Console.WriteLine("Прямые параллельны");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения прямых A({x},{y})");
    }
}
Zadacha41();
Zadacha43();