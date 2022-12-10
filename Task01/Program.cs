// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
int DataEntry(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Degree(int numberA, int numberB)
{
    int degree;
    int scale = numberA;
    for (degree = 1; degree < numberB; degree++)
    {
        scale = scale * numberA;
    }
    return scale;
}

int numberA = DataEntry("Введите первое число: ");
int numberB = DataEntry("Введите второе число: ");
int product = Degree(numberA, numberB);
Console.WriteLine($"{numberA}, {numberB} -> {product}");