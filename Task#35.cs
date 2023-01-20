// #.34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] arrayFromElements = arrayNumbers(new Random().Next(2, 10));
int countPositive = 0;
int[] arrayNumbers(int size) {
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(100, 999);
    } 
    return result;
}
Console.WriteLine($"[{String.Join(", ", arrayFromElements)}]");
for (int j = 0; j < arrayFromElements.Length; j++)
{
    if (arrayFromElements[j] % 2 == 0)
    {
        countPositive++;
    }
}
Console.WriteLine($"Количество четных чисел в массиве: {countPositive}");
