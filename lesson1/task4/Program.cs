// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberB > max){
    max = numberB;
}
if (numberC > max){
    max = numberC;
}

Console.WriteLine($"Максимальное из трех чисел \"{numberA} {numberB} {numberC}\" равно {max}");
