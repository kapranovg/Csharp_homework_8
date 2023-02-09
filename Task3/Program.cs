/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
***Число столбцов матрицы 1 должно быть равно числу строк матрицы 2
*/

int InputInt(string message)
{
    System.Console.WriteLine(message + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateArray(int row, int col)
{
    Random rnd = new Random();
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array, string message)
{
    System.Console.WriteLine(message);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}" + "\t");
        }
    }
    System.Console.WriteLine();
}

int[,] MultiplicationArray(int[,] arrayA, int[,] arrayB)
{
    int[,] array = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            array[i, j] = 0;
            for (int k = 0; k < arrayB.GetLength(0); k++)
            {
                array[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return array;
}

System.Console.WriteLine("Теория: Произведение двух матриц возможно только в том случае, если количество "
                        + "столбцов матрицы 1 совпадает с количеством строк матрицы 2");
System.Console.WriteLine();
int rowFirtsM = InputInt("Введите количество строк матрицы 1");
int columnFirstN = InputInt("Введите количество столбцов матрицы 1");
int[,] firstArray = CreateArray(rowFirtsM, columnFirstN);
PrintArray(firstArray, "Матрица 1:");
int rowSecondM = columnFirstN;
int columnSecondN = InputInt("Введите количество столбцов матрицы 2");
int[,] secondArray = CreateArray(rowSecondM, columnSecondN);
PrintArray(secondArray, "Матрица 2:");
PrintArray(MultiplicationArray(firstArray, secondArray), "Умножение матриц 1х2:");