/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
Random yuy = new Random();
int[] array = new int[8];
for (int i = 0; i< array.Length; i++)
{
    array[i] = yuy.Next(0, 100);
    if (i == 7)
    {
        Console.Write($"{array[i]}]");
        break;
    }
    else if (i == 0)
    {
        Console.Write("[");
    }
    else 
    {
        Console.Write($"{array[i]}, ");
    }

}

