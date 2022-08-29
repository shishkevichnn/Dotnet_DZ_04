/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
Реализовать функцию возведения в степень самостоятельно!*/

Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

int NaturStepen(int a)
{
    int res = 1;
    for (int i = 0; i < numberB; i++)
    {
    res = res * a;
    }
    return res;
}
Console.WriteLine(NaturStepen(numberA));
