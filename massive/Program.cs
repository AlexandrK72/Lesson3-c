


int[] arr = {1, 5, 4, 3 , 2, 2, 6, 7, 1};

void PrintArray(int[] array) // метод выводящий массив
{
    int count = array.Length; // получение количества элементов

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();

}

void SelectionSort(int [] array) // метод упорядывающий данный массив
{

    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;

        for (int j = i+1 ; j < array.Length; j++)   //этот блок ищет максимльный элемент
        {
            if(array[j]< array[minPosition]) minPosition = j;
        }



        int temporary = array[i]; // присваиваем временную переменную значение рабочей позиции
        array[i] = array[minPosition]; // в i-тую позицию вкладываем найденный элемент
        array[minPosition] = temporary; // присваиваем найденную позицию переменную временную

    }

} 



PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
