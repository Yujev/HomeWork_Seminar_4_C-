/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
Console.WriteLine("Введи число: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumNumber(int N)
{

    int sum2 = 0;
    int result = 0;
    int sum = Convert.ToString(N).Length;

    for (int i = 0; i < sum; i++)
    {
        result = result + (N - sum2);
        sum2 = N - N % 10;
        N = N / 10;
    }
    return result;
}

int sumNumber = SumNumber(N);
Console.WriteLine($"Сумма всех цифр в числе:  {sumNumber}");
