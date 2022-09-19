Console.WriteLine("Введите положительное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0)
{
    Console.WriteLine("Вы ввели отрицательное число либо 0");
}
else 
{
    int count = 2;
    while (count <= number)
    {
        Console.WriteLine(count);
        count = count + 2;
    }
}