// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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


int[,] Multiplication(int[,] a, int[,] b)
        {
            int[,] r = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i,j] += a[i,k] * b[k,j];
                    }
                }
            }
            return r;
        }

void PrintMatrix (int [ , ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} ");
            else Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("|");
    }
}


int matrix1Sizei = 2;
int matrix1Sizej = 2;
int [ , ] array1 = CreateMatrixRndInt(matrix1Sizei, matrix1Sizej, 1, 10);
PrintMatrix(array1);

Console.WriteLine();

int matrix2Sizei = 2;
int matrix2Sizej = 2;
int [ , ] array2 = CreateMatrixRndInt(matrix2Sizei, matrix2Sizej, 1, 10);
PrintMatrix(array2);

Console.WriteLine();

int[ , ] resultArray = Multiplication(array1, array2);
PrintMatrix(resultArray);