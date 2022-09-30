void Zadacha34()
{
    Console.WriteLine("_____________________________________________");
    Console.WriteLine("_____________________________________________");
    Console.WriteLine("Задача 34");
    Random random = new Random();
    int size = random.Next(2,20);
    int[] numbers = new int [size];
    FillArray(numbers,99,1000);
    Console.WriteLine("В массиве трехзначных чисел размерностью " + size);
    PrintArray(numbers);
    Console.WriteLine();
    CounterEven(numbers);
    Console.WriteLine();
    Console.WriteLine("_____________________________________________");
    Console.WriteLine("_____________________________________________");
}

void FillArray(int[] numbers, int min, int max)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(min,max);
    }
}

void CounterEven(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            count++;
        }
    }
    if (count == 0) Console.Write("не содержится четных элементов");
    if (count == 1) Console.Write("содержится " + count + " четный элемент");
    if (count > 1 && count < 5) Console.Write("содержится " + count + " четных элемента");
    else Console.Write("содержится " + count + " четных элементов");
}

void PrintArray(int[] numbers)
{
    Console.Write("[");
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        Console.Write(numbers[i] + ",");
    }
    Console.Write(numbers[numbers.Length - 1] + "]");
}

void Zadacha36()
{
    Console.WriteLine("Задача 36");
    Random random = new Random();
    int size = random.Next(2,20);
    int[] numbers = new int [size];
    FillArray(numbers,-10000,10001);
    Console.WriteLine("В массиве случайных чисел размерностью " + size);
    PrintArray(numbers);
    Console.WriteLine();
    SumOddIndex(numbers);
    Console.WriteLine();
    Console.WriteLine("_____________________________________________");
    Console.WriteLine("_____________________________________________");
}

void SumOddIndex(int[] numbers)
{
    int sumoddnumbers = 0;
    int i = 1;
    while (i < numbers.Length)
    {
        sumoddnumbers += numbers[i];
        i += 2;  
    }
    if (sumoddnumbers == 0) Console.Write("нет нечётных элементов");
    Console.Write("сумма всех нечётных элементов = " + sumoddnumbers);
}

void Zadacha38()
{
    Console.WriteLine("Задача 38");
    Random random = new Random();
    int size = random.Next(2,20);
    double[] numbers = new double [size];
    FillArray1(numbers);
    Console.WriteLine("Массив случайных вещественных чисел размерностью " + size);
    PrintArray1(numbers);
    Console.WriteLine();
    MinMax(numbers);
}

void FillArray1(double[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        int a = 1;
        numbers[i] = random.NextDouble();
        a = random.Next(0,2);
        if (a == 0) numbers[i] = -1000 * numbers[i];
        else numbers[i] = 1000 * numbers[i];
    }
}

void MinMax(double[] numbers)
{
    double min = numbers[0];
    double max = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (min > numbers[i]) min = numbers[i];
        if (max < numbers[i]) max = numbers[i];
    }
    Console.WriteLine("Мin = " + min);
    Console.WriteLine("Мax = " + max);
    Console.WriteLine($"Мax - Min  = {max - min}");
}

void PrintArray1(double[] numbers)
{
    Console.Write("[");
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        Console.Write(numbers[i] + ",");
    }
    Console.Write(numbers[numbers.Length - 1] + "]");
}

Zadacha34();
Zadacha36();
Zadacha38();