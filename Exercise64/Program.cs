Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "");

PrintNaturals(N);

void PrintNaturals(int N)
{
    if(N>0)
    {
        Console.Write($"{N}, ");
        PrintNaturals(N-1);
    }
}
