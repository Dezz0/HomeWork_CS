// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillMatrixWithRandom(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
        Console.WriteLine();
    }
}

int GetNumberRowWithMinSum(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    int minSum = int.MaxValue;
    int minSumRowIndex = -1;

    for (int i = 0; i < rows; i++)
    {
        int rowSum = 0;

        for (int j = 0; j < cols; j++)
        {
            rowSum += matrix[i, j];
        }

        if (rowSum < minSum)
        {
            minSum = rowSum;
            minSumRowIndex = i;
        }
    }
    return minSumRowIndex;
}

Console.WriteLine("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());


int[,] matrix = new int[row, column];

Console.WriteLine("Матрица случайных чисел: ");
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);

Console.Write($"Строка с наименьшей суммой элементов: {GetNumberRowWithMinSum(matrix) + 1}" );

