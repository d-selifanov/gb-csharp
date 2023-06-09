// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
    Console.WriteLine("-----------------------------------------------");
}

int m = Prompt("Введите количество строк: ");
int n = Prompt("Введите количество столбцов: ");
int[,] matrix = new int[m, n];

FillMatrixWhithRandomNumbers(matrix);
PrintMatrix(matrix);

for (int j = 0; j < matrix.GetLength(1); j++){
    double avg = 0;
    for (int i = 0; i < matrix.GetLength(0); i++){
        avg = (avg + matrix[i, j]);
    }
    avg = avg / n;
    Console.Write($"{avg}" + "\t");
}
