//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача? ( что значит дан текст? Что значит черточками? Какой алфавит?)






string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = “qwerty”
// 012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}"; // если текст совпал с текстом оторое хотим заменить, то вкладываем новое значение
        else result = result + $"{text[i]}"; // иначе совпадения нет, то в reault  добавляем тот же символ
    }
    return result;
}

string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(text, 'к', 'К');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'С', 'с');

Console.WriteLine(newText);



