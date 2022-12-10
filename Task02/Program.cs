// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
int DataEntry(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SumOfNumbers(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + (number % 10);
        number = number / 10;
    }
    return sum;
}

int number = DataEntry("Введите число ");
int sum = SumOfNumbers(number);
Console.WriteLine($"{number} -> {sum}");