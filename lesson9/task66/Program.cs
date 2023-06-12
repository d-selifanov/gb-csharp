// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string message){
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}


int Sum(int m, int n){
    if (m == n){
        return m;
    }
    var direction = n > m ? 1 : -1;
    return Sum(m + direction, n) + m;
}

int m = Prompt("Введите M: ");
int n = Prompt("Введите N: ");

Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равна: {Sum(m, n)}");