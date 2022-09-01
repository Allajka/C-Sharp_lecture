/* Перебор слов
В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из T букв, 
которые можно построить из букв этого алфавита */
int n = 1;
void PrintWordsFromLettersRecursion(string alphabet, char[] word, int length = 0) // передаем строкой алфавит, новое слово в массив char, если размер и размер массива совпало, показываем слово
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}");
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        PrintWordsFromLettersRecursion(alphabet, word, length + 1);
    }
}

void PrintWordsFromLetters(char[] arr)
{
    int counterNumber = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length; j++)
        {
            for (int k = 0; k < arr.Length; k++)
            {
                Console.WriteLine($"{counterNumber++,-5} {arr[i]}{arr[j]}{arr[k]}");
            }
        }
    }
}

char[] letters = { 'a', 'и', 'с', 'в' };
string alphabet = "аисв";
// PrintWordsFromLetters(letters);
PrintWordsFromLettersRecursion(alphabet: alphabet, word: new char[5]);





