// Задайте значения M и N.
// Напишите программу, которая найдет сумму натуральных элементов
// в промежутке от M до N с помощью рекурсии.
// M = 1, N = 15 -> 120;
// M = 4, N = 8 -> 30;


Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int m, int n)
{
    if(m == n)
    {
        return n;
    }
    else return m + SumNumbers(m +1,n);
}
Console.Write(SumNumbers(m,n));
//SumNumbers(m,n);

