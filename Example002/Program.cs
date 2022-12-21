/*
Задача 2. Напишите программу, которая на вход принимает позиции (два индекса) элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> такого числа в массиве нет
*/

void FillArray(int [,] collection)
{
Random rand = new Random();
    for (int i = 0; i < collection.GetLength(0) ; i++)
    {
        for(int j = 0; j < collection.GetLength(1); j++)
        {
        collection[i,j] = rand.Next(0, 10);
        }
    }
} 

void PrintArray(int [,] collection)
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
Console.WriteLine("Введите индекс строки ");
int i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индекс стоблца ");
int j = Convert.ToInt32(Console.ReadLine());

int [,] Array = new int [5,5];
FillArray(Array);
PrintArray(Array);

if(i < Array.GetLength(0) && j < Array.GetLength(1))
{
    Console.WriteLine(Array[i,j]);
}
else
{
    Console.WriteLine($"[{i},{j}] - такого числа в массиве нет");
}

