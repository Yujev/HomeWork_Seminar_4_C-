/*
Задача 29: Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/
int[] massive = GetBinaryArray(8);
Console.WriteLine($"[{String.Join(", ", massive)}]");

int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(8);
    }
    return result;

}
