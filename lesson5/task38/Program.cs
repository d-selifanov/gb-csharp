// Задача 38: Задайте массив вещественных(тип double) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1

int Prompt(string message){
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

Random rand = new Random(); 

double[] CreateRandomArray(int l, int min, int max){
    double[] randomArray = new double[l];
    
    for (int i = 0; i < l; i++){
        randomArray[i] = rand.Next(min, max);
    }
    return randomArray;
}

void ShowArray(double[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double MaxElem (double[] array){
    double max = array[0];
	for (int i = 0; i < array.Length; i++){
		if (max < array[i]){
			max = array[i];
		}
	}
	return max;
}

double MinElem (double[] array){
    double min = array[0];
	for (int i = 0; i < array.Length; i++){
		if (min > array[i]){
			min = array[i];
		}
	}
	return min;
}

int l = Prompt("Введите длину массива: ");
double[] array = CreateRandomArray(l, 1, 1000);

ShowArray(array);

double result = MaxElem(array) - MinElem(array);

Console.WriteLine($"Разницу между максимальным и минимальным элементом массива равна: {result}");
