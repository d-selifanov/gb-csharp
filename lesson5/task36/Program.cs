// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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


int SumElements(int[] array){
    int sum = 0;
    for (int i = 0; i < array.Length; i++){
        if (i % 2 != 0){
            sum += array[i];
        }
    }
    return sum;
}

int l = Prompt("Введите длину массива: ");
int[] array = CreateRandomArray(l, 100, 1000);
ShowArray(array);

int result = SumElements(array);
Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях равна: {result}");