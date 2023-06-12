// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int Prompt(string message){
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

void FillMatrixWhithRandomNumbers(int[,] matrix){
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            matrix[i, j] = rand.Next(0, 11);
        }
    }
}

void PrintMatrix(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            Console.Write($"{matrix[i, j]} " + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("-----------------------------------------------");
}

void SortArray(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++){
    for (int j = 0; j < matrix.GetLength(1); j++){
      for (int k = 0; k < matrix.GetLength(1) - 1; k++){
        if (matrix[i, k] < matrix[i, k + 1]){
          int t = matrix[i, k + 1];
          matrix[i, k + 1] = matrix[i, k];
          matrix[i, k] = t;
        }
      }
    }
  }
}

int m = Prompt("Введите количество строк: ");
int n = Prompt("Введите количество столбцов: ");
int[,] matrix = new int[m, n];

FillMatrixWhithRandomNumbers(matrix);
PrintMatrix(matrix);

SortArray(matrix);
PrintMatrix(matrix);
