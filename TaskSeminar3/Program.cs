void Zadacha19()
{
    Console.WriteLine("Введите пятизначное число");
    int number = Convert.ToInt32(Console.ReadLine());
    if (Math.Abs(number) > 99999 || Math.Abs(number) < 10000)
    {
        Console.WriteLine("Число не пятизначное");
    }
    else
    {
        int two = (number / 1000) % 10;
        int four = number / 10;
        if (number / 10000 == number % 10 && two == four % 10)
        {
            Console.WriteLine("Введенное число является палиндромом");
        }
        else
        {
            Console.WriteLine("Введенное число не является палиндромом");
        }

    }
}
Zadacha19();

void Zadacha21Input()
{
    Console.WriteLine("Введите координату х первой точки");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату y первой точки");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату z первой точки");
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату х второй точки");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату y второй точки");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату z второй точки");
    int z2 = Convert.ToInt32(Console.ReadLine());
    double R = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));
    Console.WriteLine("Расстояние между точками = "  + R);
}
Zadacha21Input();

void Zadacha21Random()
{
    Random random = new Random();
    int x1 = random.Next(-10,10);
    int y1 = random.Next(-10,10);
    int z1 = random.Next(-10,10);
    int x2 = random.Next(-10,10);
    int y2 = random.Next(-10,10);
    int z2 = random.Next(-10,10);
    Console.WriteLine ($"A({x1},{y1},{z1}), B({x2},{y2},{z2})");
    double R = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));
    Console.WriteLine("Расстояние между точками A и В = "  + R);
}
Zadacha21Random();

void Zadacha23()
{
    Console.WriteLine("Введите число");
    int N = Convert.ToInt32(Console.ReadLine());
    int i = 1;
    double cube;
    Console.WriteLine("Число    Куб числа");
    while (i <= N)
    {
        cube = Math.Pow(i, 3);
        Console.WriteLine($"  {i}          {cube}");
        i++;
    }
}
Zadacha23();

void DopZadacha1()
{
    Console.WriteLine("Введите число");
    float x = Convert.ToInt32(Console.ReadLine());
    double y;
    if (x > 0)
    {
        y = Math.Sin(x) * Math.Sin(x);
    }
    else
    {
        y = 1 - 2*Math.Sin(Math.Pow(x, 2));
    }
    Console.WriteLine(y);
}
DopZadacha1();

void DopZadacha2()
{
    Console.WriteLine("Введите трёхзначное число");
    int number = Convert.ToInt32(Console.ReadLine());
    if (Math.Abs(number) > 999 || Math.Abs(number) < 100)
    {
        Console.WriteLine("Число не трёхзначное");
    }
    else
    {
        int num1 = number / 100;
        int num2 = (number / 10) % 10;
        int num3 = number % 10;
        if ((num1 + num2 + num3) % 3 == 0)
        {
            Console.WriteLine("Сумма цифра этого числа  кратна 3"); 
        }   
        else
        {
            Console.WriteLine("Сумма цифра этого числа не кратна 3"); 
        }    
    }
}
DopZadacha2();

void DopZadacha3()
{
    Console.WriteLine("Введите трёхзначное число");
    int number = Convert.ToInt32(Console.ReadLine());
    if (Math.Abs(number) > 999 || Math.Abs(number) < 100)
    {
        Console.WriteLine("Число не трёхзначное");
    }
    else
    {
        int num1 = number / 100;
        int num2 = (number / 10) % 10;
        int num3 = number % 10;
        int[] array = {num1, num2, num3};
        int length = array.Length;
        int Priznak4 = 0;
        int Priznak7 = 0;
        for (int i = 0; i < length; i++)
        {
            if (array[i] == 4)
            {
                Console.WriteLine("Число содержит цифру 4");
                Priznak4 = 1;
            } 
            if (array[i] == 7) 
            {
                Console.WriteLine("Число содержит цифру 7"); 
                Priznak7 = 1;
            }
        }
        if (Priznak4 == 0 && Priznak7 == 0)
        {
            Console.WriteLine("Число не содержит цифр 4 и 7");
        } 
    }
}
DopZadacha3();

void DopZadacha4()
{
    int [] array = new int[10];
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = index + 1;
        Console.WriteLine(array[index]);
        index++;
    }
}
DopZadacha4();
