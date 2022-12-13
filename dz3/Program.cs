// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

double[] array = new double[7] {0.2, 2.3, 4.5, 5.2,6.3, 1.2, 9.7};

double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        max = array[i];
    if (array[i] < min)
        min = array[i];
}

for (int i = 0; i < array.Length; i++)
     Console.Write($"{array[i]} ");
Console.Write($"-> {max - min}");
