// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
Console.WriteLine("Введите ганицы итервала");
int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);

int SumNumbersMToN(int number1, int number2)
{
    if (number1 == number2)
    {
        return number1;
    }
    return (number1 + SumNumbersMToN(number1 + 1, number2));
}

if(m < n)
{
    Console.WriteLine(SumNumbersMToN(m, n));
}

else
{
    Console.WriteLine(SumNumbersMToN(n, m));
}