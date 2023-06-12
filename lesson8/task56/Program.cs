// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int Sum(int[,] matrix, int i){
    int sum = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++){
        sum += matrix[i, j];
    }
    return sum;
}

void MinSumRow(int[,] matrix){
    int minRow = 0;
    int minSum = Sum(matrix, 0);
    for (int i = 1; i < matrix.GetLength(0); i++){
        int t = Sum(matrix, i);
        if (minSum > t){
            minSum = t;
            minRow = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow + 1} (сумма элементов строки: {minSum})");
}

int m = Prompt("Введите количество строк: ");
int n = Prompt("Введите количество столбцов: ");
int[,] matrix = new int[m, n];

FillMatrixWhithRandomNumbers(matrix);
PrintMatrix(matrix);

MinSumRow(matrix);
