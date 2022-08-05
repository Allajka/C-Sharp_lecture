int a = new Random().Next(0, 9);
int b = new Random().Next(0, 9);
int c = new Random().Next(0, 9);
int d = new Random().Next(0, 9);
int e = new Random().Next(0, 9);

int max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("Максимальное число, среди чисел: " + a + ", "+ b + ", "+ c + ", "+ d + ", "+ e + " = " + max);