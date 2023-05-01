// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(number);

void checkPalindrom(string str){
    
    if (str[0]==str[4] || str[1]==str[3]){
        Console.WriteLine($"Введенное число {number} является палиндромом");
    }
    else {
        Console.WriteLine($"Введенное число {number} не является палиндромом");
    }
}

if (str.Length != 5){
    Console.WriteLine($"Введенное число {number} не пятизначное");
}
else {
    checkPalindrom(str);
}
