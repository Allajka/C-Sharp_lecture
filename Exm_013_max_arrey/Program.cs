// максимум из 9 чисел

int max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = {16, 28, 34, 54, 85, 16, 68, 25, 36};
int maxi = max(
    max(array[0], array[1], array[2]),
    max(array[3], array[4], array[5]), 
    max(array[6], array[7], array[8])
);

Console.WriteLine($"max = {maxi}");