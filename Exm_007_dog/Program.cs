double firstFriendSpeed = 1;
double secondFriendSpeed = 2;
double dogSpeed = 5;
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

Console.Write("Собака пробежит:" + index + " раз.");
