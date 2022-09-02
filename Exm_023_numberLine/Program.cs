// Собрать строку с числами от a до b, a ≤ b
string SumNumbersLine(int a, int b)
{
    string result = string.Empty;

    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string SumNumbersLineRecursion(int a, int b)
{
    if (a<=b) return $"{a} " + SumNumbersLineRecursion(a+1, b);
    else return string.Empty;
}

// Собрать строку с числами от a до b, a ≥ b

// int a = 2;
// int b = 8;

// string SumNumbersLine(int a, int b)
// {
//     string result = string.Empty;

//     for (int i = b; i >= a; i--)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// string SumNumbersLineRecursion(int a, int b)
// {
//     if (a <= b) return SumNumbersLineRecursion(a + 1, b) + $"{a} ";
//     else return string.Empty;
// }

// Console.WriteLine(SumNumbersLine(a, b));
// Console.WriteLine(SumNumbersLineRecursion(a, b));