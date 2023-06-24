// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] array = { 1.5, 2.7, 3.9, 4.2, 5.1 };

double min = array[0];
double max = array[0];


for (int i = 1; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
}

double difference = Math.Round(max - min, 2);

Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);