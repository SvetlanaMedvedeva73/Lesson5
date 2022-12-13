/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве. */

int[] array = new int[7];
for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100,999);

int n = 0;

for (int i = 0; i < array.Length; i++)
     if (array[i] % 2 ==0)
         n++;

for (int i = 0; i < array.Length; i++)
     Console.Write($"{array[i]} ");
Console.Write($"-> {n}");
