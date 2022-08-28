Console.Write("Введите число");
int number = int.Parse(Console.ReadLine());
int remain = number % 2;
if (remain == 0)
{
    Console.WriteLine("Число " + number + " четное");
}
else
{
    Console.WriteLine("Число " + number + " нечетное");
}