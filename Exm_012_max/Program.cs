// максимум из 9 чисел

int max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 15, b1 = 21, c1 = 39,
    a2 = 12, b2 = 223, c2 = 33,
    a3 = 13, b3 = 23, c3 = 33;

//int max1 = max(a1, b1, c1);
//int max2 = max(a2, b2, c2);
//int max3 = max(a3, b3, c3);
//int max4 = max(max1, max2, max3);

int maxi = max(max(a1, b1, c1),
            max(a2, b2, c2), 
            max(a3, b3, c3));

Console.WriteLine($"max = {maxi}");