

Console.WriteLine("Введите число M");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int num2 = Convert.ToInt32(Console.ReadLine());
int count = 0;
int num = 1;
if (num <= num2)
{
    if (num % 2 == 0)
    {
      Console.WriteLine( num + ", ");  
    }
    count++;
}

// PrintEvenNumbers(num1, num2);

// void PrintEvenNumbers(int start, int and)
// {
//     Console.Write(start + ", ");
//     if(start == and)
//     { 
//         return;
//     } 
//     else if(start % 2 == 0)
//     {
//         PrintEvenNumbers(start +1, and);
//     }  
// }

