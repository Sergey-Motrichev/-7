//52 Задайте двумерный массив из целых чисел.Найдите среднее
//арифметическое элементов в каждом столбце.
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Cреднее арифметическое каждого столбца:4,6;5,6;3,6;3.

int[,] GenerateArray(int rows, int columns, int minRnd, int maxRnd)
{
       int [,] array = new int [rows,columns];
       Random rnd = new Random();
       for (int i = 0; i<array.GetLength(0); i++)
       {
           for(int j=0; j<array.GetLength(1); j++)
           {
               array[i,j] = rnd.Next(minRnd,maxRnd+1);
           }
       }
        return array;       
}

void PrintArray (double[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
         System.Console.Write($"{arr[i]}\t");
    }
    System.Console.WriteLine();
}   
void PrintArrayMatrix( int[,] matrix)
{
    for (int i=0; i< matrix.GetLength(0); i++ )
    { 
        for(int j=0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}    
double [] Sred(int[,] array)
{
double sum=0;
double [] result =new double[array.GetLength(0)];
     for (int i = 0; i<array.GetLength(1); i++)
       {
           for(int j=0; j<array.GetLength(0); j++)
           {
            sum+=array[j,i];
           }
           result[i]=sum/array.GetLength(0);
           sum=0;
       }
       return result;
}  
int[,] myarray = GenerateArray(3,3,0,10);
PrintArrayMatrix (myarray);
double [] resultarray = Sred(myarray);
System.Console.WriteLine($"Среднее арифметическое в каждом " + 
 "столбце массива:");
PrintArray(resultarray);
        