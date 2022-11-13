
Console.Write("Введите число M: ");
int num1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число N: ");
int num2 = int.Parse(Console.ReadLine() ?? "");

Function(num1, num2);


void Function(int num1, int num2)
{
    Console.Write(CalculateFunction(num1, num2));
}

int CalculateFunction(int num1, int num2)
{
    if (num1 == 0)
    {
        return num2 + 1;
    }
    else if (num1 >0 &&  num2 == 0)
    {
        return CalculateFunction(num1 - 1, 1);
    }
    else
    {
        return (CalculateFunction(num1 - 1, CalculateFunction(num1, num2 - 1)));
    }
}
