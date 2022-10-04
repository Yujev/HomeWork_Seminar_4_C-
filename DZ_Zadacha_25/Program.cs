/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/


Console.WriteLine("Введи первое число А: ");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введи второе число В: ");
int B = int.Parse(Console.ReadLine()!);

int value = A;

for (int i = 0; i <= B; i++)
{
    value = Convert.ToInt32(Math.Pow(A, B));
}

Console.WriteLine($"Натуральная степень числа А из числа В = {value}");

