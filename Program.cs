//Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.

Console.Clear();

Console.Write("Введите кол-во строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите кол-во столбцов массива: ");
int colums = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите кол-во глубины массива: ");
int depth = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine();

double[,,] array = GetArray(rows, colums, depth, -10, 10);
PrintArray(array);

double[,,] GetArray(int m, int n, int x, int minValue, int maxValue)
{
    double[,,] result = new double[m, n, x];
    double AfterPointResult = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int y = 0; y < depth; y++)
            {
                result[i, j, y] = new Random().Next(minValue, maxValue + 1);
                AfterPointResult = new Random().NextDouble();
                result[i, j, y] = result[i, j, y] + AfterPointResult;
                result[i, j, y] = Math.Round(result[i, j, y], 1);
            }
        }
    }
    return result;
}

void PrintArray(double[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int y = 0; y < depth; y++)
            {
                Console.Write($"{matrix[j, y, i]} {(j, y, i)}" + "\t");
            }
            Console.WriteLine();
        }
    }
}