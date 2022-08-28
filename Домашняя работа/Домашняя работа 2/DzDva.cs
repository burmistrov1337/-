Console.Write("Введите число");
string Number = Console.ReadLine();

char[] NumberArray = number.ToCharArray();
if (NumberArray.Length >= 3)
{
    Console.Write($"{Number} -> {NumberArray[2]}");
}
else
{
    Console.Write($"{Number} -> третьей цифры нет");
}