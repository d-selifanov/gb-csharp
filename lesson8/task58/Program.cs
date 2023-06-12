// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18

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

void Mult(int[,] matrix1, int[,] matrix2, int[,] multMatrix){
    for (int i = 0; i < multMatrix.GetLength(0); i++){
        for (int j = 0; j < multMatrix.GetLength(1); j++){
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++){
                sum += matrix1[i, k] * matrix2[k, j];
            }
            multMatrix[i, j] = sum;
        }
    }
}

int m = Prompt("Введите количество строк матрицы 1: ");
int n = Prompt("Введите количество столбцов матрицы 1: ");
int[,] matrix1 = new int[m, n];
FillMatrixWhithRandomNumbers(matrix1);
PrintMatrix(matrix1);


int x = Prompt("Введите количество строк матрицы 2: ");
int y = Prompt("Введите количество столбцов матрицы 2: ");
int[,] matrix2 = new int[x, y];
FillMatrixWhithRandomNumbers(matrix2);
PrintMatrix(matrix2);

if (matrix1.GetLength(1) == matrix2.GetLength(0)){
    int[,] multMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    Mult(matrix1, matrix2, multMatrix);
    PrintMatrix(multMatrix);
}
else {
    Console.WriteLine("Матрицы нельзя перемножить");
}




