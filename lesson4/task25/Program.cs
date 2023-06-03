// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message){
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int Power(int a, int b){
    int power = 1;
    for (int i=0; i < b; i++){
        power *= a;
    }
    return power;
}

bool ValidationExponent(int b){
    if (b < 0) {
        Console.WriteLine ($"Число b не должно быть меньше 0 (b={b})");
        return false;
    }
    return true;
}

int a = Prompt("Введите число А:");
int b = Prompt("Введите число B:");

if (ValidationExponent(b)){
    Console.WriteLine($"Число {a} в в степени {b} равно = {Power(a,b)}");
}