// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Random random = new Random();
int[] array = new int[8]; 
int count = 0;

void GetCountEvenNumbers(){
    Console.Write("Сгенерированный массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
        Console.Write(array[i] + " ");
        if (array[i] % 2 == 0) count++;
    }
    
}
GetCountEvenNumbers();

Console.WriteLine("\nКоличество чётных чисел в массиве: " + count);