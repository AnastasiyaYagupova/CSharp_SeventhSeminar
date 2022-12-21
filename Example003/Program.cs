/*
Задача 3. Необязательная, дополнительная задача 
Задайте двумерный массив из трехзначных целых чисел (не менее 100 элементов). 
В каждом столбце найдите среднее арифметическое среди тех элементов, которые являются палиндромами (если палиндромов нет, 
то среднее арифметическое считать равным 0). Полученные средние арифметические занести в одномерный массив.
Например, задан массив:
100 404 504 225
550 478 800 363
505 101 410 479
=> [505, 252.5, 0, 363 ]
*/

void FillArray(int [,] collection)
{
Random rand = new Random();
    for (int i = 0; i < collection.GetLength(0) ; i++)
    {
        for(int j = 0; j < collection.GetLength(1); j++)
        {
        collection[i,j] = rand.Next(100, 1000);
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

int[,] Array = new int[3,4];
FillArray(Array);
PrintArray(Array);


int CheckPalindrome(int[,] collection, int i, int j)
{
    int[] arr = new int[3];
    for(int index = 0; index < arr.Length; index++)
    {
        arr[index] = collection[i,j] % 10;
    }
    if(arr[0] == arr[arr.Length-1])
    {
        return collection[i,j];
    }
    else
    {
        return 0;
    }
}

for(int j = 0; j < Array.GetLength(1); j++)
{
    double result = 0;
    int count = 1;
    for(int i = 0; i < Array.GetLength(0); i++)
    {
        if(CheckPalindrome(Array, i, j) != 0)
        {
            result = (result + Array[i,j]) / count;
            count++;
        }
        else
        {
            continue;
        }
    }
    Console.WriteLine(result + " ");
}