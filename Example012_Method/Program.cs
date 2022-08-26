//1. Ничего не принимает и ничего не возвращает

void Method1()
{
    Console.WriteLine("Автор: ");
}
Method1();

//2. Ничего не возвращает, но в тоже время может принимать
// какие-то аргументы

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текстовое сообщение ");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("текст", 4);

//3. Этот метод что-то возвращает, но ничего не принимает

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

//4. Этот метот что-то принимает и что-то возвращает


string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "Z");
Console.WriteLine(res);


string Method5(int count, string c)
{
    string result = String.Empty;
    for (int i = 0; i < 10; i++)
    {
        result = result + c;
    }
    return result;
}

string rus = Method5(10, "Z");
Console.WriteLine(rus);

// Таблица на умножение

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}


// Таблица на сложение

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} + {j} = {i + j}");
    }
    Console.WriteLine();
}
