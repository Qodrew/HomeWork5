// #.38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] arrayFromElements = arrayNumbers(new Random().Next(2, 10));
int[] arrayNumbers(int size) {
    int[] result = new int[size];
    for (int i = 0; i < size; i++) {
        result[i] = new Random().Next(1, 99);
    } 
    return result;
}
Console.WriteLine($"[{String.Join(" ", arrayFromElements)}]");
int maxNum = arrayFromElements[0];
int minNum = arrayFromElements[1];
for (int j = 0; j < arrayFromElements.Length; j++)
{
    if (arrayFromElements[j] > maxNum)
    {
        maxNum = arrayFromElements[j];
    }
    else if (arrayFromElements[j] < minNum ) minNum = arrayFromElements[j];
}
Console.WriteLine($"Разница между максимальным числом в массиве и минимальным равна: {maxNum - minNum}");
