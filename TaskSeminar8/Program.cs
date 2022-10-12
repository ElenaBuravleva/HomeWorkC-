void Zadacha54()
{
    Console.WriteLine("_____________________________________________");
    Console.WriteLine("Задача 54");
    Console.WriteLine("_____________________________________________");
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($"Массив размера {rows}*{columns} до сортировки");
    int[,] numbers = new int[rows, columns];
    FillArray(numbers, 0, 10);
    PrintArray(numbers);
    Console.WriteLine("После сортировки");
    SortArray(numbers);
    PrintArray(numbers);
}

void SortArray(int[,] numbers)
{
    for (int k = 0; k < numbers.GetLength(0); k++)
    {
        for (int i = 0; i < numbers.GetLength(1) - 1; i++)
        {
            int maxposition = i;
            for (int j = i + 1; j < numbers.GetLength(1); j++)
            {
                if (numbers[k, j] > numbers[k, maxposition])
                {
                    maxposition = j;
                }
            }
            int temp = numbers[k, i];
            numbers[k, i] = numbers[k, maxposition];
            numbers[k, maxposition] = temp;
        }
    }
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

void Zadacha56()
{
    Console.WriteLine("_____________________________________________");
    Console.WriteLine("Задача 56");
    Console.WriteLine("_____________________________________________");
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($"Массив размера {rows}*{columns}");
    int[,] numbers = new int[rows, columns];
    FillArray(numbers, 0, 10);
    PrintArray(numbers);
    Console.WriteLine();
    MinSumRow(numbers);
}

void MinSumRow(int[,] numbers)
{
    int NumRows = 0;
    int SumRow = 0;
    int MinSum = 1000;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        SumRow = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            SumRow += numbers[i, j];
        }
        if (MinSum > SumRow)
        {
            MinSum = SumRow;
            NumRows = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов в строке № {NumRows + 1}");
}

void Spiral()
{
    Console.WriteLine("_________________________________");
    Console.WriteLine("Спиральное заполнение массива 4*4");
    int N = 4;
    int[,] numbers = new int[N, N];
    int i = 0;
    int j = 0;
    int stepi = 0;
    int stepj = 1;
    for (int k = 1; k < N * N + 1; k++)
    {
        numbers[i, j] = k;
        if (k < N || k == 3 * N)
        {
            stepi = 0;
            stepj = 1;
        }
        if (k == N || k == 4 * N - 2)
        {
            stepi = 1;
            stepj = 0;
        }
        if (k == 2 * N - 1 || k == 4 * N - 1)
        {
            stepi = 0;
            stepj = -1;
        }
        if (k == 3 * N - 2)
        {
            stepi = -1;
            stepj = 0;
        }
        i += stepi;
        j += stepj;
    }
    PrintArray(numbers);
}

void Multiplication()
{
    Console.WriteLine("_________________________");
    Console.WriteLine("Умножение матриц");
    Random random = new Random();
    int size = random.Next(3, 5);
    int[,] numbers1 = new int[size, size];
    int[,] numbers2 = new int[size, size];
    FillArray(numbers1, -9, 10);
    FillArray(numbers2, -9, 10);
    PrintArray(numbers1);
    if (size == 3) Console.WriteLine("        X");
    else Console.WriteLine("            X");
    PrintArray(numbers2);
    if (size == 3) Console.WriteLine("        =");
    else Console.WriteLine("            =");
    MultiplicatonMatrix(numbers1, numbers2, size);
}

void MultiplicatonMatrix(int[,] numbers1, int[,] numbers2, int size)
{
    int[,] numbers = new int[size, size];
    for (int k = 0; k < size; k++)
    {
        for (int l = 0; l < size; l++)
        {
            numbers[k, l] = 0;
            for (int m = 0; m < size; m++)
            {
                numbers[k, l] += numbers1[k, m] * numbers2[m, l];
            }
        }
    }
    PrintArray(numbers);
}
Zadacha54();
Zadacha56();
Spiral();
Multiplication();