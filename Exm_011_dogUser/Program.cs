Console.WriteLine("Программа позволяет решить, сколько раз пробежит собака между двумя друзьями.");
Console.Write("Введите скорость первого друга: ");
double firstFriendSpeed = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость второго друга: ");
double secondFriendSpeed = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите собаки друга: ");
double dogSpeed = Convert.ToInt32(Console.ReadLine());

double distance = 10000;
double friend = 2;
double index = 0;
double time = 0;

while (distance > 10)
{
    if (friend==1)
        {
        time = distance/(secondFriendSpeed + dogSpeed);
        friend = 2;
        }
    else
        {
        time = distance/(firstFriendSpeed + dogSpeed);
        friend = 1;
        }
    distance = distance - (firstFriendSpeed + secondFriendSpeed)*time;
    index = index + 1;
}

Console.WriteLine($"Собака пробежит между друзьями {index} раз.");
