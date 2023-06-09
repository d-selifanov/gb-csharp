// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int Prompt(string message){
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int[] FilligArray(int l){
    int[] array = new int[l];
    for (int i=0; i<l; i++){
        array[i] = Prompt($"Введите {i} элемент массива: ");
    }
    return array;
}

void ShowArray(int[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SearchPostitive(int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] > 0) {
            count++;
        }
    }
    return count;
}

int l = Prompt("Введите кол-во элементов массива: ");
int[] array;

array = FilligArray(l);
ShowArray(array);

Console.WriteLine($"Количество положительных элементом массива: {SearchPostitive(array)}");
