// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int Prompt(string message){
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

Random rand = new Random(); 

int[] CreateRandomArray(int l, int min, int max){
    int[] randomArray = new int[l];
    for (int i = 0; i < l; i++){
        randomArray[i] = rand.Next(min, max);
    }
    return randomArray;
}

void ShowArray(int[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int EvenNumbers(int[] array){
    int result = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] % 2 == 0){
            result += 1;
        }
    }
    return result;
}

int l = Prompt("Введите длину массива: ");

int[] array = CreateRandomArray(l, 100, 1000);
ShowArray(array);
int resultEvent = EvenNumbers(array);

Console.WriteLine($"Кол-во четных чисел в массиве равно: {resultEvent}");
