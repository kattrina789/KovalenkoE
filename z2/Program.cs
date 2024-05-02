/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

функция ack(n, m)
   если n = 0
     вернуть m + 1
   иначе, если m = 0
     вернуть ack (n - 1, 1)
   еще
     вернуть ack(n - 1, ack (n, m - 1))
*/

System.Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());
int Ack(int n, int m)
{
    if (n == 0)
    {
        return (m + 1);
    }
    else if (m == 0)
    {
        return Ack(n - 1, 1);

    }
    else
    {
        return Ack(n - 1, Ack(n, m - 1));
    }
}
int result = Ack(n, m);
System.Console.WriteLine(result);

