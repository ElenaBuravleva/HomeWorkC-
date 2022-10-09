void Zadacha47()// Двумерный массив вещественных чисел
{
    Console.WriteLine("Задача 47");
    Console.WriteLine("_____________________________________________");
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($"Массив вещественных чисел размера {rows}*{columns}");
    double[,] numbers = new double[rows, columns];
    FillArrayD(numbers, -100, 100);
    Console.WriteLine();
    PrintArrayD(numbers);
}

void FillArrayD(double[,] numbers, int min, int max)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    int k;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (random.Next(-1, 1) == -1) k = -1;
            else k = 1;
            numbers[i, j] = Math.Round(random.NextDouble(), 1) * k;
        }
    }
}

void PrintArrayD(double[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void Zadacha49()// Вывод значения элементов массива по введенным индексам
{
    Console.WriteLine("_____________________________________________");
    Console.WriteLine("Задача 49");
    Console.WriteLine("_____________________________________________");
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($"Массив размера {rows}*{columns}");
    int[,] numbers = new int[rows, columns];
    FillArray(numbers, 0, 10);
    Console.WriteLine();
    PrintArray(numbers);
    Console.WriteLine("Введите первый индекс элемента");
    int Nrow = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второй индекс элемента");
    int Ncolumn = Convert.ToInt32(Console.ReadLine());
    if (Nrow >= numbers.GetLength(0)
     || Ncolumn >= numbers.GetLength(1)
     || Nrow < 0
     || Ncolumn < 0) Console.WriteLine("Такого элемента нет. Выход за границы массива");
    else Console.WriteLine($"Элемент ({Nrow},{Ncolumn}) = {numbers[Nrow, Ncolumn]}");
}

void FillArray(int[,] numbers, int min, int max)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(min, max);
        }
    }
}

void PrintArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void Zadacha51()// Вывод среднего арифметического каждого столбца
{
    Console.WriteLine("_____________________________________________");
    Console.WriteLine("Задача 51");
    Console.WriteLine("_____________________________________________");
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($"Массив размера {rows}*{columns}");
    int[,] numbers = new int[rows, columns];
    FillArray(numbers, 0, 10);
    Console.WriteLine();
    PrintArray(numbers);
    if (columns == 4)
    {
        Console.WriteLine("__________________________");
        Console.WriteLine("__________________________");
    }
    else
    {
        if (columns <= 6)
        {
            Console.WriteLine("___________________________________________");
            Console.WriteLine("___________________________________________");
        }
        else
        {
            Console.WriteLine("____________________________________________________");
            Console.WriteLine("____________________________________________________");
        }
    }
    ArithMean(numbers);
}

void ArithMean(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    double sum;
    for (int j = 0; j < columns; j++)
    {
        sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum = sum + numbers[i, j];
        }
        Console.Write(Math.Round(sum / rows, 1) + "\t");
    }
}

Zadacha47();
Zadacha49();
Zadacha51();