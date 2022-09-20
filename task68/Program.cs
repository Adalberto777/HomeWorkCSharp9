// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n
Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine()!);

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));  
}

Console.WriteLine(AkkermanFunction(m, n));


