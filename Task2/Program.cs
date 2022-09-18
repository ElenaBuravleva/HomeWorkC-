Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());
int Max = number1;
if (Max < number2)
{
    Max = number2;
    if (Max < number3)
    {
        Max = number3;
    }
}
else if (Max < number3)
{
    Max = number3;
}
Console.WriteLine("Максимум из трех чисел: " + Max);