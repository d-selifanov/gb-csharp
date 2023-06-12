// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Prompt(string message){
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

void PrintNumbers(int m, int n){
    if (m <= n){
        PrintNumbers(m + 1, n);
        Console.Write($"{m} ");
    }
}

int n = Prompt("Задайте значение N: ");
int m = 1;

PrintNumbers(m, n);
Console.WriteLine();
