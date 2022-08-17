/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.WriteLine("Введи число ");
int a = Convert.ToInt32 (Console.ReadLine());
int b = Convert.ToInt32 (Console.ReadLine());
int c = a;
for (int i = 1, с = c; b > i; i++)
{
    a = a * с;
}
Console.WriteLine(a);