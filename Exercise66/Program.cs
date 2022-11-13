
Console.Write("Введите число M: ");
int num1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число N: ");
int num2 = int.Parse(Console.ReadLine() ?? "");

if (num1 < num2)
{
    Sum(num1, num2);
}
else
{
    Console.WriteLine($"Вывод невозможен, {num1} больше {num2}");
}

void Sum(int num1, int num2)
{
    Console.Write(CalculateSum(num1 - 1, num2));
}

int CalculateSum(int num1, int num2)
{
    int res = num1;
    if (num1 == num2)
        return 0;
    else
    {
        num1++;
        res = num1 + CalculateSum(num1, num2);
        return res;
    }
}
