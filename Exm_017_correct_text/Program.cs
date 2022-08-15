// Замена в тексте все пробелы на "-", к на К, С на с.

string Replace (string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int Length = text.Length;
    for (int i = 0; i < Length; i++)
    {
        if (text[i] == oldValue) result = result + newValue;
        else result = result + text[i];
    }
    return result;
}

string text = "Я к вам пишу — чего же боле?" + 
                "Что я могу еще сказать?" +
                "Теперь, я знаю, в вашей воле" +
                "Меня презреньем наказать."+
                "Но вы, к моей несчастной доле"+
                "Хоть каплю жалости храня,"+
                "Вы не оставите меня."+
                "Сначала я молчать хотела;"+
                "Поверьте: моего стыда"+
                "Вы не узнали б никогда,"+
                "Когда б надежду я имела"+
                "Хоть редко, хоть в неделю раз"+
                "В деревне нашей видеть вас,"+
                "Чтоб только слышать ваши речи,"+
                "Вам слово молвить, и потом"+
                "Все думать, думать об одном"+
                "И день и ночь до новой встречи.";

// string newText = Replace(text, " ", "|");
// Console.WriteLine(newText);

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'C', 'c');
Console.WriteLine(newText);