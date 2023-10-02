
// цикл for


string Method4(int count, string text)
{

    string result = String.Empty; // result - изначально будет пустой строкой
    for (int i = 0; i < count; i++)

        {
            result = result + text;

        }
    return result; // указывается та переменная, которую мы хотим получить из метода.
}

string res = Method4(5, "текст 4 метода, ");
Console.WriteLine(res);

// цикл в цикле (таблица умножния)


for (int i = 2; i <= 10; i++)
{
   for (int j = 2; j <= 10; j++)
   {
    Console.WriteLine($"{i} x {j} = {i*j}");   //интерполяция строк {}
   }
    Console.WriteLine(); // сделано для разрыва строк (пустая строка)
}
