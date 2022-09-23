void Zadacha19()
{
    Console.WriteLine("Задача о палиндроме");
    Console.WriteLine("Введите пятизначное число");
    int second;
    int fourth;
    int number = Convert.ToInt32(Console.ReadLine());
    if (Math.Abs(number) > 99999 || Math.Abs(number) < 10000)
    {
        Console.WriteLine("Число не является пятизначным");
    }
    else
    {
        second = (number / 1000) % 10;
        fourth = number / 10;
        if (number / 10000 == number % 10 && second == fourth % 10)
        {
            Console.WriteLine("Введенное число является палиндромом");
        }
        else
        {
            Console.WriteLine("Введенное число не является палиндромом");
        }

    }
}

// № 21 с ручным вводом координат точек
void Zadacha21Input()
{
    Console.WriteLine("Нахождение расстояния между точками");
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
    double D = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));
    Console.WriteLine("Расстояние между точками  D = "  + D);
}

// № 21 с автоматическим вводом координат случайных координат точкек А и В
void Zadacha21Random()
{
    Console.WriteLine("Нахождение расстояния между двумя случайными точками");
    Random random = new Random();
    int x1 = random.Next(-10,10);
    int y1 = random.Next(-10,10);
    int z1 = random.Next(-10,10);
    int x2 = random.Next(-10,10);
    int y2 = random.Next(-10,10);
    int z2 = random.Next(-10,10);
    Console.WriteLine ($"A({x1},{y1},{z1}), B({x2},{y2},{z2})");
    double d = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));
    Console.WriteLine("Расстояние между точками A и В  d = "  + d);
}


void Zadacha23()
{
    Console.WriteLine("Вывод таблицы кубов чисел до заданного числа");
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


void DopZadacha1()
{
    Console.WriteLine("Значение Х при заданном Y");
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
    Console.WriteLine("При х = " + x + ", y = " + y);
}


void DopZadacha2()
{
    Console.WriteLine("Кратность 3 суммы цифр заданного числа");
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


void DopZadacha3()
{
    Console.WriteLine("Нахождение цифр 4 и 7 в трехзначном числе");
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
                Priznak4 = 1;
            } 
            if (array[i] == 7) 
            {
                Priznak7 = 1;
            }
        }
        if (Priznak4 == 0 && Priznak7 == 0)
        {
            Console.WriteLine("Число не содержит цифр 4 и 7");
        }
        else 
        {
            if (Priznak4 == 1)
            {
                Console.WriteLine("Число содержит цифру 4");
            }
            if (Priznak7 == 1)
            {
                Console.WriteLine("Число содержит цифру 7");
            }
        }
    }
}

void DopZadacha4()
{
    Console.WriteLine("Заполнение массива");
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

Zadacha19();
Zadacha21Input();
Zadacha21Random();
Zadacha23();
DopZadacha1();
DopZadacha2();
DopZadacha3();
DopZadacha4();