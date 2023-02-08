/*Задайте двумерный массив. 
Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

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

void PrinArray(int[,] array)
{
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

int[,] SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(1); n++)
            {
                for (int m = 0; m < array.GetLength(1) - 1; m++)
                {
                    if (array[n, m] < array[n, m + 1])
                    {
                        int temp = array[n, m];
                        array[n, m] = array[n, m + 1];
                        array[n, m + 1] = temp;
                    }
                }
            }


        }
    }
    return array;
}


int rowM = InputInt("Введите количество строк массива");
int columnN = InputInt("Введите количество столбцов массива");
int[,] baseArray = CreateArray(rowM, columnN);
PrinArray(baseArray);
PrinArray(SortArray(baseArray));

