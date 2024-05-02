/*
Задайте произвольный массив. Выведете его элементы, 
начиная с конца. 
Использовать рекурсию, не использовать циклы.
*/
int[] array = { 1, 2, 3, 4, 5, 6 };
void PrintArray(int[] array, int i = 0)
{
    if (i == array.Length)
    {
        return;
    }
    else
    {
        System.Console.Write(array[array.Length -1- i] + " ");
        PrintArray(array, i + 1);
    }
}
PrintArray(array);
