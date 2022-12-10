// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
int DataEntry(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] FillArray(int[] array)
{
    int length = array.Length;
    int i;
    for (i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int i;
    for (i = 0; i < count; i++)
    {
        Console.Write($"{col[i]} ");
    }
}

int arraySize = DataEntry("Введите размер массива: ");
int[] array = new int[arraySize];
array = FillArray(array);
PrintArray(array);