// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000){
    string str = Convert.ToString(number);
    Console.Write($"Вторая цифра введенного числа {number} - {str[1]}");
}
else {
    Console.Write("Вы ввели не трехзначное число");
}
