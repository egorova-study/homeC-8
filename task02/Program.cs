// Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
int matrixSizei = 5;
int matrixSizej = 4;
int [ , ] array2D = CreateMatrixRndInt(matrixSizei, matrixSizej, 0, 10);
PrintMatrix(array2D);

int sum = matrixSizei;

int[] summArray = new int[matrixSizei];

Console.WriteLine ("суммы элементов в каждой строке:"); 
for (int i = 0; i < matrixSizei; i++) 
{
    int rowSumm = 0;
    for (int j = 0; j < matrixSizej; j++)
    {
        rowSumm += array2D[i,j];

    }
    summArray[i] = rowSumm;
    Console.WriteLine ($" {summArray[i]}");
}

int n = 0;
int arrayMin = summArray[0];

for (int i = 0; i < matrixSizei; i++)
{
    if (summArray[i]<arrayMin) 
    {
        arrayMin=summArray[i];
        n = i;
    }
}

Console.WriteLine ($"номер строки с наименьшей суммой элементов:{n+1}");
