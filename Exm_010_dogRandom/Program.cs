double firstFriendSpeed = new Random().Next(1, 3);
double secondFriendSpeed = new Random().Next(2, 4);
double dogSpeed = new Random().Next(3, 7);
double distance = new Random().Next(10000, 17000);
double distanceRuls = distance;
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

Console.WriteLine("Если:");
Console.WriteLine($"- скорость первого друга: {firstFriendSpeed};");
Console.WriteLine($"- скорость второго друга: {secondFriendSpeed};");
Console.WriteLine($"- скорость собаки: {dogSpeed};");
Console.WriteLine($"- дистанция: {distanceRuls};");
Console.WriteLine($"Собака пробежит между друзьями {index} раз.");