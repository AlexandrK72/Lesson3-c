// вид 1 - не принимают и не возвращают
using System.Diagnostics.Contracts;
using System.Diagnostics.Metrics;

void Method1()
{
    Console.WriteLine("Автор ...");
}

Method1(); // обязательно со скобками.

// вид 2 - которые не возвращают, но могут принимать данные.

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; // это назывеся инкримент, если с минусом - декремент count--;
    }
}

Method21("Text", 4);

Method21(count: 4, msg: "New Text");


// Вид 3 - метод который что-то возвращает, но ничего не ринимает.
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();

Console.WriteLine(year);


// Вид 4 - метод, который что-то принимает, и что-то возвращает.

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // result - изначально будет пустой строкой

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result; // указывается та переменная, которую мы хотим получить из метода.
}

string res = Method4(5, "текст 4 метода, ");
Console.WriteLine(res);