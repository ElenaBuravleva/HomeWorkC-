Console.WriteLine("Введите положительное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    Console.WriteLine("Вы ввели отрицательное число");
}
else 
{
    int count = 0;
    while (count <= number)
    {
        Console.WriteLine(count);
        count = count + 2;
    }
}