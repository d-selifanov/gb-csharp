// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int Prompt(string message)
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

void FillMatrixWhithRandomNumbers(int[,] matrix)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 11);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} " + "\t");
        }
        Console.WriteLine();
    }
}

int m = Prompt("Введите количество строк: ");
int n = Prompt("Введите количество столбцов: ");
int[,] matrix = new int[m, n];
FillMatrixWhithRandomNumbers(matrix);
PrintMatrix(matrix);

int index_m = Prompt("Введите индекс строки: ");
int index_n = Prompt("Введите индекс столбца: ");

if (index_m > matrix.GetLength(0) || index_n > matrix.GetLength(1)){
    Console.WriteLine($"Элемента с индексами ({index_m}, {index_n}) нет в массиве"); 
}
else {
    Console.WriteLine($"Элемент с индексами ({index_m}, {index_n}) равен: {matrix[index_m,index_n]}");
}
