// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9;
// m = 3, n = 2 -> A(m,n) = 29;

int Ackerman(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    else if(n == 0)
    {
       return Ackerman(m - 1, 1);
    }
    else
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
}
// Console.WriteLine(Ackerman(0, 0));
// Console.WriteLine(Ackerman(0, 1));
// Console.WriteLine(Ackerman(1, 1));
// Console.WriteLine(Ackerman(1, 2));
// Console.WriteLine(Ackerman(2, 2));
Console.WriteLine(Ackerman(2, 3));//9
Console.WriteLine(Ackerman(3, 2));//29