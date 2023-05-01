// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 8){
    switch (number) {
        case 6:{
            Console.WriteLine($"Вы ввели {number} - это выходной день суббота");
            break;
        }
        case 7:{
            Console.WriteLine($"Вы ввели {number} - это выходной день воскресенье");
            break;
        }
        default: {
            Console.WriteLine($"Вы ввели {number} - это не выходной день");
            break;
        }
    }
}
else {
    Console.WriteLine($"Вы ввели {number} - это не день недели");
}