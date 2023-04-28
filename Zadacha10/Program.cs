int digit(int arg) 
{
    return arg / 10 % 10;
}

Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{n} -> {digit(n)}");