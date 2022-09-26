//47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
//m=3,n=4
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8  7,8-7,1 9

double [,] GenerateArray (int row, int colum)
{   double[,] array = new double [ row, colum ];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
              array [i,j] = rnd.NextDouble();
        }
    }
    return array;
}

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]:f2}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

double [,] myarray = GenerateArray(3,4);
PrintArray(myarray);