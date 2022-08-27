﻿//======Работа с текстом
// Дан текс. В тексте нужно все пробелы заменить черточками,
// маленькие буквы 'к' заменить большими 'К',
// а большие "С" заменить на маленькие

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы датите мне час?";

// string s = qwerty
//            012345
// s[3]  // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '-');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'с', 'С');
Console.WriteLine(newText);


// Отсортировать массив. Алгоритм сортировки
// методом выбора

int [] arr = {5, 8, 2, 1, 3, 6, 4, 7};

void PrintArray(int [] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array [j] < array[minPosition]) minPosition = j;
        }    
            int temporary = array[i];
            array [i] = array[minPosition];
            array [minPosition] = temporary;
        
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);