﻿// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillMatrixWithRandom(int[,,] matrix)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = random.Next(10, 100); 
            }
        }
    }
}

void PrintIndexsOfNumberFromMatrix(int[,,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} -> ({i}, {j}, {k}) ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}

int[,,] matrix = new int[3,2,3];

Console.WriteLine("Матрица случайных чисел: ");
FillMatrixWithRandom(matrix);
PrintIndexsOfNumberFromMatrix(matrix);


