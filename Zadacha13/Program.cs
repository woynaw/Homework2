int digit(int arg)
{
    while (arg > 999)
    {
        arg /= 10;
    }
    return arg % 10;
}

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
if (n >= 100) Console.WriteLine($"{n} -> {digit(n)}");
else Console.WriteLine("Третьей цифры нет");
