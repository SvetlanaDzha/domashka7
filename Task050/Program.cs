// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

Console.Write("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс строки: ");
int positionLine = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int positionColumn = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (positionLine == i && positionColumn == j)
        {
            Console.Write($"Значение в заданной позиции: {array[positionLine, positionColumn]}");
        }
    }
    if (positionLine >= m || positionColumn >= n)
    {
        Console.Write($"Такого элемента в массиве нет");
        break;
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

