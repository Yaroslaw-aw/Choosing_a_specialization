// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше, либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.










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
        words[i] = Input("Введите следующую строку");
    Console.WriteLine();
    return words;
}


// Метод заполнения строки
string Input(string message)
{
    string str = Console.ReadLine();
    return str;
}