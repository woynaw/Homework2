bool Weekend(int arg)
{
    if (arg > 5) return true;
    else return false;
}
bool Check(int arg)
{
    if (arg > 1 && arg <= 7) return true;
    else
    {
        Console.WriteLine("Ошибка ввода");
        return false;
    }
}

Console.WriteLine("Введите день недели");
int day = Convert.ToInt32(Console.ReadLine());
if (Check(day))
{
    if (Weekend(day)) Console.WriteLine($"{day} -> Да");
    else Console.WriteLine($"{day} -> Нет");
}