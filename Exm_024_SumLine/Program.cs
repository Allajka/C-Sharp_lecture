// Сумма чисел от 1 до n

int SumNumbers(int lastNumber)
{
    if (lastNumber == 0 ) return 0;
    int result = 1;
    for (int i = 2; i <= lastNumber; i++)
    {
        result += i;
    }
    return result;
}

int SumNumbersRecursion(int lastNumber)
{
    if (lastNumber == 0 ) return 0;
    else return lastNumber + SumNumbersRecursion(lastNumber - 1);
}

int N = 10;
Console.WriteLine(SumNumbers(N));
Console.WriteLine(SumNumbersRecursion(N));