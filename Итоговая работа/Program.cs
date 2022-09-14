// Первый елемент массива:
Console.Write("Введите первый элемент массива: ");
string firstElement = Console.ReadLine();

// Второй елемент массива:
Console.Write("Введите второй элемент массива: ");
string secondElement = Console.ReadLine();

// Третий елемент массива:
Console.Write("Введите третий элемент массива: ");
string thirdElement = Console.ReadLine();

Console.WriteLine("Результат: ");

string[] array1 = new string[3] { firstElement, secondElement, thirdElement };
string[] array2 = new string[array1.Length];
void FindElement(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i += 1)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count += 1;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i += 1)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FindElement(array1, array2);
PrintArray(array2);