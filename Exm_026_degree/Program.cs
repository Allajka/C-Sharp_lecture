// Вычислить а^n

int Degree(int number, int degree)
{
    int result = 1;
    for (int i = 0; i < degree; i++) result *= number;
    return result;
}

int DegreeRecursion(int number, int degree)
{
    return degree == 0 ? 1 : DegreeRecursion(number, degree - 1) * number;
}

int DegreeRecursionBetter(int number, int degree)
{
    if ( degree == 0) return 1;
    else if (degree % 2 == 0) return DegreeRecursionBetter(number * number, degree /2);
    else return DegreeRecursionBetter(number, degree -1) * number;
}

int a = 2;
int n = 5;
Console.WriteLine(Degree(a, n));
Console.WriteLine(DegreeRecursion(a, n));
Console.WriteLine(DegreeRecursionBetter(a, n));