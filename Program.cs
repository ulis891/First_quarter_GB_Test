// Итоговая проверочная работа

string[] wordArray = {"hello", "2", "world", "The", "1234", "1567","sun", "had", "consulting", "journal",
                     "set", "Mark", "but", "was", "computer science", "not", "out", "Russia", "yet", "-2",
                     ":-)", "Denmark", "Kazan"};

// Метод для поиска сторк с колличеством символов меньше или раным 3
string[] FindShortStrings(string[] array)
{
    // Инициализируем переменную для подсчёта колличества искомых строк
    int index = 0;  

    // Поиск и подсчёт искомых строк
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) index++;
    }

    // Инициализируем массив для записи в него искомых строк
    string[] shortStringsArray = new string[index];
    // Обнуляем переменную index для использования при индексировании нового массива
    index = 0;

    // Заполнение нового масиваа искомыми строками
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            shortStringsArray[index] = array[i];
            index++;
        }
    }
    return shortStringsArray;
}




void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


PrintArray(FindShortStrings(wordArray));