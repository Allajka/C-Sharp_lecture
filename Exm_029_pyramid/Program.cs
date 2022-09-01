// Игра в пирамидки
void Pyramid(string first = "1", string end = "3", string middle = "2", int allStick = 5)
{
    if (allStick > 1) Pyramid(first, middle, end, allStick - 1);
    System.Console.WriteLine($"{first} >> {end}");
    if (allStick > 1) Pyramid(middle, end, first, allStick - 1);
}

Pyramid();