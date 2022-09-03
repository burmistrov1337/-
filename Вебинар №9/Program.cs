Console.Write("Введите натуральное число N: ");
string N = Console.ReadLine();

var count = ExceptionHandling(N);

if (count.exception && count.number >= 0)
{
    Numbers(count.number);
}
else
{
    Console.WriteLine($"{N} -> Не является натуральным числом.");
}

void Numbers(int last)
{
    if (last == 0)
    {
        return;
    }
    Console.Write($"{last} ");
    Numbers(last - 1);
}

(bool exception, int number) ExceptionHandling(string number)
{
    bool yesInt = int.TryParse(number, out int d);
    if (!yesInt)
    {
        return (false, d);
    }
    return (true, d);
} 



