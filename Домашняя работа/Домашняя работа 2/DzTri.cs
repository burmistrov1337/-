Console.Write("Введите цифру, обозначающую день недели");
int dayWeek = Convert.ToInt32(Console.ReadLine());

if (dayWeek == 6 || dayWeek == 7)
{
    Console.WriteLine("{0} -> Это выходной день", dayWeek);
}
else if (dayWeek >= 1 && dayWeek <= 5)
{
    Console.WriteLine("{0} -> Это будний день", dayWeek);
}
else
{
    Console.WriteLine("{0} -> Нет такого дня недели", dayWeek);
}