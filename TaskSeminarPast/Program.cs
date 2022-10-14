void Zadacha64()
{
    Console.WriteLine("______________________________________");
    Console.WriteLine("Числа кратные 3 в промежутке от M до N");
    Console.WriteLine("Введите M");
    int numberM = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите N");
    int numberN = Convert.ToInt32(Console.ReadLine());
    if (numberM >= numberN) Console.WriteLine("Неверно задан промежуток");
    else
    {
        if (numberN < 3) Console.WriteLine("Чисел кратных 3 в указанном промежутке нет");
        else
        {
            Console.WriteLine($"Числа кратные 3 в промежутке от {numberM} до {numberN}:");
            FindNaturalMultiple3(numberN, numberM);
        }
    }
}

void FindNaturalMultiple3(int numberN, int counter = 1)
{
    if (counter % 3 == 0) Console.WriteLine(counter);
    counter++;
    if (counter > numberN) return;
    FindNaturalMultiple3(numberN, counter);
}

void Zadacha66()
{
    Console.WriteLine("______________________________________");
    Console.WriteLine("Сумма элементов в промежутке от M до N");
    Console.WriteLine("Введите M");
    int numberM = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите N");
    int numberN = Convert.ToInt32(Console.ReadLine());
    if (numberM >= numberN) Console.WriteLine("Неверно задан промежуток");
    else SumNaturalElements(numberN, numberM);
}

void SumNaturalElements(int numberN, int stepM, int sum = 0)
{
    sum += stepM;
    stepM++;
    if (stepM > numberN)
    {
        Console.WriteLine($"Сумма элементов: {sum}");
        return;
    }
    SumNaturalElements(numberN, stepM, sum);
}

void Zadacha68()
{
    Console.WriteLine("_________________");
    Console.WriteLine("Функция Аккермана");
    Console.WriteLine("Введите m");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите n");
    int n = Convert.ToInt32(Console.ReadLine());
    if (m < 0 || n < 0) Console.WriteLine("Задайте положительные числа");
    else Console.WriteLine($"A({m},{n}) = {Accerman(m, n)}");
}

int Accerman(int m, int n)
{

    if (m == 0) return n + 1;
    if (n == 0) return Accerman(m - 1, 1);
    if (m > 0 && n > 0)
    {
        n = Accerman(m, n - 1);
        return Accerman(m - 1, n);
    }
    return 0;
}

Zadacha64();
Zadacha66();
Zadacha68();

