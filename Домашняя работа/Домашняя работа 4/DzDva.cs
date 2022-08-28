Console.Write("Введите число");
string Numbers = Console.ReadLine();
int SumNumbersInNumber(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum = sum + (num % 10);
        num = num / 10;
    }
    return sum;
}

void ExceptionHandling(string enterA)
{
    bool yesInt = int.TryParse(enterA, out int result);

    if (yesInt && result >= 0)
    {
        int sumResult = SumNumbersInNumber(result);
        Console.WriteLine("Сумма цифр числа {0} = {1}",
                          result, sumResult);
    }
    else
    {
        Console.WriteLine("{0} -> Некорректный ввод", Numbers);
    }
}

ExceptionHandling(Numbers);