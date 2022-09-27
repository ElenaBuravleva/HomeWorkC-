void Zadacha25()
{
    Console.WriteLine("Возведение числа А в степень В");
    Console.WriteLine("Введите натуральное число");
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    Console.WriteLine("Введите степень числа");
    int pow = Convert.ToInt32(Console.ReadLine());
    if (number <= 0 || pow <= 0)
    {
        Console.WriteLine("Вы ввели число, не явлющееся натуральным");
    }
    int pownumber = number;
    for (int i = 2; i <= Math.Abs(pow); i++)
    {
        pownumber = pownumber * number;
    }
    Console.Write($"{number} в {pow} степени равно {pownumber}");
    Console.WriteLine();
}
Zadacha25();

void Zadacha27()
{
    Console.WriteLine("Нахождение суммы всех цифр числа");
    Console.WriteLine("Введите число");
    string size = Console.ReadLine();
    int number = Math.Abs(Convert.ToInt32(size));
    int sum = 0;
    for (int i = 0; i < size.Length; i++)
    {
        int Post = number % 10;
        sum = sum + Post;
        number = number / 10;
    }
    Console.WriteLine("Сумма всех цифр числа: " + sum);
    Console.WriteLine();
}
Zadacha27();

void Zadacha29()
{
    Console.WriteLine("Сортировка массива по модулю");
    int [] numbers = new int[8];
    FillArray(numbers);
    PrintArray(numbers);
    Console.Write(" -> ");
    SortArray(numbers);
    PrintArray(numbers);
}

void FillArray(int[] num)
{
    Random random = new Random();
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = random.Next(-100,100);
    }
}

void SortArray(int[] num)
{
    for (int i = 0; i < num.Length - 1; i++)
    {
        int minposition = i;
        for (int j = i + 1; j < num.Length; j++)
        {
            if (Math.Abs(num[j]) < Math.Abs(num[minposition]))
            {
                minposition = j;
            }
        }
        int temp = num[i];
        num[i] = num[minposition];
        num[minposition] = temp;
    }
}
void PrintArray(int[] num)
{
    Random random= new Random();
    Console.Write("[");
    for (int i = 0; i < num.Length - 1; i++)
    {
        Console.Write(num[i] + ",");
    }
    Console.Write(num[num.Length - 1] + "]");
}
Zadacha29();