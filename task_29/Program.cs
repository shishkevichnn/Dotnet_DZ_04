/*Задача 29: Напишите программу, которая задаёт массив из N элементов, заполненных случайными числами из [a, b) 
и выводит их на экран.
5, 0, 20 -> [1, 2, 5, 7, 19]
3, 1, 35 -> [6, 1, 33]*/
Console.Write("Введите количество элементов в массиве : ");
int N = int.Parse(Console.ReadLine());
Console.Write("Введите диапозон случайных чисел из [a, b), число а: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите диапозон случайных чисел из [a, b), число b: ");
int b = int.Parse(Console.ReadLine());

void RandArray ()
{
    int[] arr = new int [N];
    
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a,b);
        //Console.Write("{0} ", arr[i]);
    }
    Console.WriteLine($"[{String.Join(", ", arr)}]");
}
RandArray();