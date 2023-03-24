// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше, либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.




int numberOfElements = EnterTheCountOfStrings("Введите количество слов в изначальном массиве");     // ввод количества слов в изначальном массиве, который будем проверять
string[] homeWork = FillArrayOfStrings(numberOfElements);                                           // заполнение изначального массива
int size = EnterTheCountOfStrings("Введите длину слов, которые надо найти в изначальном массиве");  // задается длина слов, которые надо выбрать
int length = FindNumberOfRightWords(homeWork, size);                                                // находится количество слов заданной длины
string[] result_array = CreateResultArray(homeWork, size, length);                                  // создаётся итоговый массив и заполняется найденным словами нужной длины
Console.WriteLine($"[{string.Join(", ", homeWork)}] -> [{string.Join(", ", result_array)}]");   // вывод итогового массива




// Метод заполнения итогового массива из строк, длина которых меньше, либо равна 3 элементам
string[] CreateResultArray(string[] _array,  int _size, int _length = 0)
{
    string[] _array_result = new string[_length];
    int count = 0;
    foreach (string s in _array)
    {
        if (s.Length <= _size)
        {
            _array_result[count] = s;
            count++;
        }
    }
    return _array_result;
}


// Метод, который находит число подходящих слов в изначальном массиве
int FindNumberOfRightWords(string[] _array, int _size)
{    
    int count = 0;     
    foreach (string s in _array)
    {
        if (s.Length <= _size)
            count++;
    }
    return count;    
}

// Метод ввода количества элементов массива с проверкой корректности ввода
int EnterTheCountOfStrings(string _message)
{
    int count;
    Console.WriteLine(_message);
    bool correct_count = int.TryParse(Console.ReadLine(), out count);

    if (!correct_count)
    {
        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
        return EnterTheCountOfStrings(_message);
    }
    else
    {
        return count;
    }
}

// Метод заполнения массива строками
string[] FillArrayOfStrings(int _length)
{
    string[] words = new string[_length];
    for (int i = 0; i < _length; i++)
    {
        words[i] = Input("Введите следующую строку");
        //Console.WriteLine();
    }
    return words;
}


// Метод заполнения строки
string Input(string message)
{
    Console.WriteLine(message);
    string str = Console.ReadLine();
    return str;
}