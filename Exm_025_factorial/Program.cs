// Факториал числа
int factorial (int N)
{
    if(N == 0 || N == 1) return 1;
    int result = 1;
    for (int i = 2; i <= N; i++)
    {
        result *= i;
    }
    return result;
}

int factorialRecursion (int N)
{
    if(N == 0 || N == 1) return 1;
    else return N * factorialRecursion(N-1);
}

int N = 10;
Console.WriteLine(factorial(N));
Console.WriteLine(factorialRecursion(N));