// Итоговая проверочная работа

string[] wordArray = {"hello", "2", "world", "The", "1234", "1567","sun", "had", "consulting", "journal",
                     "set", "Mark", "but", "was", "computer science", "not", "out", "Russia", "yet", "-2", 
                     ":-)", "Denmark", "Kazan"};

// Метод для поиска сторк с колличеством символов меньше или раным 3
string[] FindShortStrings (string[] array)
{
    int index = 0;  // Инициализируем переменную для подсчёта колличества искомых строк

    // Поиск и подсчёт искомых строк
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) index++;
    }

    string[] shortWordArray = new string [index];  // Инициализируем массив для записи в него искомых строк
    index = 0;  // Обнуляем переменную index для использования при индексировании нового массива

    // Заполнение нового масиваа искомыми строками
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {   
            shortWordArray[index]= array[i];
            index++;
        }
    }
    return shortWordArray;
}




void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


PrintArray(FindShortStrings(wordArray));