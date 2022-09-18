Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 % 2 == 0)
{
    Console.WriteLine("Число " + number1 + " чётное");
}
else
{
    Console.WriteLine("Число " + number1 + " нечётное");
}