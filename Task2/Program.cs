/*Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер 
строки с наименьшей суммой элементов: 1 строка*/

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

void PrintArray(int[,] array)
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

int[] SumStringArray(int[,] array)
{
   int[] sumArray = new int[array.GetLength(0)];
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumArray[i] += array[i, j];
        }
    }
    return sumArray;
}

void PrintSumArray(int[] array)
{
    System.Console.WriteLine("Сумма строк базового массива:");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "\t");
    }
    System.Console.WriteLine();
}

int MinSumStringArray(int[] array)
{
    int minIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[minIndex]) 
        {
            minIndex = i;
        }
    }
    return minIndex;
}

int rowM = InputInt("Введите количество строк массива");
int columnN = InputInt("Введите количество столбцов массива");
int[,] baseArray = CreateArray(rowM, columnN);
PrintArray(baseArray);
int[] summaryStringArray = SumStringArray(baseArray);
PrintSumArray(summaryStringArray);
System.Console.WriteLine($"Строка массива с минимальной суммой элементов - {MinSumStringArray(summaryStringArray) + 1}");
