// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = 
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},        
    {8, 4, 2, 4}
};

double[] GetColumnAverage (){
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    double[] columnAverages = new double[columns];

    for (int column = 0; column < columns; column++)
    {
        int sum = 0;

        for (int row = 0; row < rows; row++)
        {
            sum += array[row, column];
        }

        columnAverages[column] = (double)sum / rows;
    }

    return columnAverages;
}

void PrintColumnAverage(double[] columnAverages){
    int columns = array.GetLength(1);
    
    Console.WriteLine("Среднее арифметическое каждого столбца:");

    for (int column = 0; column < columns; column++)
    {
        Console.WriteLine($"Столбец {column + 1}: {Math.Round(columnAverages[column], 2)}");
    }
}

GetColumnAverage();
PrintColumnAverage(GetColumnAverage());