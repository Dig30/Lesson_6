// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] array = ReadLineArray();
int result = CountNumbersMoreZero(array);
Console.WriteLine($"Ответ: {result}");


int CountNumbersMoreZero(int[] arrayNumbers)
{
    int result = 0;
    for (int i = 0; i < arrayNumbers.Length; i++) {
        if (arrayNumbers[i] > 0) {
            result++;
        }
    }
    return result;
}

int[] ReadLineArray()
{
    Console.WriteLine("Введите целые числа: ");
    int[] result = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
    return result;
}