// Задайте значения M и N.
// Напишите программу, которая выведет все четные натуральные числа
// в промежутке от M до N с помощью рекурсии.
// M = 1, N = 5 -> "2,4"
// M = 4, N = 8 -> "4,6,8"

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

void PrintEvenNumbers(int m, int n)
{
    if(m>n)
    {
        return;
    }
    if (m % 2 == 0)
    {
        Console.Write($"{m},");
    }
    PrintEvenNumbers(m +1, n);
}
PrintEvenNumbers(m,n);