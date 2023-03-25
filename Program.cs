// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше, либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


int numberOfElements = EnterTheNumber("Введите количество слов в изначальном массиве");             // ввод количества слов в изначальном массиве, который будет проверяться
string[] homeWork = FillArrayOfStrings(numberOfElements);                                           // заполнение массива, который будет проверяться
int size = EnterTheNumber("Введите длину, равную или меньше которой надо найти слова в" +           // задается длина слов, которые надо выбрать
                            " проверяемом массиве");          
int length = FindNumberOfRightWords(homeWork, size);                                                // нахождение количества слов заданной длины
string[] result_array = CreateResultArray(homeWork, size, length);                                  // создаётся итоговый массив и заполняется найденными словами нужной длины
Console.WriteLine($"[{string.Join(", ", homeWork)}] -> [{string.Join(", ", result_array)}]");       // вывод итогового массива


// Метод заполнения итогового массива из строк,
// длина которых меньше, либо равна заданному числу символов
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

// Метод, который находит количество подходящих слов в изначальном массиве
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

// Метод ввода целого числа с проверкой корректности ввода
int EnterTheNumber(string _message)
{
    int count;
    Console.WriteLine(_message);
    bool correct_count = int.TryParse(Console.ReadLine(), out count);

    if (!correct_count)
    {
        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
        return EnterTheNumber(_message);
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
