// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int Prompt(string message){
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

void FillMatrixWhithRandomNumbers(int[,,] matrix){
    Random rand = new Random();
    int[] t = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
    int number;
    for (int i = 0; i < t.GetLength(0); i++){
        t[i] = rand.Next(10, 100);
        number = t[i];
        if (i >= 1){
            for (int j = 0; j < i; j++){
                while (t[i] == t[j]){
                    t[i] = rand.Next(10, 100);
                    j = 0;
                    number = t[i];
                }
                number = t[i];
            }
        }
    }
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            for (int k = 0; k < matrix.GetLength(2); k++){
                matrix[i, j, k] = t[count];
                count += 1;
            }
        }
    }
}

void PrintMatrix(int[,,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            for (int k = 0; k < matrix.GetLength(2); k++){
                Console.Write($"{matrix[i, j, k]}({i}, {j}, {k})  ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine("-----------------------------------------------");
}


int x = Prompt("Введите X трехмерного массива: ");
int y = Prompt("Введите Y трехмерного массива: ");
int z = Prompt("Введите Z трехмерного массива: ");

int[,,] matrix = new int[x, y, z];

FillMatrixWhithRandomNumbers(matrix);
PrintMatrix(matrix);
