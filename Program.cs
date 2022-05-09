// Итоговая проверочная работа

string[] stringsArray = {"hello", "2", "world", "The", "1234", "1567","sun", "had", "consulting", "journal",
                     "set", "Mark", "but", "was", "computer science", "not", "out", "Russia", "yet", "-2",
                     ":-)", "Denmark", "Kazan"};

// Метод для поиска строк с количеством символов меньше или равным 3
int CountShortStrings(string[] array)
{
    // Инициализируем переменную для подсчёта количества искомых строк
    int count = 0;  

    // Поиск и подсчёт искомых строк
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

// Метод для формирования и заполнения нового массива с количеством символов меньше или равным 3
string[] FillShortStringsArray (int shortStringsNumber, string[] array)
{
    // Инициализируем массив для записи в него искомых строк
    string[] shortStringsArray = new string[shortStringsNumber];

    // Инициализируем переменную для использования при индексировании нового массива
    int index = 0;

    // Заполнение нового массива искомыми строками
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            shortStringsArray[index] = array[i];
            index++;
        }
    }
    // Возвращаем массив сформированный из строк с количеством символов меньше или равным 3
    return shortStringsArray;
}

FillShortStringsArray(CountShortStrings(stringsArray), stringsArray);