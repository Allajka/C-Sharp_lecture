Console.Write("Введите ваше имя: ");
string userName = Console.ReadLine();

if (userName.ToLower() == "маша" || userName.ToLower() == "мария" )
{
    Console.WriteLine("Ура это Маша!");
}
else
{
    Console.WriteLine("Hello, " + userName + "!");
}
