// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// x = (b2 - b1) / (k1 - k2)
// y = k1 * x + b1

double[] arrayValuesTwoLines = ReadLineValues();

double[] result = IntersectionTwoLines(arrayValuesTwoLines);

Console.WriteLine($"({result[0]}; {result[1]})");


/*
* return:
*    double[0] = x;
*    double[1] = y;
*/
double[] IntersectionTwoLines(double[] arrayNumbers)
{
    double x = (arrayNumbers[2] - arrayNumbers[0]) / (arrayNumbers[1] - arrayNumbers[3]);
    double y = arrayNumbers[1] * x + arrayNumbers[0];
    double[] result = new double[]{x, y};
    return result;
}



/*
* return:
*    double[0] = B1;
*    double[1] = K1;
*    double[2] = B2;
*    double[3] = K2;
*/
double[] ReadLineValues()
{
    double[] arrayNumbers = new double[4];
    Console.WriteLine("Введите значение B1:");
    arrayNumbers[0] = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение K1:");
    arrayNumbers[1] = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение B2:");
    arrayNumbers[2] = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение K2:");
    arrayNumbers[3] = double.Parse(Console.ReadLine());
    return arrayNumbers;
}