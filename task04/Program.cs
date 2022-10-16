// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


int[ , , ] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    int[, ,] matrix = new int[rows, columns, depth];
    var rnd = new Random();

    int value = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
            matrix[i, j, k] = value; //rnd.Next(min, max + 1);
            value++;
            }
        }
    }

    return matrix;
}

void PrintMatrix (int [ ,, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
            Console.Write($"{matrix[i, j, k], 4} ({i}, {j}, {k})");
            }
        }
        Console.WriteLine("|");
    }
}

int matrixSizei = 2;
int matrixSizej = 2;
int matrixSizek = 2;
int [ ,, ] array3D = CreateMatrixRndInt(matrixSizei, matrixSizej, matrixSizek, 10, 100);
PrintMatrix(array3D);