// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int PrintNatural(int M, int N)
{
    if (M <= N)
    {
        return M + PrintNatural(M+1,N);
    }
    return 0;
}
int M = 1;
int N = 15;
Console.Write(PrintNatural(M,N));
