// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// 5*x+2
// 9*x+4

const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X = 0;
const int Y = 1;
const int line1 = 1;
const int line2 = 2;

double Prompt(string line){
    Console.Write(line);
    string val = Console.ReadLine();
    double result = Convert.ToDouble(val);
    return result;
};

double[] InputLineData(int numberOfLine){
    double[] lineData = new double[2];
    lineData[COEFFICIENT] = Prompt($"Введите коэффициент для прямой {numberOfLine}: ");
    lineData[CONSTANT] = Prompt($"Введите константу для прямой {numberOfLine}: ");
    return lineData;
}

double[] FindCoordinates(double[] lineData1, double[] lineData2){
    double[] coord = new double[2];
    coord[X] = (lineData1[CONSTANT] - lineData2[CONSTANT]) / (lineData2[COEFFICIENT] - lineData1[COEFFICIENT]);
    coord[Y] = lineData1[COEFFICIENT] * coord[X] + lineData1[CONSTANT];
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2){
    if (lineData1[COEFFICIENT] == lineData2[COEFFICIENT]){
        if (lineData1[CONSTANT] == lineData2[CONSTANT]){
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}

double[] lineData1 = InputLineData(line1);
double[] lineData2 = InputLineData(line2);

if (ValidateLines(lineData1, lineData2)){
    double[] coord = FindCoordinates(lineData1, lineData2);
    Console.Write($"Точка пересечения уравнений y={lineData1[COEFFICIENT]}*x+{lineData1[CONSTANT]} и y={lineData2[COEFFICIENT]}*x+{lineData2[CONSTANT]} ");
    Console.WriteLine($" имеет координаты ({coord[X]}, {coord[Y]})");
}

