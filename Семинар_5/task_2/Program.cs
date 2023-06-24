// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Random random = new Random();
int[] array = new int[10]; 
int sum = 0;

void CalculateOddNumbers(){
    Console.Write("Сгенерированный массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 100);
        Console.Write(array[i] + " ");

        if (i % 2 != 0) sum += array[i];
    }
}

CalculateOddNumbers();

Console.WriteLine("\nСумма элементов, стоящих на нечетных позициях: " + sum);