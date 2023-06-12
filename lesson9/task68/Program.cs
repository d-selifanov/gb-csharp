// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message){
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int Akkerman(int m, int n){
    if (m == 0){
        return n + 1;
    }
    else if ((m > 0) && (n == 0)){
        return Akkerman(m - 1, 1);
    }
    else if ((m > 0) && (n > 0)){
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    else {
        return n + 1;
    }
}

int m = Prompt("Введите M: ");
int n = Prompt("Введите N: ");

Console.WriteLine($"Вычисление функции Аккермана для чисел {m} и {n} равно {Akkerman(m, n)}");
