/*
Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
Тип данных для элементов выбрать double, наличие ненулевой дробной части обязательно.
m = 3, n = 4.
0.5 7.96 -2.78 -0.2
1.7 -3.3 8.574 -9.9
8.5 7.87 -7.1 9.15
*/

Console.WriteLine("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество стоблцов ");
int n = Convert.ToInt32(Console.ReadLine());

void FillArray(double[,] collection)
{
Random rand = new Random();
    for (int i = 0; i < collection.GetLength(0) ; i++)
    {
        for(int j = 0; j < collection.GetLength(1); j++)
        {
        collection[i,j] = rand.Next(-1000,1000)/100.0;
        }
    }
} 

void PrintArray(double[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write(collection[i,j] + "|");
        }
        Console.WriteLine();
    }
}

double[,] Array = new double[m,n];
FillArray(Array);
PrintArray(Array);

