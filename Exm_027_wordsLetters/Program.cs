/* Перебор слов
В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из T букв, 
которые можно построить из букв этого алфавита */

// char[] letters = { 'a', 'и', 'с', 'в' };
// int serialNumber = 1;
// for (int i = 0; i < letters.Length; i++)
// {
//     for (int j = 0; j < letters.Length; j++)
//     {
//         Console.WriteLine($"{serialNumber++,-5} {letters[i]}{letters[j]}");
//     }
// }

// int t = 5;

// for (int i = 0; i < Math.Pow(letters.Length, t); i++)
// {
//     Console.WriteLine($"{serialNumber++,-5} {letters[i]}{letters[i]}");
// }

int[] playerNumbers = { 0, 1, 2, 3, 4 };
int allTeams = 2;

for (int i = 0; i < Math.Pow(playerNumbers.Length, allTeams); i++)
{
    int binarySystem = 0;
    if (i == 0) binarySystem = 00000;
    Console.WriteLine("{0,-2} {1}", i, string.Format("{0:f5}", binarySystem));
}




