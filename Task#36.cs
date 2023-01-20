// #.36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] arrayFromElements = arrayNumbers(new Random().Next(2, 10));
int sumNegativeIndex = 0;
int[] arrayNumbers(int size) {
    int[] result = new int[size];
    for (int i = 0; i < size; i++) {
        result[i] = new Random().Next(1, 100);
    } 
    return result;
}
Console.WriteLine($"[{String.Join(", ", arrayFromElements)}]");
for (int j = 0; j < arrayFromElements.Length; j++)
{
    if (j % 2 != 0)
    {
        sumNegativeIndex += arrayFromElements[j];
    }
}
Console.WriteLine($"Сумма чисел, стоящих на нечетных индексах: {sumNegativeIndex}");
