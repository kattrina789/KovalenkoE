/*
Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.
*/

System.Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
void ReturnNum(int M, int N)
{
    if (M > N)
    {
        System.Console.Write(M + " ");
        ReturnNum((M - 1), N);
    }
    else if (M < N)
    {
        System.Console.Write(M + " ");
        ReturnNum((M + 1), N);
    }
    else
    {
        System.Console.WriteLine(M + " ");
    }

}
ReturnNum(M, N);