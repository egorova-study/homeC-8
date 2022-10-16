// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[ , ] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           matrix[i, j] = rnd.Next(min, max + 1); 
        }
    }

    return matrix;
}

void PrintMatrix (int [ , ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 2} ");
            else Console.Write($"{matrix[i, j], 2}");
        }
        Console.WriteLine("|");
    }
}

int matrixSizei = 3;
int matrixSizej = 4;
int [ , ] array2D = CreateMatrixRndInt(matrixSizei, matrixSizej, 0, 10);
PrintMatrix(array2D);
Console.WriteLine();


int[ , ] MaxSearch (int [ , ] array2D)
{ 
    for (int i = 0; i < matrixSizei; i++)
    {
        int max = array2D[i,0];
        for (int j = 0; j < matrixSizej; j++)
        {
            for (int k = j+1; k < matrixSizej; k++)
            {
                if (array2D[i,j]<array2D[i,k]) 
                {
                    max = array2D[i,j];
                    array2D[i,j] = array2D[i,k];
                    array2D[i,k] = max;
                }
            }
            
        }
        
        //Console.Write($"{array2D[i, j], 2} ");
    }
    return array2D;
}

int[ , ] newMatrix = MaxSearch(array2D);
PrintMatrix(newMatrix);