// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше, либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.





// Метод ввода количества элементов массива с проверкой корректности ввода
int EnterTheCountOfStrings(string message)
{
    int count;
    bool correct_count = int.TryParse(Console.ReadLine(), out count);

    if (!correct_count)
    {
        Console.WriteLine("Некорректный ввод, попробуйте ещё раз");
        return EnterTheCountOfStrings(message);
    }
    else
    {
        return count;
    }
}

// Метод заполнения массива строками
string[] FillArrayOfStrings(int length)
{
    string[] words = new string[length];
    for (int i = 0; i < length; i++)
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