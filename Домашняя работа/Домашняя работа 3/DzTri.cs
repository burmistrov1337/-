Console.Write("Введите число N");
string Number = Console.ReadLine();
Console.WriteLine();
bool LetterInNumbers(string let)
{
    int n = let.Length;
    bool yes = true;
    
        for (int i = 0; i < n; i++)
        {
            if (Char.IsDigit(let[i]) == false)
            {
                yes = false;
                return yes;
            }
        }
        return yes;
}

void TableCubeNumbers(int num)
{
    Console.WriteLine("Число\t Куб числа");
    
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine("{0}\t{1}", i, Math.Pow(i, 3));
    }
}

void Break()
{
    Console.WriteLine("{0} -> Некорректный ввод", Number);
}

bool letter = LetterInNumbers(Number);
int Numbers;
if (letter == true)
{
    Numbers = Convert.ToInt32(Number);
    if (Numbers > 0)
    {
        Console.WriteLine($"Таблица кубов чисел от 1 до {Number}.");
        Console.WriteLine();
        TableCubeNumbers(Numbers);
    }
    else Break();
}
else Break();