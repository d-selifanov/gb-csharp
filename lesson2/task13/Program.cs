// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string str = Convert.ToString(number);


if (number > 0){
    if (str.Length > 2) {
        Console.WriteLine($"Третья цифра, введенного числа {number} - {str[2]}");
    }
    else {
        Console.WriteLine($"Введенное число {number} - третьей цифры нет");
    }
}
else {
    if (str.Length > 3) {
        Console.WriteLine($"Третья цифра, введенного числа {number} - {str[3]}");
    }
    else {
        Console.WriteLine($"Введенное число {number} - третьей цифры нет");
    }
}

