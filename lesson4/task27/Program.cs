// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message){
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int Sum(int a){
    int result = 0;
    if ( a < 0){ 
        a = a * -1;
    };
    while (a > 0){
        result += a % 10;
        a = a / 10;
    }
    return result;
}

int a = Prompt("Введите число: ");
Console.WriteLine($"Сумма цифр в числе {a} = {Sum(a)}");