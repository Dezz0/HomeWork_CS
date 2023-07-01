// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

// Исходный двумерный массив
        

void GetNumberFromMatrix(string coords){

    int[,] array = {
        {1, 4, 7, 2},
        {5, 9, 2, 3},
        {8, 4, 2, 4}
    };

    string[] position = coords.Split(',');

    int row = Convert.ToInt32(position[0].Trim());
    int column = Convert.ToInt32(position[1].Trim());

    if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
    {
        int value = array[row, column];
        Console.WriteLine("Значение элемента: " + value);
    }
    else
    {
        Console.WriteLine("Такого элемента нет.");
    }
}

Console.Write("Введите позицию элемента в формате \"строка, столбец\": ");
string coords = Console.ReadLine();

GetNumberFromMatrix(coords);